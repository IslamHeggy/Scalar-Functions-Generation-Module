using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;

namespace files_proj
{

    public partial class Form1 : Form
    {

        public string s;
        public string[] str;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindDropDown();
        }

        /// addd data in cobmobox///
        public void BindDropDown()
        {
            DataSet ds = new DataSet();
            ds.ReadXml("Data.xml");
            foreach (DataTable table in ds.Tables)
            {
                comboBox1.Items.Add(table.TableName);
            }
        }


        ////show data in tables///
        private void button1_Click(object sender, EventArgs e)
        {

            DataSet ds = new DataSet();
            ds.ReadXml("Data.xml");
            for (int i = 0; i < ds.Tables.Count; i++)
            {
                dataGridView1.DataSource = ds.Tables[i];

                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    for (int k = 0; k < dataGridView1.ColumnCount; k++)
                    {
                        string[] arr = (dataGridView1.Rows[j].Cells[k].Value.ToString()).Split('-');
                        dataGridView1.Rows[j].Cells[k].Value = arr[0];
                    }
                }

                break;
            }

        }


        ////show data from combo box/////
        private void button3_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("Data.xml");
            try
            {
                s = comboBox1.SelectedItem.ToString();
                for (int i = 0; i < ds.Tables.Count; i++)
                {
                    if (s == ds.Tables[i].TableName)
                    {
                        dataGridView1.DataSource = ds.Tables[i];
                    }
                    else
                        continue;

                    for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                    {
                        for (int k = 0; k < dataGridView1.ColumnCount; k++)
                        {
                            string[] arr = (dataGridView1.Rows[j].Cells[k].Value.ToString()).Split('-');

                            dataGridView1.Rows[j].Cells[k].Value = arr[0];
                        }
                    }

                    break;
                }
            }

            catch
            {
                MessageBox.Show(" Select Your DataTable !!");
            }
        }

        //// sum func //////
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                DataSet ds = new DataSet();
                DataSet ds2 = new DataSet();

                ds.ReadXml("Data.xml");
                ds2 = new DataSet();
                ds2.ReadXml("Dt.xml");

                string str_fun = ds2.Tables[0].Rows[0][0].ToString();
                string str_val = "";
                string str_dt = "";
                bool flag = false;

                string table_name = textBox2.Text;

                ds = new DataSet();

                ds.ReadXml("Data.xml");

                string col_name = textBox1.Text;

                double sum = 0;
                int _countr = 0;
                for (int i = 0; i < ds.Tables.Count; i++)
                {

                    while (ds.Tables[i].TableName == table_name)
                    {

                        string str1 = ds.Tables[i].Rows[_countr][col_name].ToString();

                        for (int j = 0; j < str1.Length; j++)
                        {
                            if (str1[j].ToString() == "-")
                            {
                                flag = true;
                                continue;
                            }
                            if (flag)
                            {
                                str_dt += str1[j];
                            }
                            else
                                str_val += str1[j];

                            if (str_dt == str_fun)
                            {
                                sum += double.Parse(str_val);
                            }

                        }

                        if (str_dt != str_fun)
                        {
                            throw new System.ArgumentException(" U Select Wrong Column !! ");
                        }

                        flag = false;
                        str_val = "";
                        str_dt = "";

                        _countr++;

                        if (_countr == ds.Tables[i].Rows.Count)
                            break;
                    }

                }

                MessageBox.Show(sum.ToString());
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        ///////// Avg func ///////////////
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                DataSet ds2 = new DataSet();

                ds.ReadXml("Data.xml");
                ds2 = new DataSet();
                ds2.ReadXml("Dt.xml");

                string str_fun = ds2.Tables[0].Rows[0][0].ToString();
                string str_val = "";
                string str_dt = "";
                bool flag = false;

                string table_name = textBox3.Text;

                ds = new DataSet();

                ds.ReadXml("Data.xml");

                string col_name = textBox4.Text;

                double avg = 0;
                int _countr = 0;
                for (int i = 0; i < ds.Tables.Count; i++)
                {

                    while (ds.Tables[i].TableName == table_name)
                    {

                        string str1 = ds.Tables[i].Rows[_countr][col_name].ToString();

                        for (int j = 0; j < str1.Length; j++)
                        {
                            if (str1[j].ToString() == "-")
                            {
                                flag = true;
                                continue;
                            }
                            if (flag)
                            {
                                str_dt += str1[j];
                            }
                            else
                                str_val += str1[j];

                            if (str_dt == str_fun)
                            {
                                avg += double.Parse(str_val);
                            }

                        }

                        if (str_dt != str_fun)
                        {
                            throw new System.ArgumentException(" U Select Wrong Column !! ");
                        }

                        flag = false;
                        str_val = "";
                        str_dt = "";

                        _countr++;
                        if (_countr == ds.Tables[i].Rows.Count)
                            break;
                    }
                }
                avg = avg / _countr;

                MessageBox.Show(avg.ToString());
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }




}
