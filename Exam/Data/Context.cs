using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Exam.Data
{
    public class Context
    {
        private readonly GlobalContext globalContext;
        private readonly NavigationManager navigationManager;
        private readonly IWebHostEnvironment environment;

        /// <summary>
        /// 수험생 정보
        /// </summary>
        public Examinee Examinee { get; private set; }
               
        /// <summary>
        /// 시험 정보
        /// </summary>
        public Examination Examination { get; private set; }

        /// <summary>
        /// 답안지
        /// </summary>
        public AnswerPaper AnswerPaper { get; private set; }

        /// <summary>
        /// 로그인 유무
        /// </summary>
        public bool IsLogin => Examinee is not null && Examinee.Uuid is not null;

        public bool IsExaminationTime => DateTime.Now >= Examination.StartTime && DateTime.Now <= Examination.EndTime;

        public bool IsResultTime => DateTime.Now >= Examination.ResultTime;

        public Context(GlobalContext globalContext, NavigationManager navigationManager, IWebHostEnvironment environment)
        {
            this.globalContext = globalContext;
            this.navigationManager = navigationManager;
            this.environment = environment;
        }

        /// <summary>
        /// UUID로 로그인
        /// </summary>
        /// <param name="uuid"></param>
        public void Login(string uuid)
        {
            // UUID에 맞는 수험생 정보를 가져옴
            var examinee = globalContext.ExamineeList.FirstOrDefault(x => x.Uuid == uuid);
            if (examinee == default)
                return;

            if (globalContext.LoginContextMap.ContainsKey(uuid) == true)
                return;
            
            globalContext.LoginContextMap[uuid] = this;

            Examination = globalContext.ExaminationList.FirstOrDefault(x => x.Class == examinee.Class);

            // 답안지를 읽어옴
            LoadAnswerPaper(uuid);

            Examinee = examinee;
        }
        /// <summary>
        /// 로그아웃
        /// </summary>
        public void Logout()
        {
            if (IsLogin == false)
                return;

            // 답안지를 저장함
            SaveAnswerPaper();

            globalContext.LoginContextMap.Remove(Examinee.Uuid, out _);

            Examinee = null;
        }
        /// <summary>
        /// 에러 페이지로 이동
        /// </summary>
        public void GoErrorPage()
        {
            try
            {
                navigationManager.NavigateTo("/error");
            }
            catch { }
        }

        /// <summary>
        /// 답안지 불러옴
        /// </summary>
        public void LoadAnswerPaper(string uuid)
        {
            // UUID에 맞는 수험생 답안지를 가져옴
            var answerPath = Path.Combine(environment.WebRootPath, "answer");
            if (Directory.Exists(answerPath) == false)
                Directory.CreateDirectory(answerPath);

            var answerPaperPath = Path.Combine(answerPath, $"{uuid}.json");
            // 없는 경우 빈 답안지 생성
            if (File.Exists(answerPaperPath) == false)
            {
                AnswerPaper = new();
                foreach (var question in globalContext.Questions)
                    AnswerPaper.AnswerList[question.Id] = new(question.Id);
            }
            // 있는 경우 불러옴
            else
            {
                var answerPaperText = File.ReadAllText(answerPaperPath);
                AnswerPaper = JsonSerializer.Deserialize<AnswerPaper>(answerPaperText);
            }
        }

        /// <summary>
        /// 답안지 저장
        /// </summary>
        public void SaveAnswerPaper()
        {
            if (IsLogin == false)
                return;

            var answerPaperText = JsonSerializer.Serialize(AnswerPaper);
            var answerPath = Path.Combine(environment.WebRootPath, "answer");
            var answerPaperPath = Path.Combine(answerPath, $"{Examinee.Uuid}.json");
            File.WriteAllText(answerPaperPath, answerPaperText);
        }
    }
}
