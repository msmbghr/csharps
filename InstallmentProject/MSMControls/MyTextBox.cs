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
    public partial class MyTextBox :TextBox
    {
        private Color m_hovercolor1 = Color.FromArgb(225,174,0 );
        private Color m_hovercolor2 = Color.FromArgb(255, 255, 255);
        private bool enterkey = true;
        private bool digit = false;
        private bool latter = false;
        private bool beepEnter = false;
        public MyTextBox()
        {
            this.Size = new System.Drawing.Size(196, 20);
            this.ForeColor = Color.Black;
            this.Font = new System.Drawing.Font("B Yekan", 9.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.RightToLeft = RightToLeft.Yes;
            if (OnlyDigit)
                latter = false;
            if (OnlyLetter)
                digit = false;
            this.RightToLeft = RightToLeft.Yes;
        }
        #region
        [Category("MSM_Behavior")]
        [DefaultValue(false)]
        [Description("اگر روي تكست باكس كليك بكنيد چه رنگي بشه")]
        public Color Mouseclick { get { return m_hovercolor1; } set { m_hovercolor1 = value; Invalidate(); } }
        #endregion
        #region
        [Category("MSM_Behavior")]
        [Description("هيچ توضيحي نوشته نشده است")]
        public Color MouseClickLeave { get { return m_hovercolor2; } set { m_hovercolor2 = value; Invalidate(); } }
        #endregion
        #region
        [Category("MSM_Behavior")]
        [Description("هيچ توضيحي نوشته نشده است")]
        public bool SendTab { get { return enterkey; } set { enterkey = value; Invalidate(); } }
        #endregion
        #region
        [Category("MSM_Behavior")]
        [Description("هيچ توضيحي نوشته نشده است")]
        public bool OnlyDigit { get { return digit; } set { digit = value; Invalidate(); } }
        #endregion
        #region
        [Category("MSM_Behavior")]
        [Description("هيچ توضيحي نوشته نشده است")]
        public bool OnlyLetter { get { return latter; } set { latter = value; Invalidate(); } }
        #endregion
        #region
        [Category("MSM_Behavior")]
        [Description("هيچ توضيحي نوشته نشده است")]
        public bool DisBeepEnter { get { return beepEnter; } set { beepEnter = value; Invalidate(); } }
        #endregion
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
                if (DisBeepEnter)
                {
                    e.SuppressKeyPress = true;
                }
                SendKeys.Send("{TAB}");
            }
        }
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            this.BackColor = MouseClickLeave;

        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (OnlyDigit)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            if (OnlyLetter)
            {
                if (!char.IsLetter(e.KeyChar)&&!char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

        }
      
    }
}
