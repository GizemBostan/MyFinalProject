using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constans
{
    //static olması new leme gerektirmez
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "ürün ismi geçersiz";
        public static string MaintenanceTime="sistem bakımda";
        public static string ProductLİsted="ürünler listelendi";
        public static string ProductCountOfCategoryError = "bir categoriye en fazla 10 ürün eklenebilir";
        public static string ProductNameAlreadyExists="bu isim daha önce kullanıldı";
        public static string CategoryLimitedExceded="kategori limiti aşıldığı için yeni ürün eklenemez";
    }
}
