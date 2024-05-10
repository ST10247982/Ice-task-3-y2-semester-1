using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_task_3_y2_semester_1
{
    public class Item
    {
        public string ItemName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Item(Items item,double price, int quantity) 
        {
            ItemName = item.ToString();
            Price = price;
            Quantity = quantity;
        }
    }
}
