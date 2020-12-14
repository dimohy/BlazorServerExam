# BlazorServer - Exam
`Exam`은 Blazor Server를 이용해 반응형 웹 앱을 어떻게 만드는지 예를 들기 위해 만들었습니다. Exam은 BlazorServer 템플릿을 그대로 이용했으며, `안내`, `시험`, `시험결과` 메뉴로 구성되어 있습니다.

`GlobalContext`는 Singleton 서비스로 등록하여 각종 공통 인스턴스 및 접속한 수험생 Context를 유지합니다.
`Context`는 수험생이 유지해야 할 컨텍스트이며, Scoped 서비스로 등록하여 유지합니다.

```CSharp
// Startup.cs
        public void ConfigureServices(IServiceCollection services)
        {
            // ...
            services.AddSingleton<GlobalContext>();
            services.AddScoped<Context>();
        }

```

Singleton 서비스는 웹 어플리케이션의 라이프사이클과 동일합니다. Scoped 서비스는 연결이 유지되는 동안의 라이프사이클을 가집니다. Blazor Server는 SignalR을 통해 상시 연결되어 있으므로 웹브라우저에서 Refresh를 하거나 웹브라우저에서 나가기 전까지 Scoped 서비스는 유지됩니다.

.NET 5에서 컴파일하고 테스트되었으며, 실제로 대학교의 기말고사를 보는데 사용되었습니다. A반, B반 동시접속자 평균 26명이였습니다.

`Intel(R) Core(TM) i7-4710HQ CPU @ 2.50GHz`, `8GiB System Memory` Ubuntu 서버에서 26명이 동시에 접속했을 때 CPU 사용율이 대략 10% 정도를 유지했습니다. 1초마다 시간표시를 위해 `StateHasChanged()` 메소드를 호출했으며, 이로인해서 불필요한 평가 및 RenderTree가 재구성된게 원인이지 않을까 합니다. 자세한 것은 좀 더 분석 후 보완토록 하겠습니다.

## 테스트를 위한 URL 접근 방법
실제 수험생 접근용으로 사용했던 `GlobalContext`의 `ExamineeList` 목록 중 아무 Uuid를 이용해 `https://localhost:xxxx/23D5D90D-9461-4F68-AC43-46FA29213E29` 형태로 접근 후 확인할 수 있습니다.

## 문제풀이 저장
wwwroot/answer에 {UUID}.json 형태로 저장되고 최초 연결 시 읽어서 Context에 정보를 보관합니다.
