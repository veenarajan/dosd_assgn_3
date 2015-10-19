using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreditCardService
{
    public partial class TryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service1 client = new Service1();
            CardType card = (CardType)Enum.Parse(typeof(CardType), ddlist.SelectedValue);
            
            if (client.creditcardvalidation(card, TextBox1.Text))
            {
                Label3.Text = "Credit Card is valid. Order has been Processed";
            }
            else
            {
                Label3.Text = "Credit Card is not valid. Please enter valid credit card number";
            }
        }
    }
}