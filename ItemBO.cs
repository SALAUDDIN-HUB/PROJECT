using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
	class ItemsBO
	{
		static List<Items> Ilist = new List<Items>();
		static List<Subcategory> Slist = new List<Subcategory>();
		public void AddCatandSubcategory(int c_id, string cname, int s_id, string scname, string scdes)
		{
			Slist.Add(new Subcategory(c_id, cname, s_id, scname, scdes));
		}
		public void AddItems(int c_id, int s_id, int id, double pri, string item_nam, string des, int st, string rem, double gst)
		{
			//List<Subcategory> s1 = Slist.FindAll(e => e.cid == c_id);

			Ilist.Add(new Items(c_id, s_id, id, pri, item_nam, des, st, rem, gst));
		}
		public void viewItems()
		{

			Console.WriteLine("Category List..");
			foreach (Subcategory i in Slist)
			{
				Console.WriteLine("Category Id.." + i.cid + "\tCategory Name.." + i.cname);
			}
			Console.WriteLine("Enter Category Id..Which you want to view..");
			int opt = int.Parse(Console.ReadLine());
			List<Subcategory> sl = Slist.FindAll(e => e.cid == opt);
			foreach (Subcategory s in sl)
			{
				Console.WriteLine("Subcatogery id.." + s.Sid + "\tSubcatogery name.." + s.Scname + "\tAbout Subcatogery.." + s.Details);
			}
			Console.WriteLine("Enter Subcatogery id To View Products..");
			int opt2 = int.Parse(Console.ReadLine());
			List<Items> il = Ilist.FindAll(e1 => e1.scatogery_id == opt2);
			foreach (Items i in il)
			{
				Console.WriteLine(i.ToString());
			}

		}
	}
}