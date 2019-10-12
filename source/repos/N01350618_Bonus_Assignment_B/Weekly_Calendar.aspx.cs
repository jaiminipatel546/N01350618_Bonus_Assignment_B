using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace N01350618_Bonus_Assignment_B
{
    public partial class Weekly_Calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //add days starting from tuesday as it is 1st october
            List<string> workdays = new List<string>();
            workdays.Add("Tuesday");
            workdays.Add("Wednesday");
            workdays.Add("Thursday");
            workdays.Add("Friday");
            workdays.Add("Saturday");
            workdays.Add("Sunday");
            workdays.Add("Monday");

            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {

                    weekly_calendar_summary.InnerHtml = "";
                    //loop for the month of october
                    for (int i = 1; i < 32; i++)
                    {
                        //looping for weekdays
                        foreach (string weekday in workdays)
                        {
                            foreach (ListItem weekdays in user_working_days.Items)
                            {
                                //check if i is not exceeding 31
                                if (i >= 32)
                                {
                                    break;
                                }
                                //check if any weekday is there
                                if (weekday == weekdays.Value)
                                {
                                    //if any day of the week is selected then what should we do
                                    if (weekdays.Selected == true)
                                    {
                                        //if any day is selected day then it is time to work
                                        weekly_calendar_summary.InnerHtml += "Oct " + (i++) + " is a " + weekdays.Value + "!Time to work..<br>";
                                    }
                                    else
                                    {
                                        //if day is not selected day then it is time to have fun
                                        weekly_calendar_summary.InnerHtml += "Oct " + (i++) + " is a " + weekdays.Value + "!Time to have fun!<br>";
                                    }
                                    break;
                                }
                            }
                        }
                        i--;
                    }
                }
            }
        }
    }
}