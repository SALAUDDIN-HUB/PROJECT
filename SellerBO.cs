using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class SellerBO
    {
        static List<Seller> slist = new List<Seller>();
        public SellerBO()
        {

        }
        public void signup(int id, string sname, string pass, string companyname, string gstin, string aboutcompany, string address, string website, string emailid, long mob)
        {
            slist.Add(new Seller(id, sname, pass, companyname, gstin, aboutcompany, address, website, emailid, mob));
            Console.WriteLine("Registration Done..");
        }
        public int login(int id, string pass)
        {
            int count = 1;
            List<Seller> tr1 = slist.FindAll(e => e.sid == id);
            List<Seller> tr2 = slist.FindAll(e => e.spassword == pass);
            foreach (Seller e in tr1)
            {
                foreach (Seller e1 in tr2)
                {
                    if (e.sid.Equals(id) && e1.spassword.Equals(pass))
                    {
                        Console.WriteLine("Login Successful...");
                        count = 0;
                    }
                }
            }
            return count;
        }
    }
}