# <조교 딩> - 동영상 강의 질의 응답용 챗봇 (QnA maker.ai 기반)

# 사전 요구 사항
- Follow instructions [here](https://docs.microsoft.com/en-us/azure/cognitive-services/qnamaker/how-to/set-up-qnamaker-service-azure) to create a QnA Maker service.
- Follow instructions [here](https://docs.microsoft.com/en-us/azure/cognitive-services/qnamaker/how-to/multiturn-conversation) to create multiturn experience.
- Follow instructions [here](https://docs.microsoft.com/en-us/azure/cognitive-services/qnamaker/quickstarts/create-publish-knowledge-base) to import and publish your newly created QnA Maker service.
- Update [appsettings.json](appsettings.json) with your kbid (KnowledgeBase Id), endpointKey and endpointHost. QnA knowledge base setup and application configuration steps can be found [here](https://aka.ms/qna-instructions).
- (Optional) Follow instructions [here](https://github.com/Microsoft/botbuilder-tools/tree/master/packages/QnAMaker) to set up the
QnA Maker CLI to deploy the model.

- qnamaker.ai 계정 

## 실행 방법

1.직접 챗봇 실행
- Clone the repository

     ```bash
    git clone https://github.com/gywlssww/azure_chatbot_qnabot.git
    ```

- In a terminal, navigate to `experimental/qnamaker-multiturn-bot/csharp_dotnetcore`
- Run the bot from a terminal or from Visual Studio, choose option A or B.

  - Run the bot from Visual Studio:
  2.URL에서 직접 테스트
- https://oschatbot20200711031349.azurewebsites.net

## Testing the bot using Bot Framework Emulator

[Bot Framework Emulator](https://github.com/microsoft/botframework-emulator) is a desktop application that allows bot developers to test and debug their bots on localhost or running remotely through a tunnel.

- Install the Bot Framework Emulator version 4.3.0 or greater from [here](https://github.com/Microsoft/BotFramework-Emulator/releases)

### Connect to the bot using Bot Framework Emulator

- Launch Bot Framework Emulator
- File -> Open Bot
- Enter a Bot URL of `http://localhost:3999/api/messages`

## 동영상 질의 응답 용 봇: 조교 딩의 인사가 담긴 AdaptiveCard 메세지가 출력되면 정상적으로 작동이 시작된 것 (Index.cshtml)

> 로딩에 시간이 오래 걸릴 경우 '하이!' '안녕' 등의 인사 메세지를 입력해보세요!

(1) 강의를 재생하며 생긴 의문점을 질문

(2) 강의록을 기반으로 QnA maker knowledge base 구성 > 답변 구성이 강의 내용을 바탕으로 이루어져 강의 효율을 증가시키는 효과. 강의 관련 질문에 대한 답변만 존재하는 한계.

(3) '졸립다', '피곤하다' 등의 일상 대화 가능

(4) 강의 수강 완료 후 퀴즈 응시 > '퀴즈' 입력 시 복습 퀴즈 화면으로 전환 > 복습 퀴즈용 챗봇 작동
