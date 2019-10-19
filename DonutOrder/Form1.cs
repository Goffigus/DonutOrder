using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonutOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int plain = Convert.ToInt32(plainBox.Text); //get the number of plain donuts the user is ordering
            int jelly = Convert.ToInt32(jellyBox.Text);  //get the number of jelly donuts the user is ordering
            int glaze = Convert.ToInt32(glazeBox.Text); //get the number of glaze donuts the user is ordering

            double total = 0; // total cost of the order

            //find the cost of the number of plain donuts ordered
            if(plain >= 12) //check if the number of plain donuts is greater than 12
            {
                int dozen = plain / 12; //get how many dozen plain donuts were ordered
                int r = plain%12; //remainder after dividing by 12, used to determine the number donuts NOT discounted
                double discount = dozen * 12 * .1; //calculate discount
                total = dozen * 12 + r - discount; //determine current total and apply discount
            }
            else //less than a dozen plain donuts
            {
                total = plain; // find total (plain donuts only cost $1)
            }

            //find the cost of the number of jelly donuts ordered. Has to be added to the current total up to this point
            if (jelly >= 12) //check if the number of plain donuts is greater than 12
            {
                int dozen = jelly / 12; //get how many dozen jelly donuts  were ordered
                int r = jelly % 12; //remainder after dividing by 12, used to determine the number donuts NOT discounted
                double discount;
                if (sprinkleJellyCheck.Checked == true) //check if user ordered sprinkles
                {
                    discount = dozen * 12 * 1.75 * .1; //calculate discount w/ sprinkles (jelly donuts cost $1.75 with sprinkles)
                    total = dozen * 1.75 * 12 + r * 1.75 + total - discount; //determine current total and apply discount w/ sprinkles(jelly donuts cost $1.75 with sprinkles)
                }
                else
                {
                    discount = dozen * 12 * 1.5 * .1; //calculate discount w/o sprinkles (jelly donuts cost $1.50)
                    total = dozen * 1.5 * 12 + r*1.5 + total - discount; //determine current total and apply discount w/o sprinkles(jelly donuts cost $1.50)
                }
                        
            }
            else //less than a dozen jelly donuts
            {
                if (sprinkleJellyCheck.Checked == true) //check if user ordered sprinkles
                {
                    total = jelly * 1.75  + total; //determine current total with sprinkles(jelly donuts cost $1.75 with sprinkles)
                }
                else
                {
                    total = jelly * 1.5 + total; //determine current total and apply discount w/o sprinkles(jelly donuts cost $1.50)
                }
            }

            //find the total cost of the number of glaze donuts ordered. Has to be added to the current total up to this point
            if (glaze >= 12) //check if the number of plain donuts is greater than 12
            {
                int dozen = glaze / 12; //determine how many dozen glaze donuts were ordered
                int r = glaze % 12; //remainder after dividing by 12, used to determine the number donuts NOT discounted
                double discount;
                if (sprinkleGlazeCheck.Checked == true) //check if user ordered sprinkles
                {
                    discount = dozen * 12 * 1.5 * .1; //calculate discount w/ sprinkles (glaze donuts cost $1.50 with sprinkles)
                    total = dozen * 1.5 * 12 + r * 1.5 + total - discount; //determine current total and apply discount w/ sprinkles(glaze donuts cost $1.50 with sprinkles)
                }
                else
                {
                    discount = dozen * 12 * 1.25 * .1; //calculate discount w/o sprinkles (glaze donuts cost $1.25)
                    total = dozen * 1.25 * 12 + r * 1.25 + total - discount; //determine current total and apply discount w/o sprinkles(glaze donuts cost $1.25)
                }

            }
            else //less than a dozen glaze donuts
            {
                if (sprinkleGlazeCheck.Checked == true) //check if user ordered sprinkles
                {
                    total = glaze * 1.50 + total; //determine current total with sprinkles(glaze donuts cost $1.50 with sprinkles)
                }
                else
                {
                    total = glaze * 1.25 + total; //determine current total and apply discount w/o sprinkles(glaze donuts cost $1.25)
                }
            }

            totalCost.Text = total.ToString("C"); //convert the total to a string (text) so that it be put into the lable totalCost whil formatted into currency ("C")
            
        }
    }
}
