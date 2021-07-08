using System;
namespace Modul2HW2
{
    public class SMSService
    {
        public string Telephone { get; set; }
        public int OrderNumber { get; set; }
        public float TotalPrice { get; set; }

        public void Send()
        {
            if (Telephone != string.Empty)
            {
                Console.WriteLine($"Информация о заказе №{OrderNumber} Сумма {TotalPrice} Был отправлен на {Telephone}");
            }
            else
            {
                Console.WriteLine("Телефон не существует ");
            }
        }
    }
}
