using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Schema;
using Newtonsoft.Json;
using System.IO;

namespace Microsoft.BotBuilderSamples.Bots
{
    public class Cards
    {
        
        const string postback = "교수님";

        public static Attachment CreateAdaptiveCardAttachment()
        {
            // combine path for cross platform support
            var paths = new[] { ".", "Resources", "AdaptiveCard.json" };
            var adaptiveCardJson = File.ReadAllText(Path.Combine(paths));

            var adaptiveCardAttachment = new Attachment()
            {
                ContentType = "application/vnd.microsoft.card.adaptive",
                Content = JsonConvert.DeserializeObject(adaptiveCardJson),
            };

            return adaptiveCardAttachment;
        }

        public static ThumbnailCard GetThumbnailCard()
        {
            
            var thumbnailCard = new ThumbnailCard
            {
                Title = "안녕하세요!\r\n온라인 강의 도우미 챗봇\r\n<조교 딩>입니다!",
                //Subtitle = "강의를 듣다가 모르는 것은 바로 질문하세요!",
                Text = "강의를 듣다가 모르는 것은 바로 질문하세요!"+"강의 수강 후 복습 퀴즈에서 60점 이상 받아야 출석을 인정 받을 수 있습니다.",
                Images = new List<CardImage> { new CardImage("https://github.com/gywlssww/azure_chatbot_quiz/blob/master/teacher.png?raw=true") },
                //추가학습을 위한 위키 검색 페이지
                Buttons = new List<CardAction> { new CardAction(ActionTypes.PostBack, "지난 시간 질문 확인", null,postback, "질문 확인") },
            };

            return thumbnailCard;
        }

        public static ThumbnailCard GetThumbnailCard2(string str,string name)
        {
            var thumbnailCard = new ThumbnailCard
            {
                Title = $"{name} 학생!",
                Text = str,
                Images = new List<CardImage> { new CardImage("https://github.com/gywlssww/azure_chatbot_quiz/blob/master/lesson.png?raw=true") },
                //추가학습을 위한 위키 검색 페이지
            };

            return thumbnailCard;
        }
    }
}
