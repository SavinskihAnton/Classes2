using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Invoice
    {
        public readonly int account=0;
        public readonly string customer=null;
        public readonly string provider=null;
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public string Article { get; set; }
        public int Quantity { get; set; }

        public void CostCalculation(bool NDS)
        {
            double cost;
            switch (Article)
            {
                case "laptop": cost = 45000;
                    break;
                case "notebook": cost = 60000;
                    break;
                case "WiFi_Hub": cost = 7000;
                    break;
                default:
                    Console.WriteLine("Не выбран товар");
                    return;
            }
            if (NDS)
            {
                cost = cost * 7 / 6;
            }
            Console.WriteLine("Сумма оплаты {0}", cost*Quantity);
        }
    }
}
