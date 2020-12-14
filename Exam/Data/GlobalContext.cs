using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exam.Data
{
    public class GlobalContext
    {
        /// <summary>
        /// 수험일
        /// </summary>
        private static readonly DateTime DDay = new(2020, 12, 14);

        /// <summary>
        /// UUID : Context 형태로 로그인한 수험자 정보를 관리한다.
        /// </summary>
        public ConcurrentDictionary<string, Context> LoginContextMap = new();


        /// <summary>
        /// 시험 기초 정보
        /// 
        /// 시험 시각 시각, 종료 시각, 입장 가능 시간 (시작 시각 +), 발표 시각
        /// </summary>
        public List<Examination> ExaminationList { get; } = new()
        {
            // Class A
            new()
            {
                Class = "A",
                StartTime = new DateTime(DDay.Year, 1, 1),
                EndTime = new DateTime(DDay.Year, 12, 31, 23, 59, 59),
                //StartTime = DDay.Add(new(13, 35, 0)),
                //EndTime = DDay.Add(new(16, 15, 59)),
                EntranceOverTime = TimeSpan.FromMinutes(30),
                ResultTime = new DateTime(DDay.Year, 1, 1)
                //ResultTime = DDay.AddDays(1)
            },
            // Class B
            new()
            {
                Class = "B",
                StartTime = new DateTime(DDay.Year, 1, 1),
                EndTime = new DateTime(DDay.Year, 12, 31, 23, 59, 59),
                //StartTime = DDay.Add(new(9, 55, 0)),
                //EndTime = DDay.Add(new(12, 35, 59)),
                EntranceOverTime = TimeSpan.FromMinutes(30),
                ResultTime = new DateTime(DDay.Year, 1, 1)
                //ResultTime = DDay.AddDays(1)
            },
            // Class S
            new()
            {
                Class = "S",
                StartTime = new DateTime(DDay.Year, 1, 1),
                EndTime = new DateTime(DDay.Year, 12, 31, 23, 59, 59),
                EntranceOverTime = TimeSpan.FromMinutes(30),
                ResultTime = new DateTime(DDay.Year, 1, 1)
            }
        };

        /// <summary>
        /// 수험생 목록
        /// </summary>
        public List<Examinee> ExamineeList { get; } = new()
        {
            // 교수
            new() { Uuid = "6DA61E61-A3AA-4FC8-B796-6C7240CE3AA1", Class = "S", Id = "", Name = "정XX" },
            new() { Uuid = "3D2B07DD-6DF3-4EA1-80C5-A91367324BF2", Class = "S", Id = "", Name = "김XX" },
            new() { Uuid = "5AFB26BC-0D97-4F58-BE16-A055680BC343", Class = "S", Id = "", Name = "최XX" },

            // A반
            new() { Uuid = "2BD8B03A-824E-4772-8349-C26E2ADBDE84", Class = "A", Id = "", Name = "테XX" },

            new() { Uuid = "D6BB97BE-1FBF-4771-BADF-298ED3F403D5", Class = "A", Id = "", Name = "강XX" },
            new() { Uuid = "66C9CAC4-5A51-4595-87EA-D85CF602DAF6", Class = "A", Id = "", Name = "김XX" },
            new() { Uuid = "615BF8FA-9B83-45A6-97C1-A740862921F7", Class = "A", Id = "", Name = "김XX" },
            new() { Uuid = "703F875B-ADB4-47DA-A555-37CF8F418788", Class = "A", Id = "", Name = "김XX" },
            new() { Uuid = "EBC1234F-D730-480F-BB26-2CE341729139", Class = "A", Id = "", Name = "김XX" },
            new() { Uuid = "1F061D12-4401-4D0D-A022-82CB2E61C610", Class = "A", Id = "", Name = "라XX" },
            new() { Uuid = "86AF2171-2AEC-41B6-82C9-AB837FE2C832", Class = "A", Id = "", Name = "박XX" },
            new() { Uuid = "5C12A87B-66B2-44D1-BB96-C9ED04299C13", Class = "A", Id = "", Name = "박XX" },
            new() { Uuid = "4A384709-02F7-40E8-A8C3-5742E0455074", Class = "A", Id = "", Name = "박XX" },
            new() { Uuid = "59D112D4-BACE-4313-B07A-620B822E7C45", Class = "A", Id = "", Name = "배XX" },
            new() { Uuid = "FBFEF19D-EB4E-4F5E-B8EA-68F624837AD6", Class = "A", Id = "", Name = "서XX" },
            new() { Uuid = "23D5D90D-9461-4F68-AC43-46FA29213E27", Class = "A", Id = "", Name = "엄XX" },
            new() { Uuid = "9FA06AC6-67FB-46D9-995C-925D57F17F18", Class = "A", Id = "", Name = "윤XX" },
            new() { Uuid = "86625583-0B84-487C-9BCF-E91CAC3F4F99", Class = "A", Id = "", Name = "이XX" },
            new() { Uuid = "D9685CC1-9B1A-4229-83E9-BAD2AEC1C4D0", Class = "A", Id = "", Name = "이XX" },
            new() { Uuid = "B5AF7A7F-0AE6-4D5E-9BDA-2EE903AB35D1", Class = "A", Id = "", Name = "이XX" },
            new() { Uuid = "53CD83D8-8C74-4BDA-BBAB-A5E5909B0FA2", Class = "A", Id = "", Name = "이XX" },
            new() { Uuid = "28723227-4298-4227-912C-A5F2D9E26783", Class = "A", Id = "", Name = "이XX" },
            new() { Uuid = "A58FAC1D-1B71-4F3B-82E5-B84CC153B374", Class = "A", Id = "", Name = "장XX" },
            new() { Uuid = "206524F8-23E2-4C2C-9482-1B548BFA0C75", Class = "A", Id = "", Name = "장XX" },
            new() { Uuid = "8AC836AF-124F-4F57-A60A-10900C477156", Class = "A", Id = "", Name = "전XX" },
            new() { Uuid = "EAF888F2-12C5-4CB5-B7FB-BB93A117F137", Class = "A", Id = "", Name = "정XX" },
            new() { Uuid = "795097B2-7B78-4438-AAC0-70E42B6AF4C8", Class = "A", Id = "", Name = "정XX" },
            new() { Uuid = "ECBEC828-E8F9-4B99-A300-AC7C4E7ADEC9", Class = "A", Id = "", Name = "주XX" },
            new() { Uuid = "88B86E6A-5BDC-4A42-9968-89E5D6704EA0", Class = "A", Id = "", Name = "최XX" },
            new() { Uuid = "FA7BBBA2-20EC-42BF-9CF9-718CDED20391", Class = "A", Id = "", Name = "추XX" },
            new() { Uuid = "9CF82B19-BF07-4501-AC0C-020D6E63ED52", Class = "A", Id = "", Name = "한XX" },
            new() { Uuid = "99437BA6-473D-4986-BCCE-3E2DED442884", Class = "A", Id = "", Name = "한XX" },
            new() { Uuid = "93DAC108-70BF-4A85-BE5C-9B4016831D05", Class = "A", Id = "", Name = "황XX" },

            // B반
            new() { Uuid = "F698F935-35C0-4CAC-9845-91B931CE2B26", Class = "B", Id = "", Name = "테XX" },

            new() { Uuid = "F5E4D600-8C29-4905-B617-CB5B33CB1747", Class = "B", Id = "", Name = "고XX" },
            new() { Uuid = "8151AC01-CC2F-40CA-A894-DB136A21F878", Class = "B", Id = "", Name = "권XX" },
            new() { Uuid = "77128487-6070-4D01-A225-9F1C1529FB89", Class = "B", Id = "", Name = "김XX" },
            new() { Uuid = "7F473927-2898-4887-B0C1-34B3349CE0D1", Class = "B", Id = "", Name = "김XX" },
            new() { Uuid = "4CD08FA5-80BF-4A2F-9D74-E4004E5DCB72", Class = "B", Id = "", Name = "김XX" },
            new() { Uuid = "3B1D9C28-95B3-42FB-9D67-7F51163F9B83", Class = "B", Id = "", Name = "김XX" },
            new() { Uuid = "81F507D1-D3DB-47A9-B1EE-AE24A96D38E4", Class = "B", Id = "", Name = "김XX" },
            new() { Uuid = "FDFC0DC5-745C-44E1-BE12-BD46B2683A25", Class = "B", Id = "", Name = "김XX" },
            new() { Uuid = "08BAEBE9-C660-4297-AAE2-C53F77D346C6", Class = "B", Id = "", Name = "김XX" },
            new() { Uuid = "2CF6E8EC-E144-450F-BDD9-E83583732E07", Class = "B", Id = "", Name = "김XX" },
            new() { Uuid = "0AACBE07-B78A-4533-BCF7-0ADB0637D0A8", Class = "B", Id = "", Name = "김XX" },
            new() { Uuid = "F414CE35-3EE8-455C-BE42-CE5F9E5414D9", Class = "B", Id = "", Name = "서XX" },
            new() { Uuid = "AB91CB8B-A333-4390-8FCA-B338B6D1F330", Class = "B", Id = "", Name = "송XX" },
            new() { Uuid = "AC978EFC-D022-418F-9AA9-7C4AD37A7C91", Class = "B", Id = "", Name = "신XX" },
            new() { Uuid = "F1F5EC6C-FC1B-432A-A38A-5C73BA964322", Class = "B", Id = "", Name = "양XX" },
            new() { Uuid = "C6C6AF35-8813-4B8A-9DE5-FB4B1B0CCB43", Class = "B", Id = "", Name = "오XX" },
            new() { Uuid = "E95EC642-38A6-443F-80E6-07E5A2980714", Class = "B", Id = "", Name = "유XX" },
            new() { Uuid = "F25D8B41-B096-45A0-BE9D-C86EC5676065", Class = "B", Id = "", Name = "윤XX" },
            new() { Uuid = "A8263596-889A-40B1-B443-2D4897F25186", Class = "B", Id = "", Name = "이XX" },
            new() { Uuid = "48E43EA9-BD32-4FA4-BEE8-28B430B642C7", Class = "B", Id = "", Name = "이XX" },
            new() { Uuid = "442075E4-3FCF-45D3-BACE-EDFA34E41688", Class = "B", Id = "", Name = "이XX" },
            new() { Uuid = "05266C9D-3F5C-47D6-BDE8-92BE55FB0BF9", Class = "B", Id = "", Name = "이XX" },
            new() { Uuid = "74C70A1D-FA58-4476-8E35-86D73C2DC880", Class = "B", Id = "", Name = "이XX" },
            new() { Uuid = "FC4C97CC-4B15-40F5-BC83-B5C7E36E96E1", Class = "B", Id = "", Name = "장XX" },
            new() { Uuid = "41AE9A0A-3A08-4DA7-83CE-2AD2416C5312", Class = "B", Id = "", Name = "최XX" },
            new() { Uuid = "246E5714-21B5-4DBF-93B5-811C93EEB083", Class = "B", Id = "", Name = "최XX" },
            new() { Uuid = "01DD8877-6F1C-4CA1-8C63-7405B93032B4", Class = "B", Id = "", Name = "환XX" },
            new() { Uuid = "886D15FD-02F8-4BCC-9BB7-EF48240F7D55", Class = "B", Id = "", Name = "홍XX" },
        };

        /// <summary>
        /// 문제 목록
        /// </summary>
        public List<Question> Questions { get; } = new()
        {
            // Question 1
            new() {
                Id = 1,
                Content = "데이터베이스의 특징으로 옳지 않은 것은?",
                Items = new()
                {
                    new(1, "통합된 데이터", false),
                    new(2, "관련 있는 데이터", false),
                    new(3, "동시 접근, 무결성", false),
                    new(4, "중복된 데이터", true)
                }
            },
            // Question 2
            new()
            {
                Id = 2,
                Content = "출신학교 코드가 입력되어야 할 필드에 고객 주소가 입력되었다면 데이터베이스가 가지고 있어야 할 기능 중 어느 것을 위반한 것인가?",
                Items = new()
                {
                    new(1, "데이터의 유지", false),
                    new(2, "데이터의 장애 회복", false),
                    new(3, "데이터의 중복", false),
                    new(4, "데이터의 무결성", true)
                }
            },
            // Question 3
            new()
            {
                Id = 3,
                Content = "관계의 특징으로 옳지 않은 것은?",
                Items = new()
                {
                    new(1, "한 관계에서 속성이름은 유일해야 한다.", false),
                    new(2, "튜플 내의 모든 값은 원자값이어야 한다.", false),
                    new(3, "튜플과 속성의 순서는 입력 순이다.", true),
                    new(4, "한 관계에서 두 튜플의 속성값이 모두 같은 것은 허락하지 않는다.", false)
                }
            },
            // Question 4
            new()
            {
                Id = 4,
                Content = "SQL 서버에 대한 설명으로 옳지 않은 것은?",
                Items = new()
                {
                    new(1, "SQL 서버는 인텔 기반의 서버용 컴퓨터에서 널리 사용되는 DBMS이다.", false),
                    new(2, "SQL 서버는 엔터프라이즈가 필요로 하는 확장성과 안정성을 제공하는 데이터베이스 제품이다.", false),
                    new(3, "SQL 서버는 오라클사에서 개발하여 UNIX 시스템에서 가장 적합한 범용적인 DBMS이다.", true),
                    new(4, "SQL 서버는 원래 사이베이스사의 DBVMS 엔진을 NT에 탑재하면서 개발된 DBMS이다.", false)
                }
            },
            // Question 5
            new()
            {
                Id = 5,
                Content = "키(key)에 관한 설명으로 옳지 않은 것은?",
                Items = new()
                {
                    new(1, "키: 관계에서 튜플들을 유일하게 구별할 수 있는 하나 이상의 속성의 집합", false),
                    new(2, "후보키: 유일성과 최소성을 만족하는 키로, 한 관계에 여러 개일 수 있다.", false),
                    new(3, "주키: 식별자로 가장 적합하여 선정된 키", false),
                    new(4, "외래키: 여러 개의 후보키가 모여 복합적으로 사용되는 키", true)
                }
            },
            // Question 6
            new()
            {
                Id = 6,
                Content = "데이터베이스에 대한 설명으로 옳지 않은 것은?",
                Items = new()
                {
                    new(1, "특정한 종류의 데이터를 저장하기 위한 영역을 필드라 한다.", false),
                    new(2, "필드에는 실제 자료값이 저장되며 이러한 필드가 여러 개 모이면 하나의 레코드가 된다.", false),
                    new(3, "레코드가 여러 개 모이면 하나의 데이터베이스가 된다.", true),
                    new(4, "파일을 여러 개 모아 저장된 파일들을 논리적으로 연결하여 서로 관련있는 데이터들로 통합한 파일의 집합이 데이터베이스이다.", false)
                }
            },
            // Question 7
            new()
            {
                Id = 7,
                Content = "레코드 생성과 관련된 관계 연산은?",
                Items = new()
                {
                    new(1, "INSERT", true),
                    new(2, "DELETE", false),
                    new(3, "MERGE", false),
                    new(4, "SELECT", false)
                }
            },
            // Question 8
            new()
            {
                Id = 8,
                Content = "현재 가장 널리 이용되는 데이터베이스 모델은 무엇인가?",
                Items = new()
                {
                    new(1, "계층 모델", false),
                    new(2, "네트워크 모델", false),
                    new(3, "관계형 모델", true),
                    new(4, "객체지향 모델", false)
                }
            },
            // Question 9
            new()
            {
                Id = 9,
                Content = "OSI 모델의 계층에 대한 설명으로 옳지 않은 것은?",
                Items = new()
                {
                    new(1, "물리계층: 기계적이고 물리적인 사양이 결정된다.", false),
                    new(2, "네트워크 계층: 발신지와 목적지 간의 패킷이 전송되는 경로를 책임진다.", false),
                    new(3, "세션계층: 메시지가 발신지에서 목적지까지 실제 전송되는 것을 책임진다.", true),
                    new(4, "표현계층: 정보의 표현 방식을 관리하고 암호화하거나 데이터를 압축하는 역할을 한다.", false)
                }
            },
            // Question 10
            new()
            {
                Id = 10,
                Content = "네트워크 분류에 대한 설명으로 옳지 않은 것은?",
                Items = new()
                {
                    new(1, "LAN은 비교적 근거리에 설치되어 있는 컴퓨터, 프린터, 기타 네트워크 장비들을 연결하여 구성한 네트워크다.", false),
                    new(2, "MAN은 LAN보다 좀 더 넓은 범위의 네트워크여서 통신사업자가 이를 제공하고 관리한다.", false),
                    new(3, "WAN은 아주 넓은 범위의 네트워크이다. 하나의 국가와 국가 간을 연결한다. 대표적인 WAN은 인터넷이다.", false),
                    new(4, "MAN의 표준으로 이더넷, 고속 이더넷, 기가비트 이더넷, FDDI가 있다.", true)
                }
            },
            // Question 11
            new()
            {
                Id = 11,
                Content = @"빈칸에 들어갈 말로 가장 적절한 것은?
> ________ (은)는 지구 전역에서 서로 다른 기종의 컴퓨터들이 통일된 프로토콜을 사용해 자유롭게 통신을 주고 받을 수 있는 세계 최대의 통신망을 말한다. ________ (은)는 1969년 미국 국방부에서 시작된 알파넷이 모체로서 인터넷은 네트워크를 서로 접속하는 기술과 그 기술에 의해 접속된 네트워크를 가리킨다.",
                Items = new()
                {
                    new(1, "유즈넷", false),
                    new(2, "텔넷", false),
                    new(3, "인터넷", true),
                    new(4, "WWW", false)
                }
            },
            // Question 12
            new()
            {
                Id = 12,
                Content = "원어의 연결이 옳지 않은 것은?",
                Items = new()
                {
                    new(1, "WWW: World Wide Web", false),
                    new(2, "HTTP: Hyper Text Transfer Protocol", false),
                    new(3, "SMTP: Simple Mail Transfer Protocol", false),
                    new(4, "FTP: Folder Transfer Protocol", true)
                }
            },
            // Question 13
            new()
            {
                Id = 13,
                Content = "OSI 7계층을 TCP.IP 계층에 대응(OSI 7계층: TCP/IP 계층구조) 시킨 것이다. 옳지 않은 것은?",
                Items = new()
                {
                    new(1, "표현계층: 응용계층", false),
                    new(2, "세션계층: 네트워크계층", true),
                    new(3, "전송계층: 전송계층", false),
                    new(4, "응용계층: 응용계층", false)
                }
            },
            // Question 14
            new()
            {
                Id = 14,
                Content = "도메인에 대한 설명으로 옳지 않은 것은?",
                Items = new()
                {
                    new(1, "DNS는 도메인 이름 시스템(Domain Name System) 또는 도메인 이름 서비스(Domain Name Service)의 약자이다.", false),
                    new(2, "도메인 이름 시스템은 도메인 이름이ㅡ 체계 또는 도메인 이름을 실제의 IP의 주소로 바꾸는 시스템을 말한다.", false),
                    new(3, "도메인 이름 서비스는 도메인 이름을 실제의 IP 주소로 바꾸는 서비스를 말한다. 인터넷에 도메인 이름을 사용하더라도 실제로는 모두 IP의 주소로 바꾸어 그 컴퓨터를 연결한다.", false),
                    new(4, "컴퓨터(호스트)에 할당된 도메인 이름을 IP 주소로 변환시키는 역학을 수행하는 컴퓨터(호스트)를 웹 서버라고 한다.", true)
                }
            },
            // Question 15
            new()
            {
                Id = 15,
                Content = "일반적으로 숫자로 된 IP 주소를 기억하기 어렵고 사용하기도 불편하기 때문에 그에 대응하는 단어로 된 주소를 선호한다. 이를 무엇이라 하는가?",
                Items = new()
                {
                    new(1, "도메인 이름(Domain Name)", true),
                    new(2, "IPng", false),
                    new(3, "최사위 도메인", false),
                    new(4, "IPv6", false)
                }
            },
            // Question 16
            new()
            {
                Id = 16,
                Content = @"빈칸에 들어갈 말로 알맞은 것은?
> 전자메일은 인터넷을 이용하는 가장 활성화된 응용 프로그램 중의 하나이다. 전자메일은 문자 중심의 메시지에 첨부하여 여러 멀티미디어 파일의 전송이 가능한 기능으로 ________ (이)라는 통신 규약을 사용한다.",
                Items = new()
                {
                    new(1, "SMTP", true),
                    new(2, "FTP", false),
                    new(3, "Telnet", false),
                    new(4, "Usenet", false)
                }
            },
            // Question 17
            new()
            {
                Id = 17,
                Content = "산업혁명에 대한 설명으로 옳지 않은 것은?",
                Items = new()
                {
                    new(1, "제1차 산업혁명은 증기기관의 기계화 혁명이다.", false),
                    new(2, "제조업 공장의 생산조립 라인인 컨베이어 벨트(conveyor belt)에 의해 대량 생산이 되면서 제2차 산업혁명시대가 오게 된다.", false),
                    new(3, "내연기관의 개발이 가져온 디지털 혁명과 정보화 혁명이 일어난 시기를 제3차 산업혁명이라 한다.", true),
                    new(4, "제4차 산업혁명시대는 개인을 인터넷에 연결한 스마트기기 기술과 모든 사물을 인터넷에 연결할 사물인터넷 IoT 기술의 발달로 가능하다.", false)
                }
            },
            // Question 18
            new()
            {
                Id = 18,
                Content = "사물이 연결되어 정보가 생성, 수집되고 다시 재가공, 공유, 활용되는 사회는?",
                Items = new()
                {
                    new(1, "기계화 사회", false),
                    new(2, "초현실 사회", false),
                    new(3, "익명 사회", false),
                    new(4, "초연결 사회", true)
                }
            },
            // Question 19
            new()
            {
                Id = 19,
                Content = "산업혁명의 주요 키워드로 옳지 않은 것은?",
                Items = new()
                {
                    new(1, "1차 산업혁명: 증기기관", false),
                    new(2, "2차 산업혁명: 내연기관", false),
                    new(3, "3차 산업혁명: 초지능", true),
                    new(4, "4차 산업혁명: 빅데이터", false)
                }
            },
            // Question 20
            new()
            {
                Id = 20,
                Content = "블록체인의 특징이나 설명이 아닌 것은?",
                Items = new()
                {
                    new(1, "중앙화", true),
                    new(2, "분산화", false),
                    new(3, "거래정보 묶음", false),
                    new(4, "디지털 장부", false)
                }
            },
            // Question 21
            new()
            {
                Id = 21,
                Content = "제4차 산업혁명에 대한 설명으로 옳지 않은 것은?",
                Items = new()
                {
                    new(1, "제4차 산업혁명은 독일의 정책인 인더스트리 4.0의 스마트팩토리에 배경을 두고 있다.", false),
                    new(2, "개인용 컴퓨터의 개발과 발전, 반도체의 개발 등 전자산업의 발달, 인터넷의 연결된 컴퓨터와 정보의 바다인 웹의 대중화, 그리고 정보와 통신기술의 발달로 가져온 디지털 혁명과 정보화 혁명이 일어난 시기이다.", true),
                    new(3, "제4차 산업혁명시대는 개인을 인터넷에 연결한 스마트기기 기술과 모든 사물을 인터넷에 연결할 사물인터넷 IoT 기술의 발달로 가능하다.", false),
                    new(4, "제4차 산업혁명이란 모든 사물이 연결된 초연결 사회에서 생산되는 빅데이터를 기존 산업에 융합하여 인공지능, 클라우드 등의 첨단 기술로 처리하는 정보/지능화 혁명 시대이다.", false)
                }
            },
            // Question 22
            new()
            {
                Id = 22,
                Content = "딥러닝에서 유용한 하드웨어는?",
                Items = new()
                {
                    new(1, "GPU, TPU", true),
                    new(2, "CPU, SSD", false),
                    new(3, "USB, RIDAR", false),
                    new(4, "SSD, CMM", false)
                }
            },
            // Question 23
            new()
            {
                Id = 23,
                Content = "머신러닝에 대한 설명으로 옳지 않은 것은?",
                Items = new()
                {
                    new(1, "머신러닝은 지도학습과 분석학습, 그리고 강화학습으로 나뉜다.", true),
                    new(2, "머신러닝은 주어진 데이터를 기반으로 기계가 스스로 학습하여 성능을 향상시키거나 최적의 해답을 찾기 위한 학습 지능 방법이다.", false),
                    new(3, "머신러닝은 명시적으로 프로그래밍을 하지 않아도 컴퓨터가 학습을 할 수 있도록 해주는 인공지능의 한 형태이다.", false),
                    new(4, "강화학습(reinforcement learning)은 잘한 행동에 대해 보상을 주고 잘못한 행동에 대해 벌을 주는 경험을 통해 지식을 학습하는 방법이다.", false)
                }
            },
            // Question 24
            new()
            {
                Id = 24,
                Content = "인간의 신경세포인 뉴런(neuron)을 모방하여 만든 가상의 신경으로 뇌와 유사한 방식으로 입력되는 정보를 학습하고 판별하는 신경 모델은?",
                Items = new()
                {
                    new(1, "뉴런", false),
                    new(2, "인공신경망", true),
                    new(3, "GPU", false),
                    new(4, "RIDAR", false)
                }
            },
            // Question 25
            new()
            {
                Id = 25,
                Content = @"빈칸에 들어갈 말로 가장 알맞은 것은?
> 2007년 1월, 샌프란시스코 맥월드 엑스포에서 발표된 애플의 ________은(는) 우리의 모습을 변화시킨 혁신적인 제품으로, 우리가 살고 있는 21세기 시대를 모바일 시대로 바꾸었다.",
                Items = new()
                {
                    new(1, "아이팟", false),
                    new(2, "갤럭시 S", false),
                    new(3, "아이폰", true),
                    new(4, "아이패드", false)
                }
            },
            // Question 26
            new()
            {
                Id = 26,
                Content = "패드 형태의 태블릿 컴퓨터와 화면이 작은 스마트폰의 중간이라는 의미로 패블릿(pablet = phone + tablet)이라는 신종어를 낳은 스마트폰은 무엇인가?",
                Items = new()
                {
                    new(1, "아이패드", false),
                    new(2, "아이폰", false),
                    new(3, "갤럭시 S", false),
                    new(4, "갤럭시 노트", true)
                }
            },
            // Question 27
            new()
            {
                Id = 27,
                Content = @"다음 빈 칸에 들어갈 말로 가장 알맞은 것은?
> 안드로이드(Android)는 ________과(와) 오픈 헨드셋 얼라이언스(OHA : Open Handset Alliance)에서 만든 모바일 기기를 위한 운영체제이다.",
                Items = new()
                {
                    new(1, "노키아", false),
                    new(2, "구글", true),
                    new(3, "MS", false),
                    new(4, "삼성", false)
                }
            },
            // Question 28
            new()
            {
                Id = 28,
                Content = @"다음 빈칸에 들어갈 말로 가장 알맞은 것은?
> 안드로이드는 ________ 커널을 기반으로 만들어졌으며, 내부 구조를 살펴보면 응용 프로그램, 응용 프로그램 프레임워크, 라이브러리, 안드로이드 런타임, ________ 커널의 5개 레이어로 구성되어 있다.",
                Items = new()
                {
                    new(1, "유닉스", false),
                    new(2, "리눅스", true),
                    new(3, "윈도우", false),
                    new(4, "iOS", false)
                }
            },
            // Question 29
            new()
            {
                Id = 29,
                Content = @"빈칸에 들어갈 말로 가장 알맞은 것은?
> ________(이)가 다른 모바일 운영체제와 차별화되는 가장 큰 특징은 초기화면에서 간결하고 확장성이 있는 타일 스타일의 UI(User Interface)인 라이브 타일(Live Tile)의 활용이라 할 수 있다.",
                Items = new()
                {
                    new(1, "안드로이드", false),
                    new(2, "타이젠", false),
                    new(3, "윈도우 폰", true),
                    new(4, "iOS", false)
                }
            },
            // Question 30
            new()
            {
                Id = 30,
                Content = "다음 중 성격이 다른 것은 무엇인가?",
                Items = new()
                {
                    new(1, "왓츠앱", false),
                    new(2, "라인", false),
                    new(3, "카카오톡", false),
                    new(4, "SMS", true)
                }
            },
            // Question 31
            new()
            {
                Id = 31,
                Content = "원래 자바가 제시한 보안규정으로 외부 프로그램은 보호된 영역에서 동작하도록 하며, 자유로운 시스템 자원 참조를 제한하고, 시스템이 부정하게 조작되는 것을 막는 보안 형태는 무엇인가?",
                Items = new()
                {
                    new(1, "샌드박스", true),
                    new(2, "탈옥", false),
                    new(3, "크랙", false),
                    new(4, "타이젠", false)
                }
            },
            // Question 32
            new()
            {
                Id = 32,
                Content = "구글 안드로이드의 가상 기계는 무엇인가?",
                Items = new()
                {
                    new(1, "닷넷 가상 기계", false),
                    new(2, "코틀린 가상 기계", false),
                    new(3, "자바 가상 기계", false),
                    new(4, "달빅 가상 기계", true)
                }
            },
            // Question 33
            new()
            {
                Id = 33,
                Content = "그래픽 도안에 적당하지 않은 파일 형식은?",
                Items = new()
                {
                    new(1, "JPG", true),
                    new(2, "TIF", false),
                    new(3, "PNG", false),
                    new(4, "GIF", false)
                }
            },
            // Question 34
            new()
            {
                Id = 34,
                Content = "JPEG과 관련이 없는 것은?",
                Items = new()
                {
                    new(1, "무손실 압축", false),
                    new(2, "반복길이코딩", true),
                    new(3, "이산 코사인 변환", false),
                    new(4, "혼합압축", false)
                }
            },
            // Question 35
            new()
            {
                Id = 35,
                Content = "파일 형식에서 나머지 3개와 다른 것은?",
                Items = new()
                {
                    new(1, "WMV", false),
                    new(2, "MOV", false),
                    new(3, "JPG", true),
                    new(4, "MPG", false)
                }
            },
            // Question 36
            new()
            {
                Id = 36,
                Content = "이산 코사인 변환에 대한 설명으로 옳지 않은 것은?",
                Items = new()
                {
                    new(1, "이산 코사인 변환의 입력은 실수데이터이며 출력은 진폭과 위상이다.", true),
                    new(2, "이산 코사인 변환은 JPEG에서 사용된다.", false),
                    new(3, "이산 코사인 변환은 MPEG에서 사용된다.", false),
                    new(4, "이산 코사인 변환을 실수데이터에 수행하면 데이터가 특정한 부분에만 값이 크게 나타나는 경향이 있다.", false)
                }
            },
            // Question 37
            new()
            {
                Id = 37,
                Content = "멀티미디어에 대한 설명으로 옳지 않은 것은?",
                Items = new()
                {
                    new(1, "멀티미디어는 소형화/고성능화하고 있다.", false),
                    new(2, "대량으로 많은 수요자에게 정보를 단방향으로 전달한다.", true),
                    new(3, "반도체의 집적도가 증가함에 따라 소형화된 기기들이 출현하였다.", false),
                    new(4, "마우스를 사용하여 멀티미디어를 제어하는 방식도 존재한다.", false)
                }
            },
            // Question 38
            new()
            {
                Id = 38,
                Content = "전 세계의 가능한 모든 문자를 표현하고자 마련한 코드는?",
                Items = new()
                {
                    new(1, "ASCII", false),
                    new(2, "Extended ASCII", false),
                    new(3, "KSC", false),
                    new(4, "유니코드", true)
                }
            },
            // Question 39
            new()
            {
                Id = 39,
                Content = "정보보안을 위협하는 예의 설명으로 옳지 않은 것은?",
                Items = new()
                {
                    new(1, "차단: 정보를 전송하지 못하도록 하는 행위", false),
                    new(2, "가로채기: 정보 전송 중간에서 정보를 빼내는 행위", false),
                    new(3, "변조: 정보를 송신한 사람이 송신 사실을 부정하는 행위", true),
                    new(4, "위조: 발신자 모르게 정보를 수신자에게 전송하는 행위", false)
                }
            },
            // Question 40
            new()
            {
                Id = 40,
                Content = @"다음 빈칸에 들어갈 알맞은 용어는 무엇인가?
> 정보보안을 위협하는 여러 부작용이 발생하는 장소는 크게 컴퓨터 자체와 컴퓨터와 컴퓨터를 연결하는 네트워크 사이라 할 수 있다. 그러므로 정보보안도 크게 ________ 보안과 ________ 보안으로 나눌 수 있다.",
                Items = new()
                {
                    new(1, "송신자, 수신자", false),
                    new(2, "비밀성, 무결성", false),
                    new(3, "대칭성, 비대칭성", false),
                    new(4, "컴퓨터, 네트워크", true)
                }
            },
            // Question 41
            new()
            {
                Id = 41,
                Content = @"다음 빈칸에 들어갈 알맞은 용어는 무엇인가?
> ________ (이)란 비인가 된 자에 의한 정보의 변경, 삭제, 생성 들으로부터 보호하여 정보의 정확성, 완전성이 보장되어야 한다는 원칙이다. ________ (을)를 보장하기 위한 정책에는 정보 변경에 대한 통제 뿐만 아니라 오류나 태만 등으로부터의 예방도 포함되어야 한다.",
                Items = new()
                {
                    new(1, "가용성", false),
                    new(2, "비밀성", false),
                    new(3, "무결성", true),
                    new(4, "부인방지", false)
                }
            },
            // Question 42
            new()
            {
                Id = 42,
                Content = "컴퓨터 바이러스 예방법에 대한 설명으로 옳지 않은 것은?",
                Items = new()
                {
                    new(1, "컴퓨터의 보안 업데이트가 자동으로 실행될 수 있도록 설정한다.", false),
                    new(2, "백신 프로그램 또는 개인 방화벽 등 보안 프로그램을 설치 운영한다.", false),
                    new(3, "가격이 비싼 소프트웨어는 가급적이면 복사하여 이용한다.", true),
                    new(4, "쉐어웨어나 공개 프로그램을 사용할 경우 컴퓨터를 잘 아는 사람이 오랫동안 잘 사용하고 있는 것을 복사하여 사용한다.", false)
                }
            },
            // Question 43
            new()
            {
                Id = 43,
                Content = "다음 중 컴퓨터 바이러스에 대한 설명으로 옳지 않은 것은?",
                Items = new()
                {
                    new(1, "컴퓨터 바이러스는 디스켓, 네트워크 공유 등을 통해 전파되거나 전자메일, 다운로드 또는 메신저 프로그램 등을 통해 감염된다.", false),
                    new(2, "컴퓨터 바이러스는 자기 복사 능력 이외에도 실제의 바이러스와 비슷하게 부작용을 가지고 있는 경우가 많다.", false),
                    new(3, "컴퓨터가 바이러스에 감염되면 컴퓨터는 여러 오작동을 할 수 있다.", false),
                    new(4, "컴퓨터 바이러스는 감염 없이 자생적으로 스스로 만들어질 수 있다.", true)
                }
            },
            // Question 44
            new()
            {
                Id = 44,
                Content = "암호화에 대한 설명으로 옳지 않은 것은?",
                Items = new()
                {
                    new(1, "공개키는 모두에게 알려져 있는 키다.", false),
                    new(2, "디지털 서명에서 송신자는 공개키를 이용하여 메시지를 암호화한다.", true),
                    new(3, "비밀키 암호화 방법에서는 정보를 보내는 사람과 받는 사람이 같은 키를 가지고 있다.", false),
                    new(4, "DES 알고리즘은 비밀키 암호화 알고리즘 중 가장 널리 사용되고 있는 알고리즘이다.", false)
                }
            },
            // Question 45
            new()
            {
                Id = 45,
                Content = "암호화의 반대로, 암호문에서 평문으로 변환하는 것을 무엇이라 하는가?",
                Items = new()
                {
                    new(1, "대칭화", false),
                    new(2, "복호화", true),
                    new(3, "공개키", false),
                    new(4, "비밀키", false)
                }
            },
            // Question 46
            new()
            {
                Id = 46,
                Content = "다음 중 만든 공개키 암호 방식의 암호화 기법으로 만든 암호 알고리즘은 무엇인가?",
                Items = new()
                {
                    new(1, "RSA", true),
                    new(2, "CA", false),
                    new(3, "DES", false),
                    new(4, "PGP", false)
                }
            },
            // Question 47
            new()
            {
                Id = 47,
                Content = "전자메일 보안 기법으로 짝지어진 것은?",
                Items = new()
                {
                    new(1, "DES, RSA", false),
                    new(2, "PGP, S/MIME", true),
                    new(3, "SSL, S-HTTP", false),
                    new(4, "패킷 필터링, 응용 게이트웨이", false)
                }
            },
            // Question 48
            new()
            {
                Id = 48,
                Content = "정보보안 서비스에 해당하지 않는 것은?",
                Items = new()
                {
                    new(1, "부인방지", false),
                    new(2, "접근제어", false),
                    new(3, "인증", false),
                    new(4, "위조", true)
                }
            },
            // Question 49
            new()
            {
                Id = 49,
                Content = "웹 보안 기법으로 짝지어진 것은?",
                Items = new()
                {
                    new(1, "DES, RSA", false),
                    new(2, "PGP, S/MIME", false),
                    new(3, "SSL, S-HTTP", true),
                    new(4, "패킷 필터링, 응용 게이트웨이", false)
                }
            },
            // Question 50
            new()
            {
                Id = 50,
                Content = "외부 네트워크에 연결된 LAN 등의 내부 네트워크를 외부의 불법적인 사용자의 침입으로부터 안전하게 보호하기 위한 정책 및 이를 지원하는 하드웨어 및 소프트웨어를 총칭하는 것은 무엇인가?",
                Items = new()
                {
                    new(1, "웹보안", false),
                    new(2, "방화벽", true),
                    new(3, "게이트웨이", false),
                    new(4, "라우터", false)
                }
            },
        };
    }
}
