using MSMClass;
using System.Drawing;
using System.Windows.Forms;


namespace MSMControls
{
    public class MSMBottonMenu : Button
    {
        private void initialize()
        {
            this.Font = FontManager.GetFont("bnazanin", 14f, FontStyle.Regular);
        }
    }
}
