using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace N01350618_Bonus_Assignment_B
{
    public partial class Raffle_Bundle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {
                    raffle_bundle_summary.InnerHtml = " ";
                    int no_of_tickets = Convert.ToInt32(ticket_purchased.Text);
                    Double sum = 0.0;
                    int value = 0;
                    int remainder = 0;

                    //if the tickets purchased are <= 50
                    if(no_of_tickets <= 50)
                    {
                        //raffle_bundle_summary.InnerHtml = " ";
                        for (int i=1; i<=no_of_tickets; i++)
                        {
                            //print bundle of 1
                            raffle_bundle_summary.InnerHtml += "You received a bundle of 1! That's " + i + " ticket(s)!<br>"; 
                        }
                        //what is the total cost of tickets
                        sum = (no_of_tickets * 0.25);
                        //print the total cost with ticket number
                        raffle_bundle_summary.InnerHtml += "Your total ticket(s) is " + no_of_tickets + "and your cost is $" + sum + "cad<br>";
                    }
                    //if the tickets purchased are >= 50 and <=150
                    else if (no_of_tickets >= 51 && no_of_tickets <= 150)
                    {
                        //raffle_bundle_summary.InnerHtml = " ";
                        remainder = (no_of_tickets % 2);
                        for (int i = 2; i <= (no_of_tickets - remainder); i=i+2)
                        {
                            raffle_bundle_summary.InnerHtml += "You received a bundle of 2! That's " + i + "ticket(s)!<br>";
                            value = i;
                        }
                        raffle_bundle_summary.InnerHtml += "Your leftover is " + remainder + " ticket(s). That's " + no_of_tickets + " ticket(s)!<br>";
                        sum = (no_of_tickets * 0.25);
                        raffle_bundle_summary.InnerHtml += "Your total ticket(s) is " + no_of_tickets + "and your cost is $" + sum + "cad<br>";
                    }
                    //if the tickets purchased are >=151 and <=300
                    else if (no_of_tickets >= 151 && no_of_tickets <= 300)
                    {
                        //raffle_bundle_summary.InnerHtml = " ";
                        remainder = (no_of_tickets % 3);
                        for (int i = 3; i <= (no_of_tickets - remainder); i = i + 3)
                        {
                            raffle_bundle_summary.InnerHtml += "You received a bundle of 3! That's " + i + "ticket(s)!<br>";
                            value = i;
                        }
                        raffle_bundle_summary.InnerHtml += "Your leftover is " + remainder + " ticket(s). That's " + no_of_tickets + " ticket(s)!<br>";
                        sum = (no_of_tickets * 0.25);
                        raffle_bundle_summary.InnerHtml += "Your total ticket(s) is " + no_of_tickets + "and your cost is $" + sum + "cad<br>";
                    }
                    //if the tickets purchased are >=301
                    else if (no_of_tickets >= 301)
                    {
                        //raffle_bundle_summary.InnerHtml = " ";
                        //check if there is any remainder or not
                        remainder = (no_of_tickets % 5);
                        for (int i = 5; i <= (no_of_tickets - remainder); i = i + 5)
                        {
                            raffle_bundle_summary.InnerHtml += "You received a bundle of 5! That's " + i + "ticket(s)!<br>";
                            value = i;
                        }
                        raffle_bundle_summary.InnerHtml += "Your leftover is " + remainder + " ticket(s). That's " + no_of_tickets + " ticket(s)!<br>";
                        sum = (no_of_tickets * 0.25);
                        raffle_bundle_summary.InnerHtml += "Your total ticket(s) is " + no_of_tickets + "and your cost is $" + sum + "cad<br>";
                    }

                }
            }
        }
    }
}