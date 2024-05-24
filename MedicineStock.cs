using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсач
{
    public class MedicineStock
    {
        public string Name { get; set; } // Назва медикаменту
        public int Quantity { get; set; } // Кількість на складі
        public bool IsSubstitutable { get; set; } // Чи є взаємозамінним
        public double Price { get; set; } // Ціна медикаменту

        public MedicineStock(string name, int quantity, bool isSubstitutable, double price)
        {
            Name = name;
            Quantity = quantity;
            IsSubstitutable = isSubstitutable;
            Price = price;
        }
    }
}
