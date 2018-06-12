using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MSMControls
{
    public partial class MyTXTDate : UserControl
    {
        private Color m_hovercolor1 = Color.FromArgb(225, 174, 0);
        private Color m_hovercolor2 = Color.FromArgb(255, 255, 255);
        public string day;
        public static string month;
        public static string year;
        DateTime dt = DateTime.Now;
        public string msg;
        PersianCalendar p = new PersianCalendar();

        [Category("MSM_Behavior")]
        [DefaultValue(false)]
        [Description("اگر روي تكست باكس كليك بكنيد چه رنگي بشه")]
        public Color Mouseclick { get { return m_hovercolor1; } set { m_hovercolor1 = value; Invalidate(); } }

        #region
        [Category("MSM_Behavior")]
        [Description("هيچ توضيحي نوشته نشده است")]
        public Color MouseClickLeave { get { return m_hovercolor2; } set { m_hovercolor2 = value; Invalidate(); } }
        #endregion
        [Category("MSM_Behavior")]
        [Description("هيچ توضيحي نوشته نشده است")]
        public string SendMessage { get { return msg; } set { msg = value; Invalidate(); } }
        public MyTXTDate()
        {
            InitializeComponent();
            year = p.GetYear(dt).ToString();
            month = p.GetMonth(dt).ToString();
            day = p.GetDayOfMonth(dt).ToString();
            if (day.Count() == 1)
            {
                day = "0" + day;
            }
            if (month.Count() == 1)
            {
                month = "0" + month;
            }
            TXTYear.Text = year;
            TXTMonth.Text = month;
            TXTDay.Text = day;
        }
        public string Day()
        {
            day = TXTDay.Text;
            return day;
        }
        public string Month()
        {
            month = TXTMonth.Text;
            return month;
        }
        public string Year()
        {
            year = TXTYear.Text;
            return year;
        }
        private void MyTXTDate_Load(object sender, EventArgs e)
        {

        }
        private void TXTDay_Leave(object sender, EventArgs e)
        {
            if (TXTDay.Text.Count() == 1)
            {
                TXTDay.Text = "0" + TXTDay.Text;
            }

            TXTDay.BackColor = MouseClickLeave;
            if (int.Parse(TXTDay.Text) < 1 || int.Parse(TXTDay.Text) > 31 || TXTDay.Text.Length > 2)
            {
                TXTDay.Focus();
                TXTDay.SelectAll();
            }
           
        }
        private void TXTDay_KeyUp(object sender, KeyEventArgs e)
        {

        }
        private void TXTDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

        }
        private void TXTDay_KeyDown(object sender, KeyEventArgs e)

        {
            if ((e.KeyCode == Keys.Enter))
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
            }


        }
        private void TXTMonth_Leave(object sender, EventArgs e)
        {
            
            if (TXTMonth.Text.Count() == 1)
            {
                TXTMonth.Text = "0" + TXTMonth.Text;
            }
            if ((int.Parse(TXTMonth.Text)) < 1 || int.Parse(TXTMonth.Text) > 12 || TXTMonth.Text.Length > 2)
            {
                TXTMonth.Focus();
                TXTMonth.SelectAll();
            }
            try
            {
                if (int.Parse(TXTMonth.Text) > 6 && int.Parse(TXTDay.Text) > 30)
                {
                    TXTMonth.BackColor = MouseClickLeave;
                    TXTDay.Focus();
                    TXTDay.SelectAll();
                }
            }
            catch
            { }
        }
        private void TXTMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
          
        }
        private void TXTYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TXTMonth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                {
                    e.SuppressKeyPress = true;

                    SendKeys.Send("{TAB}");
                }
            }
            
            
            TXTMonth.BackColor = MouseClickLeave;
        }
        private void TXTYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                SendKeys.Send("{TAB}");
            }
            
        }
        private void TXTDay_Enter(object sender, EventArgs e)
        {

            TXTDay.BackColor = Mouseclick;
            TXTDay.SelectAll();
        }
        private void TXTMonth_Enter(object sender, EventArgs e)
        {
            TXTMonth.BackColor = Mouseclick;
            TXTMonth.SelectAll();
        }
        private void TXTYear_Enter(object sender, EventArgs e)
        {

            TXTYear.BackColor = Mouseclick;
            TXTYear.SelectAll();
        }
        private void TXTYear_Leave(object sender, EventArgs e)
        {
            if (TXTYear.Text.Length < 4 || TXTYear.Text.Length > 4)
            {
                MessageBox.Show("لطفا سال را صحيح وارد كنيد");
                TXTYear.Focus();
                TXTYear.SelectAll();

            }
            TXTYear.BackColor = MouseClickLeave;
        } 
        private void TXTMonth_TextChanged(object sender, EventArgs e)
        {
            if (TXTMonth.Text.Count() > 2)
            {
                MessageBox.Show("لطفا ماه را صحيح وارد كنيد");
                TXTMonth.Focus();
                TXTMonth.SelectAll();
            }
            if ((int.Parse(TXTMonth.Text)) < 1 || int.Parse(TXTMonth.Text) > 12 || TXTMonth.Text.Length > 2)
            {
                MessageBox.Show("لطفا ماه را صحيح وارد كنيد");
                TXTMonth.Focus();
                TXTMonth.SelectAll();
            }

          
        }
        private void TXTDay_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(TXTDay.Text) < 1 || int.Parse(TXTDay.Text) > 31 || TXTDay.Text.Length > 2)
            {
                MessageBox.Show("لطفا روز را صحيح وارد كنيد");
                TXTDay.Focus();
                TXTDay.SelectAll();
            }
        }

        private void TXTYear_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

