using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSMControls
{
    public partial class MyComboBox : ComboBox
    {
        private Color m_hovercolor1 = Color.FromArgb(225, 174, 0);
        private Color m_hovercolor2 = Color.FromArgb(255, 255, 255);
        private bool enterkey = true;
        public MyComboBox()
        {
            this.Size = new System.Drawing.Size(196, 20);
            this.ForeColor = Color.Black;
            this.Font = new System.Drawing.Font("B Yekan", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RightToLeft = RightToLeft.Yes;
        }
        public Color Mouseclick { get { return m_hovercolor1; } set { m_hovercolor1 = value; Invalidate(); } }
        public Color MouseClickLeave { get { return m_hovercolor2; } set { m_hovercolor2 = value; Invalidate(); } }
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            this.BackColor = Mouseclick;

        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Enter && enterkey)
            {
                SendKeys.Send("{TAB}");
            }
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            this.BackColor = MouseClickLeave;
        }
      
    }
}
