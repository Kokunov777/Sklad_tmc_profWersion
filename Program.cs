using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemSklad
{
    //sklad
    public class warehouseForm
    {
        public int Id { get; set; } // Уникальный идентификатор склада
        public string Adres { get; set; } // Адрес склада
        public double Ploshad { get; set; } // Общая площадь склада
        public double SvobodnayaPloshad { get; set; } // Свободная площадь склада
        public List<string> TipyTMC { get; set; } = new List<string>(); // Допустимые типы товаров на складе
    }
    // tmc
    public class goodsForm 
    {
        public int Id { get; set; } // Уникальный идентификатор товара
        public string Naimenovanie { get; set; } // Наименование товара
        public string Tip { get; set; } // Тип товара (например, "продукты", "строительные материалы")
        public int Kolichestvo { get; set; } // Количество товара
        public int KlientId { get; set; } // ID клиента, которому принадлежит товар
        public int SkladId { get; set; } // ID склада, на котором хранится товар
    }
    //dogovor
    public class contractsForm
    {
        public int Id { get; set; } // Уникальный идентификатор договора
        public int KlientId { get; set; } // ID клиента
        public int SkladId { get; set; } // ID склада
        public DateTime DataNachala { get; set; } // Дата начала действия договора
        public DateTime DataOkonchaniya { get; set; } // Дата окончания действия договора
        public double Summa { get; set; } // Сумма арендной платы
        public bool Oplachen { get; set; } // Флаг оплаты (true - оплачен, false - не оплачен)
        public string TipDogovora { get; set; } // Тип договора (например, "площадь", "количество ТМЦ")
    }
    //client
    public class clientForm
    {
        public int Id { get; set; } // Уникальный идентификатор клиента
        public string Naimenovanie { get; set; } // Наименование клиента
        public string Kontakty { get; set; } // Контактная информация клиента (телефон, email и т.д.)
    }
    //plata
    public class reportPaymentForm
    {
        public int Id { get; set; } // Уникальный идентификатор платежа
        public int DogovorId { get; set; } // ID договора, к которому относится платеж
        public DateTime DataPlatezha { get; set; } // Дата платежа
        public double Summa { get; set; } // Сумма платежа
        public string TipPlatezha { get; set; } // Тип платежа (наличный/безналичный)
    }


    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
