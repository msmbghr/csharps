using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UpdateProduct
{
    
    public partial class FRMMain : Form
    {
        public FRMMain()
        {
            InitializeComponent();
        }
        int countWork=0;
        SqlConnection cnn;
        SqlCommand cmd;
        DataTable table = new DataTable();
        BindingSource bs = new BindingSource();
        MyFunction MyFunc = new MyFunction();
        int okey = 0;
        private void btnGetUserPass_Click(object sender, EventArgs e)
        {
            MyFunction MyFunc = new MyFunction();
            if (String.IsNullOrEmpty(TXTUserName.Text) || String.IsNullOrEmpty(TXTPass.Text))
            {
                MessageBox.Show("لطفا نام كاربري و كلمه ورود را وارد كنيد");
            }
            else
            {
                if (MyFunc.MYConnection(TXTUserName.Text, TXTPass.Text) == 1)
                {
                    okey = 1;
                    loadincombobox();
                }
            }
        }
        private void loadincombobox()
        {
            MyFunction MyFunc = new MyFunction();
            cnn = new SqlConnection(MyFunc.stringconnect());
            checkSatateConnection(1);
            cmd = new SqlCommand("select group_rdf,group_name from kagroup", cnn);
            SqlDataReader da = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("group_rdf", typeof(int));
            dt.Columns.Add("group_name", typeof(string));
            while (da.Read())
            {
                DataRow dr1 = dt.NewRow();
                dr1[0] = da.GetInt32(da.GetOrdinal("group_rdf"));
                dr1[1] = da.GetString(da.GetOrdinal("group_name"));
                dt.Rows.Add(dr1);
            }
            da.Close();
            cnn.Close();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "group_name";
            comboBox1.ValueMember = "group_rdf";
        }
        private void FRMMain_Load(object sender, EventArgs e)
        {
            TXTUserName.Text = "arash";
            TXTPass.Text = "1";
            TXTUserName.Focus();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (okey == 1)
            {
                MYdataGrid.Refresh();
                table.Clear();
                MYdataGrid.DataSource = table;
                MyFunction MyFunc = new MyFunction();
                cnn = new SqlConnection(MyFunc.stringconnect());
                checkSatateConnection(1);
                cmd = new SqlCommand("select shka,naka,vahsanj,mohvah,mojkavah,mojkajoz,buyjoz from inventory where group_rdf=" + comboBox1.SelectedValue + "", cnn);
                SqlDataAdapter adabter = new SqlDataAdapter(cmd);
                adabter.Fill(table);
                bs.DataSource = table;
                checkSatateConnection(0);
                MYdataGrid.DataSource = table;
                for (int i = 0; i < MYdataGrid.Rows.Count; i++)
                {
                    Decimal c1 = ((Decimal)(Convert.ToDecimal(MYdataGrid.Rows[i].Cells[4].Value) * Convert.ToDecimal(MYdataGrid.Rows[i].Cells[5].Value) + (Convert.ToDecimal(MYdataGrid.Rows[i].Cells[6].Value.ToString()))));
                    Decimal c2 = c1 * (Decimal)(Convert.ToDecimal(MYdataGrid.Rows[i].Cells[7].Value));
                    MYdataGrid.Rows[i].Cells[0].Value = c2;
                }
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            bs.Filter = string.Format("naka LIKE '%{0}%'", TXTSearch.Text);

        }

        private void FRMMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnClose_Click(null, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MYdataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDone.Enabled = true;
            Decimal c = Convert.ToDecimal(MYdataGrid.CurrentRow.Cells[5].Value);
        }

        public bool CompareData(int shka,int mohvah,decimal mojkavah,int mojkajoz,decimal buy_price)
        {
            bool tf = false; ;
          SqlCommand  cmd1 = new SqlCommand("SELECT  mohvah,mojkavah,mojkajoz,buy_price FROM inventory  where shka=" + shka + " ", cnn);

         
            Inventory inentory = new Inventory();
           
                SqlDataReader dr = cmd1.ExecuteReader();
                while (dr.Read())
                {
                    inentory.mohvah =int.Parse( dr[0].ToString());
                    inentory.mojkavah = decimal.Parse(dr[1].ToString());
                    inentory.mojkajoz = int.Parse(dr[2].ToString());
                    inentory.pure_buy_price = decimal.Parse(dr[3].ToString());
                }
            dr.Close();
            if (mohvah!= inentory.mohvah || mojkavah!= inentory.mojkavah || mojkajoz!= inentory.mojkajoz|| buy_price!= inentory.pure_buy_price)
            {
                tf = true; 
            }
            return tf;

        }
        public void checkSatateConnection(int ol)
        {
            switch (ol)
            {
                case 1:
                    if (cnn != null && cnn.State == ConnectionState.Closed)
                        cnn.Open();
                    break;
                case 0:
                    if (cnn != null && cnn.State == ConnectionState.Open)
                        cnn.Close();
                    break;
            }
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            backGUpdateGoods.RunWorkerAsync();

            
        }

        private void btnDoneComplete_Click(object sender, EventArgs e)
        {
            //update inventory_anbars set mojkavah = @mojkavah, mojkajoz = @mojkajoz where rdf_anbars = 1 and shka = @shka
            //update ka_act set tedvah = @mojkavah, tedjoz = @mojkajoz where shka = @shka and act_id = 1
            //update anbars_act set tedvah = @mojkavah, tedjoz = @mojkajoz where shka = @shka and act_id = 1 and rdf_anbar = 1
        }

        private void btnDone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                btnDone_Click(null, null);
            }
            if (e.KeyCode == Keys.F5)
            {
                btnDoneComplete_Click(null, null);
            }
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }

        }

        private void MYdataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MYdataGrid_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Decimal c1 = ((Decimal)(Convert.ToDecimal(MYdataGrid.CurrentRow.Cells[4].Value) * Convert.ToDecimal(MYdataGrid.CurrentRow.Cells[5].Value) + (Convert.ToDecimal(MYdataGrid.CurrentRow.Cells[6].Value.ToString()))));
            Decimal c2 = c1 * (Decimal)(Convert.ToDecimal(MYdataGrid.CurrentRow.Cells[7].Value));
            MYdataGrid.CurrentRow.Cells[0].Value = c2;
        }

        private void MYdataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Decimal c1 = ((Decimal)(Convert.ToDecimal(MYdataGrid.CurrentRow.Cells[4].Value) * Convert.ToDecimal(MYdataGrid.CurrentRow.Cells[5].Value) + (Convert.ToDecimal(MYdataGrid.CurrentRow.Cells[6].Value.ToString()))));
            Decimal c2 = c1 * (Decimal)(Convert.ToDecimal(MYdataGrid.CurrentRow.Cells[7].Value));
            MYdataGrid.CurrentRow.Cells[0].Value = c2;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //cmd = new SqlCommand("SELECT TOP 1 * FROM ka_act  where act_id>1 ORDER BY rdf DESC", cnn);
            ////CompareData(shka);
            ////int count =int.Parse(cmd.ExecuteScalar().ToString());
            //if (cmd.ExecuteScalar() == null)
            //{
            //}
        }

        private void backGUpdateGoods_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Text.StringBuilder nakaOk = new System.Text.StringBuilder();
            System.Text.StringBuilder nakacancel = new System.Text.StringBuilder();
            System.Text.StringBuilder nakanoneChange = new System.Text.StringBuilder();
            int boolInt = 0;
            cnn = new SqlConnection(MyFunc.stringconnect());
            checkSatateConnection(1);
            for (int i = 0; i < MYdataGrid.Rows.Count; i++)
            {
                int shka = int.Parse(MYdataGrid.Rows[i].Cells[1].Value.ToString());
                string naka = MYdataGrid.Rows[i].Cells[2].Value.ToString();
                int mohvah = int.Parse(MYdataGrid.Rows[i].Cells[4].Value.ToString());
                decimal mojkavah = decimal.Parse(MYdataGrid.Rows[i].Cells[5].Value.ToString());
                int mojkajoz = int.Parse(MYdataGrid.Rows[i].Cells[6].Value.ToString());
                decimal pure_buy_price = decimal.Parse(MYdataGrid.Rows[i].Cells[7].Value.ToString());
                cmd = new SqlCommand("SELECT TOP 1 * FROM ka_act  where shka=" + shka + " and act_id>1 ORDER BY rdf DESC", cnn);
                //CompareData(shka);
                timerDot.Enabled = true;
                //int count =int.Parse(cmd.ExecuteScalar().ToString());
                if (cmd.ExecuteScalar() == null)
                {
                    #region IFOK

                    if (CompareData(shka, mohvah, mojkavah, mojkajoz, pure_buy_price))
                    {
                        string query = "update inventory set mohvah =" + mohvah +
                        ", mojkavah = " + mojkavah + ",mojkajoz=" + mojkajoz + ",pure_buy_price=" + pure_buy_price +
                        ",buy_price=" + pure_buy_price + ",inventory_price=" + pure_buy_price +
                        ",buyjoz=" + pure_buy_price + " where shka=" + shka + "";
                        string query2 = "update ka_act set tedvah = " + mojkavah + ",tedjoz=" + mojkajoz +
                            ",price=" + pure_buy_price +
                             ",invepgh=" + pure_buy_price + ",invep=" + pure_buy_price + "where shka = " + shka + "";
                        string query3 = "update inventory_anbars set mojkavah = " + mojkavah + ",mojkajoz=" + mojkajoz + " where shka = " + shka + "";
                        string query4 = "update anbars_act set tedvah = " + mojkavah + ",tedjoz=" + mojkajoz + ",price=" + pure_buy_price +
                   ",invepgh=" + pure_buy_price + ",invep=" + pure_buy_price + " where shka = " + shka + "";
                        cmd = new SqlCommand(query, cnn);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand(query2, cnn);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand(query3, cnn);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand(query4, cnn);
                        cmd.ExecuteNonQuery();
                        nakaOk.Append(naka + " ");
                    }
                    else
                    {
                        //nakanoneChange.Append(naka+" ");
                    }
                    #endregion

                }
                else
                {
                    if (CompareData(shka, mohvah, mojkavah, mojkajoz, pure_buy_price))
                        nakacancel.Append(naka + " ");
                }

            }
            checkSatateConnection(0);
            MessageBox.Show("كالاهاي***** " + nakaOk.ToString() + "*****تغيير كردند و \n" + " " + "كالاهاي*****" + nakanoneChange + "*****هيچ تغييري نكردند و \n" + " " + "كالاهاي***** " + nakacancel + "*****به دليل داشتن عمليات در آتيران هيج تغييري نكردند");

        }

        private void backGUpdateGoods_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void timerDot_Tick(object sender, EventArgs e)
        {
            countWork += 1;
            if (countWork >= 100)
            {
                timerDot.Enabled = false;
                timerDot.Stop();
            }
            //OTHERWISE
            pBarDo.Value = countWork;
        }

        private void backGUpdateGoods_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pBarDo.Text = e.ProgressPercentage.ToString() + " %";
        }
    }
    public class Inventory
    {
        public int mohvah { get; set; }
        public decimal mojkavah { get; set; }
        public int mojkajoz { get; set; }
        public decimal pure_buy_price { get; set; }
    }
}
