using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmotionPlatziWeb.Models
{
    public class Home
    {
        public int Id { get; set; }
        public string WelcomeMsg  { get; set; }
        public string FooterMsg { get; set; } = "Footer by @Héctor Murillo";
    }
}