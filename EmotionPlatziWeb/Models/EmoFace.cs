using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace EmotionPlatziWeb.Models
{
    public class EmoFace
    {
        public int Id { get; set; }
        public int EmoPictureId { get; set; }

        //Una region me permite identificar como esta seccionado mi codigo
        //No es para uso de codigo, sino para apoyo del programador.
        #region
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        #endregion

        public virtual EmoPicture Picture { get; set; }

        public virtual ObservableCollection<EmoEmotion> Emotions{ get; set; }
    }
}