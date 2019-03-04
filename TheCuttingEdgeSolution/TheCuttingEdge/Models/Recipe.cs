using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheCuttingEdge.Models
{    
    public class Recipe
    {
        [Key]
        public int RecipeId { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Recipe Title")]
        public string RecipeTitle { get; set; }

        [Column(TypeName = "nvarchar(256)")]
        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Recipe Description")]
        public string RecipeDescription { get; set; }

        [Column(TypeName = "Date of Upload")]
        public DateTime RecipeUploadDate { get; set; }

        [Column(TypeName = "nvarchar(256)")]
        [DisplayName("Recipe Uploader")]
        public string RecipeUploader { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Column(TypeName = "nvarchar(256)")]
        public string Ingredient1 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Ingredient2 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Ingredient3 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Ingredient4 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Ingredient5 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Ingredient6 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Ingredient7 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Ingredient8 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Ingredient9 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Ingredient10 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Ingredient11 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Ingredient12 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Ingredient13 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Ingredient14 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Ingredient15 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Ingredient16 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Ingredient17 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Ingredient18 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Ingredient19 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Ingredient20 { get; set; }

        [Column(TypeName = "int")]
        public int StepNumber1 { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Column(TypeName = "nvarchar(256)")]
        public string Step1Description { get; set; }

        [Column(TypeName = "int")]
        public int StepNumber2 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Step2Description { get; set; }

        [Column(TypeName = "int")]
        public int StepNumber3 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Step3Description { get; set; }

        [Column(TypeName = "int")]
        public int StepNumber4 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Step4Description { get; set; }

        [Column(TypeName = "int")]
        public int StepNumber5 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Step5Description { get; set; }

        [Column(TypeName = "int")]
        public int StepNumber6 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Step6Description { get; set; }

        [Column(TypeName = "int")]
        public int StepNumber7 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Step7Description { get; set; }

        [Column(TypeName = "int")]
        public int StepNumber8 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Step8Description { get; set; }

        [Column(TypeName = "int")]
        public int StepNumber9 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Step9Description { get; set; }

        [Column(TypeName = "int")]
        public int StepNumber10 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Step10Description { get; set; }

        [Column(TypeName = "int")]
        public int StepNumber11 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Step11Description { get; set; }

        [Column(TypeName = "int")]
        public int StepNumber12 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Step12Description { get; set; }

        [Column(TypeName = "int")]
        public int StepNumber13 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Step13Description { get; set; }

        [Column(TypeName = "int")]
        public int StepNumber14 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Step14Description { get; set; }

        [Column(TypeName = "int")]
        public int StepNumber15 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Step15Description { get; set; }

        [Column(TypeName = "int")]
        public int StepNumber16 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Step16Description { get; set; }

        [Column(TypeName = "int")]
        public int StepNumber17 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Step17Description { get; set; }

        [Column(TypeName = "int")]
        public int StepNumber18 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Step18Description { get; set; }

        [Column(TypeName = "int")]
        public int StepNumber19 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Step19Description { get; set; }

        [Column(TypeName = "int")]
        public int StepNumber20 { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string Step20Description { get; set; }
    }
}
