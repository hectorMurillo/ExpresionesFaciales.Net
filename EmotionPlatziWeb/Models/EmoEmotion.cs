using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmotionPlatziWeb.Models
{
    public class EmoEmotion
    {
        public int Id { get; set; }
        public float Score { get; set; }
        public int EmofaceId { get; set; }
        public virtual EmoEmotionEnum EmotionType{ get; set; }

        public virtual EmoFace Face { get; set; }
    }
}