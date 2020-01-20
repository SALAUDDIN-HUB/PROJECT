using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class Items
    {
        public int id { get; set; }
        public double price { get; set; }
        public string item_name { get; set; }
        public int category_id { get; set; }
        public int scatogery_id { get; set; }
        public string description { get; set; }
        public int stockNO { get; set; }
        public string remarks { get; set; }
        public double Gst { get; set; }
        public Items(int ca_id, int sc_id, int id, double pri, string item_nam, string des, int st, string rem, double gst)
        {
            this.id = id;
            this.price = pri;
            this.item_name = item_nam;
            this.category_id = ca_id;
            this.scatogery_id = sc_id;
            this.description = des;
            this.stockNO = st;
            this.remarks = rem;
            this.Gst = gst;
        }
        public override string ToString()
        {
            return "Item Id.." + this.id + "\tItemName.. " + this.item_name + "\tItem Price" + this.price + "\tItemDescription.." + this.description + "\tStock Remainig.." + this.stockNO + "\tRemarks.." + this.remarks;
        }
    }
}