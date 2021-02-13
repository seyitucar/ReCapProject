﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constant
{
    public static class Messages
    {
        public static string CarAdded = "Araç başarı ile eklendi";
        public static string CarPriceInvalid = "Ekleme başarısız : Araba günlük fiyatı 0 TL üzerinde olmalıdır";
        public static string MaintenanceTime = "Sistem bakımdadır";
        public static string CarListed = "Araçlar listelendi";
        public static string CarDeleted = "Araç başarı ile silindi";
        public static string CarUpdated = "Araç başarı ile güncellendi";
        public static string CarUpdateInvalid = "Güncelleme başarısız : Araba günlük fiyatı 0 TL üzerinde olmalıdır";
        public static string CarDetailDtoMessage = "Araba detayları başarı ile getirildi";
        public static string CarNameInvalid = "Ekleme başarısız : Araba ismi 2 karakterden uzun olmalıdır";
        public static string BrandAdded = "Marka başarı ile eklendi";
        public static string BrandDeleted = "Marka başarı ile silindi";
        public static string BrandUpdated = "Marka başarı ile güncellendi";
        public static string BrandNameInvalid = "Ekleme başarısız : Marka ismi 2 karakterden uzun olmalıdır";
        public static string BrandUpdateInvalid = "Güncelleme başarısız : Marka ismi 2 karakterden uzun olmalıdır";
        public static string ColorAdded = "Renk başarı ile eklendi";
        public static string ColorDeleted = "Renk başarı ile silindi";
        public static string ColorUpdated = "Renk başarı ile güncellendi";

    }
}