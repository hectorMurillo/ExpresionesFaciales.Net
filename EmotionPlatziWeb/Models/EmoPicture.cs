using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmotionPlatziWeb.Models
{
    public class EmoPicture
    {
        public int Id { get; set; }
        [Display(Name="Nombre")]
        public string Name { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "La ruta supera el limite de caracteres.")]
        public string Path { get; set; }

        //PROPIEDADES DE NAVEGACION: son prop que estan en el modelo pero no pertenecen a un campo real del modelo
        //Y solo sirven para hacer las navegaciones correspondientes
        public virtual ObservableCollection<EmoFace>Faces{ get; set; }
    }
}