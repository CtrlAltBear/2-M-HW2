using System;
namespace Modul2HW2
{
   public class EmailService
    {
        public string Email { get; set; }
        public int OrderNumber { get; set; }
        public float TotalPrice { get; set; }

        public void Send()
        {
            if (Email != string.Empty)
            {
                Console.WriteLine($"Информация о заказе №{OrderNumber} Сумма {TotalPrice} Был отправлен на {Email}");
            }
            else
            {
                Console.WriteLine("Почты не существует ");
            }
        }
    }
}
