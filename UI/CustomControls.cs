using System.Windows.Forms;

namespace NetControlApp
{
    public class CustomButton : Button
    {
        public CustomButton()
        {
            // Custom initialization, styling, etc.
            this.BackColor = System.Drawing.Color.LightBlue;
            this.FlatStyle = FlatStyle.Flat;
        }
    }
}
