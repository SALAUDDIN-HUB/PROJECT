using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    class Buyer
    {
        int id;
        string uname, password, mailid;
        long mno;
        public int Id { get => id; set => id = value; }
        public string Uname { get => uname; set => uname = value; }
        public string Password { get => password; set => password = value; }
        public string Mailid { get => mailid; set => mailid = value; }
        public long Mobileno { get => mno; set => mno = value; }
        public Buyer(int id, string uname, string pas, string mailid, long mno)
        {
            this.Id = id;
            this.Uname = uname;
            this.Password = pas;
            this.Mailid = mailid;
            this.Mobileno = mno;
        }
        public Buyer()
        {

        }
        public override string ToString()
        {
            return "Customer id.." + this.Id + "\tCustomer name.." + this.Uname + "\tPassword.. " + this.Password + "\tMailid.. " + this.Mailid + "\tMObileNo.." + this.Mobileno;
        }
    }
}