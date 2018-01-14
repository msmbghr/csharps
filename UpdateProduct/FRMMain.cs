﻿using System;
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
            btnDoneComplete.Enabled = true;
            Decimal c = Convert.ToDecimal(MYdataGrid.CurrentRow.Cells[5].Value);
        }

        public void CompareData(int shka, SqlCommand cmd, int mohvah, decimal mojkavah, int mojkajoz, decimal pure_buy_price)
        {
            cmd = new SqlCommand("SELECT  mohvah,mojkavah,mojkajoz,buy_price FROM ka_act  where shka=" + shka + " and act_id>1 ORDER BY rdf DESC", cnn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "ka_act");
            MessageBox.Show(ds.Tables["ka_act"].Rows[0]["mohvah"].ToString());
            MessageBox.Show(ds.Tables["ka_act"].Rows[0]["mojkavah"].ToString());
            MessageBox.Show(ds.Tables["ka_act"].Rows[0]["mojkajoz"].ToString());
            MessageBox.Show(ds.Tables["ka_act"].Rows[0]["buy_price"].ToString());

            //foreach (SqlDataReader column in )
            //    dt.Columns.Add(column.Name, typeof(string));
            //dt.Columns.Add("mohvah", typeof(int)); 
            //dt.Columns.Add("mojkavah", typeof(string));
            //dt.Columns.Add("mojkajoz", typeof(string));
            //dt.Columns.Add("buy_price", typeof(string));

            //while (da.Read())
            //{
            //    DataRow dr1 = dt.NewRow();
            //    dr1[0] = da.GetInt32(da.GetOrdinal("mohvah"));
            //    dr1[1] = da.GetDecimal(da.GetOrdinal("mojkavah"));
            //    dr1[2] = da.GetInt32(da.GetOrdinal("mojkajoz"));
            //    dr1[3] = da.GetDecimal(da.GetOrdinal("buy_price"));
            //    dt.Rows.Add(dr1);
            //    MessageBox.Show(dr1[0].ToString());

            //}
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

            for (int i = 0; i < MYdataGrid.Rows.Count; i++)
            {
                cnn = new SqlConnection(MyFunc.stringconnect());
                checkSatateConnection(1);
                int shka = int.Parse(MYdataGrid.Rows[i].Cells[1].Value.ToString());
                string naka = MYdataGrid.Rows[i].Cells[2].Value.ToString();
                bool canchange = false;

                int mohvah = int.Parse(MYdataGrid.Rows[i].Cells[4].Value.ToString());
                decimal mojkavah = decimal.Parse(MYdataGrid.Rows[i].Cells[5].Value.ToString());
                int mojkajoz = int.Parse(MYdataGrid.Rows[i].Cells[6].Value.ToString());
                decimal pure_buy_price = decimal.Parse(MYdataGrid.Rows[i].Cells[7].Value.ToString());
                cmd = new SqlCommand("SELECT TOP 1 * FROM ka_act  where shka=" + shka + " and act_id>1 ORDER BY rdf DESC", cnn);
                //CompareData(shka);
                //int count =int.Parse(cmd.ExecuteScalar().ToString());
                if (cmd.ExecuteScalar() == null)
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
                    MessageBox.Show("كالاي  " + naka + " تغيير كرد");
                }
                checkSatateConnection(0);

            }
            MessageBox.Show("تغييرات انجام شد");
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
    }
}
