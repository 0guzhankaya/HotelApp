using System.ComponentModel.DataAnnotations;

namespace Hotel.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        [Required(ErrorMessage = "Lütfen hizmet seçiniz!")]
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Lütfen hizmet ikonu seçiniz!")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Lütfen hizmet başlığı giriniz!")]
        [StringLength(50, ErrorMessage = "Hizmet başlığı 50 karakterden az olmalıdır!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen hizmet açıklaması giriniz!")]
        [StringLength(500, ErrorMessage = "Hizmet açıklaması 500 karakterden az olmalıdır!")]
        public string Description { get; set; }
    }
}