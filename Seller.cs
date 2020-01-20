using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class Seller
    {
        public int sid { get; set; }
        public string sname { get; set; }
        public string spassword { get; set; }
        public string scompanyname { get; set; }
        public string sgstin { get; set; }
        public string saboucompany { get; set; }
        public string saddress { get; set; }
        public string swebsite { set; get; }
        public string semailid { get; set; }

        public long smobileno { get; set; }
        public Seller()
        {

        }
        public Seller(int id, string sname, string pass, string companyname, string gstin, string aboutcompany, string address, string website, string emailid, long mob)
        {
            this.sid = id;
            this.sname = sname;
            this.spassword = pass;
            this.scompanyname = companyname;
            this.sgstin = gstin;
            this.saboucompany = aboutcompany;
            this.saddress = address;
            this.swebsite = website;
            this.semailid = emailid;
            this.smobileno = mob;
        }
    }
}