using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class BuyerBO
    {
        static List<Buyer> blist = new List<Buyer>();
        DateTime t = new DateTime();
        // static List<Buyer> bl = new List<Buyer>();
        public BuyerBO()
        {

        }
        public void signup(int id, string uname, string password, string email, long mobileno)
        {
            blist.Add(new Buyer(id, uname, password, email, mobileno));
            Console.WriteLine("Registration Done...");
        }
        public void viewDetails()
        {
            foreach (Buyer e1 in blist)
            {
                Console.WriteLine(e1.ToString() + " " + t.Date);
            }
        }
        public int Login(int id, string pas)
        {
            int count = 1;
            List<Buyer> tr1 = blist.FindAll(e => e.Id == id);
            List<Buyer> tr2 = blist.FindAll(e => e.Password == pas);
            foreach (Buyer e in tr1)
            {
                foreach (Buyer e1 in tr2)
                {
                    if (e.Id.Equals(id) && e1.Password.Equals(pas))
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