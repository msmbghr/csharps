using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSMControls
{
    public partial class MSMButton :Button
    {
        public MSMButton()
        {
            BackColor = Color.DodgerBlue;
            ForeColor = Color.White;
        }
        protected override void OnPaint(PaintEventArgs parent)
        {
            parent.Graphics.FillRectangle(new SolidBrush(this.BackColor), 0, 0, this.Width, this.Height);
            TextFormatFlags flag = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(parent.Graphics, Text, Font, new Point(Width + 3, this.Height / 2), ForeColor, flag);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            BackColor = Color.DarkOrchid;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            BackColor = Color.DodgerBlue;
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            BackColor = Color.RoyalBlue;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            BackColor = Color.DodgerBlue;
        }
        private Color onMouseHoverBackcolor = Color.DarkOrchid;
        public Color OnMouseHoverBackcolor
        {
            get { return onMouseHoverBackcolor; }
            set {  onMouseHoverBackcolor=value; }
        }

    }
}
