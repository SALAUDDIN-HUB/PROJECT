using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
	class Program
	{
		static void Main(string[] args)
		{
			int id;
			long mobileno;
			string uname, password, email;
			for (; ; )
			{
				Console.WriteLine("1.Buyer\n2.Seller\n3.Admin\n4.Exit");
				Console.WriteLine("Enter choice...");
				int ch = int.Parse(Console.ReadLine());
				BuyerBO bo = new BuyerBO();
				switch (ch)
				{
					case 1:
						while (true)
						{
							Console.WriteLine("1.Registeration\n2.Buyer Details\n3.Login\n4.Logout");
							int ch1 = int.Parse(Console.ReadLine());
							switch (ch1)
							{
								case 1:
									Console.WriteLine("Enter User Id..");
									id = int.Parse(Console.ReadLine());
									Console.WriteLine("Enter User Name..");
									uname = Console.ReadLine();
									Console.WriteLine("Enter User Password..");
									password = Console.ReadLine();
									Console.WriteLine("Enter User Mailid..");
									email = Console.ReadLine();
									Console.WriteLine("Enter Mobile Num..");
									mobileno = long.Parse(Console.ReadLine());
							
									bo.signup(id, uname, password, email, mobileno);
									break;
								case 2:
									bo.viewDetails();
									break;
								case 3:
									Console.WriteLine("Enter User Id...");
									int id1 = int.Parse(Console.ReadLine());
									Console.WriteLine("Enter password...");
									string pas = Console.ReadLine();
									int cnt = bo.Login(id1, pas);
									ItemsBO ib1 = new ItemsBO();
									if (cnt == 0)
									{
										Console.WriteLine("1.View Products\n2.Buy Products..");
										int se = int.Parse(Console.ReadLine());
										if (se == 1)
										{

											ib1.viewItems();
										}

									}
									else
									{
										Console.WriteLine("Invalid Creditianls..");
									}
									break;
								case 0: goto sample1;
								default:
									Console.WriteLine("Choose Write Option..");
									break;
							}
						}
					sample1: break;
					//break;
					case 2:
						while (true)
						{
							Console.WriteLine("1.Register\n2.Login\n3" +
								".Logout");
							int sch = int.Parse(Console.ReadLine());
							SellerBO sb = new SellerBO();
							switch (sch)
							{
								case 1:
									Console.WriteLine("Enter Seller Id..");
									int sid = int.Parse(Console.ReadLine());
									Console.WriteLine("Enter Seller User name...");
									string suname = Console.ReadLine();
									Console.WriteLine("Enter Seller Password...");
									string spas = Console.ReadLine();
									Console.WriteLine("Enter Seller Comapany name...");
									string scname = Console.ReadLine();
									Console.WriteLine("Enter GSTIN...");
									string gstin = Console.ReadLine();
									Console.WriteLine("Enter About seller Company...");
									string aboutcomp = Console.ReadLine();
									Console.WriteLine("Enter Seller Company address...");
									string saddress = Console.ReadLine();
									Console.WriteLine("Enter Seller Website...");
									string swebsite = Console.ReadLine();
									Console.WriteLine("Enter Seller Email...");
									string semail = Console.ReadLine();
									Console.WriteLine("Enter Seller Mobile NO...");
									long smno = long.Parse(Console.ReadLine());
									sb.signup(sid, suname, spas, scname, gstin, aboutcomp, saddress, swebsite, semail, smno);
									break;
								case 2:
									Console.WriteLine("Enter User Id..");
									int ide = int.Parse(Console.ReadLine());
									Console.WriteLine("Enter Password...");
									string spa = Console.ReadLine();
									int c1 = sb.login(ide, spa);
									if (c1 == 0)
									{
										while (true)
										{
											Console.WriteLine("1.AddItems\n2.ViewItems\n0.Back To Login");
											Console.WriteLine("Enter your Choice...");
											int bch = int.Parse(Console.ReadLine());
											ItemsBO ib = new ItemsBO();
											int d, d1;
											switch (bch)
											{

												case 1:
													Console.WriteLine("Enter Items by Category and Subcatogery Wise..");
													Console.WriteLine("1.Add Category and Subcategory\n2.Add Product");
													int ad = int.Parse(Console.ReadLine());
													if (ad == 1)
													{
														Console.WriteLine("Enter Category id Which u want to add");
														d = int.Parse(Console.ReadLine());
														Console.WriteLine("Enter Category Name ..");
														string cnam = Console.ReadLine();

														Console.WriteLine("Enter sub Category id Which u want to add");
														d1 = int.Parse(Console.ReadLine());
														Console.WriteLine("Enter Subcatogery Name..");
														string sc_name = Console.ReadLine();
														Console.WriteLine("Enter Details about Subcatogery..");
														string des1 = Console.ReadLine();
														ib.AddCatandSubcategory(d, cnam, d1, sc_name, des1);
													}

													else if (ad == 2)
													{
														Console.WriteLine("Enter Category id Which u want to add");
														int d2 = int.Parse(Console.ReadLine());
														Console.WriteLine("Enter Sub Category id Which u want to add");
														int d3 = int.Parse(Console.ReadLine());
														Console.WriteLine("Enter Itemid..");
														int iid = int.Parse(Console.ReadLine());
														Console.WriteLine("Enter Itemname..");
														string iname = Console.ReadLine();
														Console.WriteLine("Enter price of The item...");
														double iprice = double.Parse(Console.ReadLine());

														Console.WriteLine("Enter Item Description..");
														string des = Console.ReadLine();
														Console.WriteLine("Enter Stock of Items..");
														int st = int.Parse(Console.ReadLine());
														Console.WriteLine("Enter any remarks..");
														string rem = Console.ReadLine();
														Console.WriteLine("Enter any Gst % Of The Item..");
														double gst = double.Parse(Console.ReadLine());
														ib.AddItems(d2, d3, iid, iprice, iname, des, st, rem, gst);
													}
													break;
												case 2:
													ib.viewItems();
													break;
												case 0: goto sample2;
												default:
													Console.WriteLine("Invalid Creditianls..");
													break;
											}
										}
									}
								sample2: break;

								case 0: goto sample;
								//break;
								default:
									Console.WriteLine("enter Correct value..");
									break;
							}
						}
					sample: break;
					//   break;

					case 4:
						System.Environment.Exit(0);
						break;
					default: Console.WriteLine("Choose Write Option.."); break;
				}
			}
		}
	}
}