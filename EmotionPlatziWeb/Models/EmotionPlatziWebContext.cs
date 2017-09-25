using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmotionPlatziWeb.Models
{
    public class EmotionPlatziWebContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public EmotionPlatziWebContext() : base("name=EmotionPlatziWebContext")
        {
            //Estas son estrategias para actualizar los modelos, en este caso se le especifica que borre y cree si hay un cambio en los modelos
            //Cuando esta en desarrollo no hay problema de usarla, pero cuando va a producción se recomienda usar otro mas sofisticado como las migraciones
            Database.SetInitializer<EmotionPlatziWebContext>(
                    new DropCreateDatabaseIfModelChanges<EmotionPlatziWebContext>()
                );
        }

        public System.Data.Entity.DbSet<EmoPicture> EmoPictures { get; set; }
        public System.Data.Entity.DbSet<EmoFace> EmoFaces { get; set; }
        public System.Data.Entity.DbSet<EmoEmotion>EmoEmotions {get; set; }

        public System.Data.Entity.DbSet<EmotionPlatziWeb.Models.Home> Homes { get; set; }
    }
}
