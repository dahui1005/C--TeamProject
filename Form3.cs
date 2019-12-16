using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpTeamProject
{
    public partial class Form3 : Form
    {
        string stu_id, stu_name;

        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;

        public Form3(string stu_id, string stu_name)
        {
            InitializeComponent();
            this.stu_id = stu_id;
            this.stu_name = stu_name;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(stu_id, stu_name);
            form2.Show();

            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;database=lost_n_found;uid=root;pwd=dlaekgml;allow user variables=true;";
            conn = new MySqlConnection(connStr);
            dataAdapter = new MySqlDataAdapter("SELECT * FROM found", conn);
            dataSet = new DataSet();

            string queryStr = "SELECT * FROM student WHERE stu_id = @stu_id AND stu_name = @stu_name";
            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.Add("@stu_id", MySqlDbType.Int32);
            dataAdapter.SelectCommand.Parameters.Add("@stu_name", MySqlDbType.VarChar);
            
            dataAdapter.SelectCommand.Parameters["@stu_id"].Value = stu_id;
            dataAdapter.SelectCommand.Parameters["@stu_name"].Value = stu_name;

            try
            {
                conn.Open();
                dataSet.Clear();                                        // 이전 데이터 지우기
                if (dataAdapter.Fill(dataSet, "student") > 0)
                    StuGridView.DataSource = dataSet.Tables["student"];
                else
                {
                    MessageBox.Show("찾는 데이터가 없습니다.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
