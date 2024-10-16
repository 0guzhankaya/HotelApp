using System.ComponentModel.DataAnnotations;

namespace Hotel.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Hizmet ikonu seçiniz!")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet başlığı giriniz!")]
        [StringLength(50, ErrorMessage = "Hizmet başlığı 50 karakterden az olmalıdır!")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
