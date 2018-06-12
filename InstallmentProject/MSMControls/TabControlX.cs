using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTabControl
{
    public partial class TabControlX : UserControl
    {
        public TabControlX()
        {
            InitializeComponent();
        }
        int selected_index = -1;
        private List<ButtonX> buttonlist = new List<ButtonX> { };
        private List<TabPanelControl> tabPanelCtrlList = new List<TabPanelControl> { };

        private Size tab_size = new Size(110, 25);
        private Color sel_tab_forecolor = Color.White;
        private Color unsel_tab_forecolor = Color.White;
        private Color sel_tab_backcolor = Color.FromArgb(20, 120, 240);
        private Color un_sel_tab_backcolor = Color.FromArgb(40, 40, 40);
        private Color tab_mouseHvrColor = Color.FromArgb(20, 120, 240);
        private Color tab_mouseClkColor = Color.FromArgb(20, 80, 200);
        private int txt_x_loc = 10, txt_y_loc = 5;
        private Color ribbon_Color = Color.FromArgb(20, 120, 240);
        private Color tabCtrlPanel_backcolor = Color.FromArgb(40, 40, 40);
        private Color tabCtrlButPanel_backcolor = Color.FromArgb(30, 30, 30);

        void setHeight()
        {
            if (!buttonlist.Any())
            {
                BackTopPanel.Height = tab_size.Height;
                TabButtonPanel.Height = tab_size.Height - 3;
                RibbonPanel.Height = 2;
            }
            else
            {
                BackTopPanel.Height = buttonlist[0].Height;
                TabButtonPanel.Height = buttonlist[0].Height - 30;
                RibbonPanel.Height = 2;
            }
        }

        public List<ButtonX> TabsList
        {
            get { return buttonlist; }
        }

        public Size TabSize
        {
            get { return tab_size; }
            set { tab_size = value; setHeight(); Invalidate(); }
        }

        public Color SelTabForeColor
        {
            get { return sel_tab_forecolor; }
            set { sel_tab_forecolor = value; Invalidate(); }
        }

        public Color UnSelTabForeColor
        {
            get { return unsel_tab_forecolor; }
            set { unsel_tab_forecolor = value; Invalidate(); }
        }

        public Color SelTabBackColor
        {
            get { return sel_tab_backcolor; }
            set { sel_tab_backcolor = value; Invalidate(); }
        }

        public Color UnSelTabBackColor
        {
            get { return un_sel_tab_backcolor; }
            set { un_sel_tab_backcolor = value; Invalidate(); }
        }

        public Color MouseHrTabColor
        {
            get { return tab_mouseHvrColor; }
            set { tab_mouseHvrColor = value; Invalidate(); }
        }

        public Color MouseClkTabColor
        {
            get { return tab_mouseClkColor; }
            set { tab_mouseClkColor = value; Invalidate(); }
        }

        public int X_TextLoc
        {
            get { return txt_x_loc; }
            set { txt_x_loc = value; Invalidate(); }
        }

        public int Y_TextLoc
        {
            get { return txt_y_loc; }
            set { txt_y_loc = value; Invalidate(); }
        }

        public Color RibbonColor
        {
            get { return ribbon_Color; }
            set { RibbonPanel.BackColor = value; ribbon_Color = value; Invalidate(); }
        }

        public Color CtrlPanelColor
        {
            get { return tabCtrlPanel_backcolor; }
            set { TabPanel.BackColor = value; tabCtrlPanel_backcolor = value; Invalidate(); }
        }

        public Color TabPanelColor
        {
            get { return tabCtrlButPanel_backcolor; }
            set
            {
                BackTopPanel.BackColor = value; TabButtonPanel.BackColor = value;
                tabCtrlButPanel_backcolor = value; Invalidate();
            }
        }

        public int SelectedTabIndex()
        {
            return selected_index;
        }

        public int TabCount()
        {
            return buttonlist.Count;
        }


        public void ChangeTabText(string newtext, int index)
        {
            ButtonX but = buttonlist[index];
            but.Text = newtext;
        }
        void UpdateButtons()
        {
            if (buttonlist.Count > 0)
            {
                for (int i = 0; i < buttonlist.Count; i++)
                {
                    if (i == selected_index)
                    {
                        buttonlist[i].ChangeColorMouseHC = false;
                        buttonlist[i].BXBackColor = Color.FromArgb(20, 120, 240);
                        buttonlist[i].ForeColor = Color.White;
                        buttonlist[i].MouseHoverColor = Color.FromArgb(20, 120, 240);
                        buttonlist[i].MouseClickColor1 = Color.FromArgb(20, 120, 240);
                    }
                    else
                    {
                        buttonlist[i].ChangeColorMouseHC = true;
                        buttonlist[i].ForeColor = Color.White;
                        buttonlist[i].MouseHoverColor = Color.FromArgb(20, 120, 240);
                        buttonlist[i].BXBackColor = Color.FromArgb(40, 40, 40);
                        buttonlist[i].MouseClickColor1 = Color.FromArgb(20, 80, 200);
                    }
                }

            }
        }

        void createAndAddButton(string tabtext, TabPanelControl tpcontrol, Point loc)
        {
            ButtonX b = new ButtonX();
            b.DisplayText = tabtext + " X";
            b.Text = tabtext;
            b.Size = new Size(130, 30);
            b.Location = loc;
            b.ForeColor = Color.White;
            b.TextAlign = ContentAlignment.MiddleCenter;
            b.BXBackColor = Color.FromArgb(20, 120, 240);
            b.MouseHoverColor = Color.FromArgb(20, 120, 240);
            b.MouseClickColor1 = Color.FromArgb(20, 80, 200);
            b.ChangeColorMouseHC = false;
            b.TextLocation_X = 10;
            b.TextLocation_Y = 9;
            b.RightToLeft = RightToLeft.Yes;
            b.Font = this.Font;
            b.Click += button_Click;
            TabButtonPanel.Controls.Add(b);
            buttonlist.Add(b);
            selected_index++;
            tabPanelCtrlList.Add(tpcontrol);
            TabPanel.Controls.Clear();
            TabPanel.Controls.Add(tpcontrol);
            UpdateButtons();
            TabPanel.Controls.Clear();
            //for (int i = 0; i < tabPanelCtrlList.Count; i++)
            //{
            TabPanel.Controls.Add(tabPanelCtrlList[0]);

            //}
        }

        void button_Click(object sender, EventArgs e)
        {
            string btext = ((ButtonX)sender).Text;
            int index = 0, i;
            for (i = 0; i < buttonlist.Count; i++)
            {
                if (buttonlist[i].Text == btext)
                {
                    index = i;
                }
            }
            TabPanel.Controls.Clear();
            TabPanel.Controls.Add(tabPanelCtrlList[index]);
            selected_index = ((ButtonX)sender).TabIndex;

            UpdateButtons();
        }


        public void AddTab(string tabtext, TabPanelControl tpcontrol)
        {

            if (!buttonlist.Any())
            {


                createAndAddButton(tabtext, tpcontrol, new Point(TabButtonPanel.Width - 130, 0));

            }
            else
            {
                createAndAddButton(tabtext, tpcontrol, new Point(buttonlist[buttonlist.Count - 1].Location.X - 130, 0));
                button_Click(buttonlist[buttonlist.Count - 1], null);
            }
        }



        private void toolStripButton1_DropDownOpening(object sender, EventArgs e)
        {
            toolStripDropDownButton1.DropDownItems.Clear();
            int mergeindex = 0;
            for (int i = 0; i < buttonlist.Count; i++)
            {
                ToolStripMenuItem tbr = new ToolStripMenuItem();
                tbr.Text = buttonlist[i].Text;
                tbr.MergeIndex = mergeindex;
                if (selected_index == i)
                {
                    tbr.Checked = true;
                }
                tbr.Click += tbr_Click;
                toolStripDropDownButton1.DropDownItems.Add(tbr);
                mergeindex++;
            }
        }



        List<string> btstrlist = new List<string> { };
        void BackToFront_SelButton()
        {
            int i = 0;

            TabButtonPanel.Controls.Clear();
            btstrlist.Clear();
            for (i = 0; i < buttonlist.Count; i++)
            {
                btstrlist.Add(buttonlist[i].Text);
            }

            buttonlist.Clear();

            for (int j = 0; j < btstrlist.Count; j++)
            {
                if (j == 0)
                {
                    ButtonX b = new ButtonX();
                    b.DisplayText = btstrlist[j];
                    b.Text = btstrlist[j];
                    b.Size = new Size(130, 30);
                    b.Location = new Point(TabButtonPanel.Width - 130, 0);
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    b.RightToLeft = RightToLeft.Yes;
                    b.ForeColor = Color.White;
                    b.BXBackColor = Color.FromArgb(20, 120, 240);
                    b.MouseHoverColor = Color.FromArgb(20, 120, 240);
                    b.MouseClickColor1 = Color.FromArgb(20, 80, 200);
                    b.ChangeColorMouseHC = false;
                    b.TextLocation_X = 10;
                    b.TextLocation_Y = 9;
                    b.Font = this.Font;
                    b.Click += button_Click;
                    TabButtonPanel.Controls.Add(b);
                    buttonlist.Add(b);
                    selected_index++;
                }
                else if (j > 0)
                {

                    ButtonX b = new ButtonX();
                    b.DisplayText = btstrlist[j];
                    b.Text = btstrlist[j];
                    b.Size = new Size(130, 30);
                    b.ForeColor = Color.White;
                    b.BXBackColor = Color.FromArgb(20, 120, 240);
                    b.MouseHoverColor = Color.FromArgb(20, 120, 240);
                    b.MouseClickColor1 = Color.FromArgb(20, 80, 200);
                    b.ChangeColorMouseHC = false;
                    b.TextLocation_X = 10;
                    b.TextLocation_Y = 9;
                    b.Font = this.Font;
                    b.Click += button_Click;
                    b.Location = new Point(buttonlist[buttonlist.Count - 1].Location.X - 130, 0);
                    TabButtonPanel.Controls.Add(b);
                    buttonlist.Add(b);
                    selected_index++;
                }
            }
            TabPanel.Controls.Clear();
        }

        void tbr_Click(object sender, EventArgs e)
        {
            int i;
            for (int k = 0; k < ((ToolStripMenuItem)sender).MergeIndex; k++)
            {
                int j = 0;
                for (i = ((ToolStripMenuItem)sender).MergeIndex; i >= 0; i--)
                {
                    ButtonX but = buttonlist[i];
                    ButtonX temp = buttonlist[j];
                    buttonlist[i] = temp;
                    buttonlist[j] = but;

                    TabPanelControl uct1 = tabPanelCtrlList[i];
                    TabPanelControl tempusr = tabPanelCtrlList[j];
                    tabPanelCtrlList[i] = tempusr;
                    tabPanelCtrlList[j] = uct1;
                }
            }

            string btext = ((ToolStripMenuItem)sender).Text;
            BackToFront_SelButton();
            selected_index = 0;
            TabPanel.Controls.Add(tabPanelCtrlList[buttonlist[0].TabIndex]);
            UpdateButtons();
        }


        public void RemoveTab(int index)
        {
            if (index >= 0 && buttonlist.Count > 0 && index < buttonlist.Count)
            {
                buttonlist.RemoveAt(index);
                tabPanelCtrlList.RemoveAt(index);
                BackToFront_SelButton();
                if (buttonlist.Count > 1)
                {
                    if (index - 1 >= 0)
                    {
                        TabPanel.Controls.Add(tabPanelCtrlList[index - 1]);
                    }
                    else
                    {
                        TabPanel.Controls.Add(tabPanelCtrlList[(index - 1) + 1]);
                        selected_index = (index - 1) + 1;
                    }
                }
                selected_index = index - 1;

                if (buttonlist.Count == 1)
                {
                    TabPanel.Controls.Add(tabPanelCtrlList[0]);
                    selected_index = 0;
                }
            }
            UpdateButtons();
        }


    }
}
