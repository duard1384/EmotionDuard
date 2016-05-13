using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmotionDuard.Web.Models
{
    public class EmotionDuardWebContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public EmotionDuardWebContext() : base("name=EmotionDuardWebContext")
        {
        }

        public System.Data.Entity.DbSet<EmotionDuard.Web.Models.EmoPicture> EmoPictures { get; set; }

        public System.Data.Entity.DbSet<EmotionDuard.Web.Models.EmoFace> EmoFaces { get; set; }

        public System.Data.Entity.DbSet<EmotionDuard.Web.Models.EmoEmotion> EmoEmotions { get; set; }
    }
}
