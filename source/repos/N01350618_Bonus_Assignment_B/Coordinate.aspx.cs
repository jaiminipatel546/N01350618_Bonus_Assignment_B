using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace N01350618_Bonus_Assignment_B
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                // Validate X & Y Co-ordinate values.
                Page.Validate();

                //If everything is okay, the next step is...
                if (Page.IsValid)
                {
                    int x_coordinate_value = Convert.ToInt32(x_coordinate.Text);
                    int y_coordinate_value = Convert.ToInt32(y_coordinate.Text);

                    coordinate_summary.InnerHtml += "The result is " + "<br>";
                    //if x-coordinate value is > 0
                    if (x_coordinate_value > 0)
                    {
                        //if y-coordinate value is > 0
                        if (y_coordinate_value > 0)
                        {
                            //it is quadrant 1
                            coordinate_summary.InnerHtml = "(" + x_coordinate_value + " , " + y_coordinate_value + ") falls in Quadrant 1 " + "</br>";
                        }
                        else
                        {   //it is quadrant 4
                            coordinate_summary.InnerHtml = "(" + x_coordinate_value + " , " + y_coordinate_value + ") falls in Quadrant 4 " + "</br>";
                        }
                    }
                    //if x-coordinate is < 0
                    else if (x_coordinate_value < 0)
                    {
                        //if y-coordinate is > 0
                        if (y_coordinate_value > 0)
                        {
                            //it is in quadrant 2
                            coordinate_summary.InnerHtml = "(" + x_coordinate_value + " , " + y_coordinate_value + ") falls in Quadrant 2 " + "</br>";
                        }
                        else
                        {
                            //it is in quadrant 3
                            coordinate_summary.InnerHtml = "(" + x_coordinate_value + " , " + y_coordinate_value + ") falls in Quadrant 3 " + "</br>";
                        }
                    }
                }
                
            }
           
        }
        // Custom validator for checking x-coordinate & y-coordinate values are non-zero
        protected void validateCoordinateValue(object source, ServerValidateEventArgs e)
        {
            if (Convert.ToInt32(e.Value) == 0)
            {
                e.IsValid = false;
            }
            else
            {
                e.IsValid = true;
            }
        }
    }
}