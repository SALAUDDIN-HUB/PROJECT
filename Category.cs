using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    abstract class Category
    {
        public int cid { get; set; }
        public string cname { get; set; }
        public string breifdetails { get; set; }
        public Category(int id, string cname)
        {
            this.cid = id;
            this.cname = cname;
            //this.breifdetails =cdes;
        }
        //public abstract void display();
    }
    class Subcategory : Category
    {
        public int Sid;
        public string Scname;
        public string Details;
        public Subcategory(int c_id, string cname, int sid, string scname, string details) : base(c_id, cname)
        {
            this.Sid = sid;
            this.Scname = scname;
            this.Details = details;
            //this.Gst = gst;

        }
    }
}