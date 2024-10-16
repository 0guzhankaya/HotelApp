﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Dto.Dtos.RoomDto
{
    public class RoomUpdateDto
    {
        [Required(ErrorMessage = "Lütfen güncellemek istediğiniz odayı seçiniz!")]
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Lütfen oda numarasını giriniz!")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Lütfen oda görsellerini giriniz!")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen fiyat bilgisi giriniz!")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen oda başlığı bilgisi giriniz!")]
        [StringLength(100, ErrorMessage = "Lütfen en fazla 100 karakter veri girişi gerçekleştiriniz.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayısı bilgisi giriniz!")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen banyo sayısı bilgisi giriniz!")]
        public string BathCount { get; set; }

        public string Wifi { get; set; }

        [Required(ErrorMessage = "Lütfen oda açıklamasını giriniz!")]
        public string Description { get; set; }
    }
}
