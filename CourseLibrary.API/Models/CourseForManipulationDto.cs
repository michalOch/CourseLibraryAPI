using CourseLibrary.API.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace CourseLibrary.API.Models
{
    [CourseTitleMustBeDifferentFromDescriptionAttribute(ErrorMessage = "Title must be different from description.")]
    public abstract class CourseForManipulationDto
    {
        [Required(ErrorMessage = "You should fill out a title.")]
        [MaxLength(100, ErrorMessage = "The title should't have move than 100 characters. ")]
        public string Title { get; set; }

        [Required(ErrorMessage = "You should fill out a decription.")]
        [MaxLength(1500, ErrorMessage = "The description shoulnd't have more than 1500 characters. ")]
        public virtual string Description { get; set; }
    }
}
