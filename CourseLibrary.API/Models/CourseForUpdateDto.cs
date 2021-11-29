using System.ComponentModel.DataAnnotations;

namespace CourseLibrary.API.Models
{
    public class CourseForUpdateDto
    {
        [Required(ErrorMessage = "You should fill out a title.")]
        [MaxLength(100, ErrorMessage = "The title should't have move than 100 characters. ")]
        public string Title { get; set; }

        [Required(ErrorMessage = "You should fill out a decription.")]
        [MaxLength(1500, ErrorMessage = "The description shoulnd't have more than 1500 characters. ")]
        public string Description { get; set; }
    }
}
