using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CSharpTeamProject
{
    public partial class Form2 : Form
    {
        string stu_id, stu_name;
        string fsPath = "";         // 저장할 파일 경로 저장


        public Form2(string stu_id, string stu_name)
        {
            InitializeComponent();
            this.stu_id = stu_id;
            this.stu_name = stu_name;
        }

        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;
        int selectedRowIndex;
        DataGridViewRow row;

        private void Form2_Load(object sender, EventArgs e)
        {
            string connStr = "server=localhost;port=3306;database=lost_n_found;uid=root;pwd=dlaekgml;allow user variables=true;";
            conn = new MySqlConnection(connStr);

            dataAdapter = new MySqlDataAdapter("SELECT * FROM type", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "type");
            TypeGridView.DataSource = dataSet.Tables["type"];

            dataAdapter = new MySqlDataAdapter("SELECT * FROM found", conn);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "found");
            FoundGridView.DataSource = dataSet.Tables["found"];

            

            SetSearchComboBox();

            label2.Text = stu_id + " " + stu_name + "님";
        }

        private void SetSearchComboBox()
        {
            string sql = "SELECT distinct found_place FROM found";
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                // publisher 목록 표시
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    cbFoundPlace.Items.Add(reader.GetString("found_place"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            sql = "SELECT distinct type_id FROM type";
            cmd = new MySqlCommand(sql, conn);

            try
            {
                // publisher 목록 표시
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())  // 다음 레코드가 있으면 true
                {
                    cbType.Items.Add(reader.GetString("type_id"));
                }
                reader.Close();
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

        private void btnFoundInsert_Click(object sender, EventArgs e)
        {
            string idSelectSql = "SELECT found_id FROM found ORDER BY found_id DESC LIMIT 1";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(idSelectSql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int id = (int)reader["found_id"];
            reader.Close();
            conn.Close();

            string queryStr = "INSERT INTO found (found_id, found_place, found_date, type_id, stu_id) " +
            "VALUES(@found_id, @found_place, @found_date, @type_id, @stu_id)";
            dataAdapter.InsertCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.InsertCommand.Parameters.Add("@found_id", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@found_place", MySqlDbType.VarChar);
            dataAdapter.InsertCommand.Parameters.Add("@found_date", MySqlDbType.Date);
            dataAdapter.InsertCommand.Parameters.Add("@type_id", MySqlDbType.Int32);
            dataAdapter.InsertCommand.Parameters.Add("@stu_id", MySqlDbType.Int32);

            dataAdapter.InsertCommand.Parameters["@found_id"].Value = ++id;
            dataAdapter.InsertCommand.Parameters["@found_place"].Value = cbFoundPlace.Text;
            dataAdapter.InsertCommand.Parameters["@found_date"].Value = mtbFoundDate.Text;
            dataAdapter.InsertCommand.Parameters["@type_id"].Value = cbType.Text;
            dataAdapter.InsertCommand.Parameters["@stu_id"].Value = stu_id;

            try
            {
                conn.Open();
                dataAdapter.InsertCommand.ExecuteNonQuery();
                dataSet.Clear();
                dataAdapter.Fill(dataSet, "found");
                FoundGridView.DataSource = dataSet.Tables["found"];
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

        private void Dataset(string sql)
        {
            try
            {
                conn.Open();
                if (sql == "Insert")
                    dataAdapter.InsertCommand.ExecuteNonQuery();
                else if (sql == "Update")
                    dataAdapter.UpdateCommand.ExecuteNonQuery();
                else
                    dataAdapter.DeleteCommand.ExecuteNonQuery();
                dataSet.Clear();
                dataAdapter.Fill(dataSet, "found");
                FoundGridView.DataSource = dataSet.Tables["found"];
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

        private void FoundGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
            row = FoundGridView.Rows[selectedRowIndex];

            if (row.Cells[4].Value.ToString() == stu_id)
            {
                btnFoundDelete.Visible = true;
                btnFoundUpdate.Visible = true;
                gbFoundUD.Visible = true;

                tbUDFoundId.Text = row.Cells[0].Value.ToString();
                cbUDFoundPlace.Text = row.Cells[1].Value.ToString();
                mtbUDFoundDate.Text =  row.Cells[2].Value.ToString();
                cbUDType.Text = row.Cells[3].Value.ToString();
                tbUDStuId.Text = row.Cells[4].Value.ToString();
            }
            else
            {
                string queryStr;

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter("SELECT * FROM student", conn);
                DataSet dataSet = new DataSet();

                queryStr = $"SELECT * FROM student WHERE stu_id = " + row.Cells[4].Value.ToString();
                dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);

                try
                {
                    conn.Open();
                    dataSet.Clear();
                    dataAdapter.Fill(dataSet, "student");
                    StudentGridView.DataSource = dataSet.Tables["student"];
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

        private void btnFoundUpdate_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE found SET found_place=@found_place, found_date=@found_date, type_id=@type_id, stu_id=@stu_id WHERE found_id=@found_id";
            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@found_id", row.Cells[0].Value.ToString());
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@found_place", cbUDFoundPlace.Text);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@found_date", mtbUDFoundDate.Text);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@type_id", cbUDType.Text);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@stu_id", tbUDStuId.Text);

            Dataset("Update");

            btnFoundDelete.Visible = false;
            btnFoundUpdate.Visible = false;
            gbFoundUD.Visible = false;
        }

        private void btnFoundDelete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM found WHERE found_id=@found_id";
            dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@found_id", row.Cells[0].Value.ToString());

            Dataset("Delete");

            btnFoundDelete.Visible = false;
            btnFoundUpdate.Visible = false;
            gbFoundUD.Visible = false;
        }

        private void textSave_Click(object sender, EventArgs e)
        {

            if (FoundGridView.RowCount == 0)
            {
                MessageBox.Show("저장할 파일 정보가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            saveFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fsPath = saveFileDialog1.FileName;  // SaveFileDialog에 지정한 파일경로를 전역 변수인 fsPath에 저장
                                                    // SaveFileDialog에 지정한 파일경로에 Stream 생성
                using (StreamWriter sw = new StreamWriter(fsPath))
                {
                    // Column Title 한번 출력
                    foreach (DataColumn col in dataSet.Tables["found"].Columns)
                    {
                        sw.Write($"{col.ColumnName}\t");
                    }
                    sw.WriteLine();

                    // DataGridView에 기록된 모든 파일 정보를 Text파일에 출력
                    foreach (DataRow row in dataSet.Tables["found"].Rows)
                    {
                        string rowString = "";
                        foreach (var item in row.ItemArray)
                        {
                            rowString += item.ToString() + "\t";
                        }
                        sw.WriteLine(rowString);
                    }
                    sw.Close();
                }
            }

        }

        private void excelSave_Click(object sender, EventArgs e)
        {

            if (FoundGridView.RowCount == 0)
            {
                MessageBox.Show("저장할 파일 정보가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            saveFileDialog1.Filter = "엑셀 파일(*.xlsx)|*.xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fsPath = saveFileDialog1.FileName;

                #region 1. 엑셀 사용에 필요한 객체 생성
                // 엑셀을 사용하기 위한 클래스 객체 생성
                Excel.Application eApp;     // 엑셀 프로그램 
                Excel.Workbook eWorkbook;   // 여러 WorkSheet 포함한 단위
                Excel.Worksheet eWorkSheet;

                string[,] data;     // 엑셀에 데이터를 저장하기 위한 2차원 배열

                eApp = new Excel.Application();         // 엑셀 프로그램 객체 생성
                eWorkbook = eApp.Workbooks.Add(true);   // 엑셀에 Workbook 추가, 초기화
                eWorkSheet = eWorkbook.Sheets[1] as Excel.Worksheet;    // WorkSheet 생성, Excel Sheet 배열은 1부터 시작한다.
                #endregion

                #region 2. 엑셀에 데이터를 저장할 2차원 데이터 배열(data[,]) 준비
                // 엑셀에 저장할 데이터 크기 지정
                int cnum = dataSet.Tables["found"].Columns.Count + 1;
                int rnum = dataSet.Tables["found"].Rows.Count + 1;
                data = new string[rnum + 1, cnum + 1];

                // 엑셀에 저장할 2차원 배열에 Column 이름 저장
                for (int i = 0; i < dataSet.Tables["found"].Columns.Count; i++)
                {
                    data[0, i] = dataSet.Tables["found"].Columns[i].ColumnName;
                }

                // 엑셀에 저장할 2차원 배열에 데이터 저장
                for (int i = 0; i < dataSet.Tables["found"].Rows.Count; i++)                    // 리스트뷰의 행수만큼 반복
                {
                    for (int j = 0; j < dataSet.Tables["found"].Columns.Count; j++)    // 한 행의 열수만큼 반복
                    {
                        data[i + 1, j] = dataSet.Tables["found"].Rows[i].ItemArray[j].ToString();    // data 배열에 데이터 저장
                    }
                }
                #endregion

                #region 3. 준비된 데이터를 엑셀에 저장
                //string EndStr = "F" + rnum.ToString();      // 8개의 파일을 선택한 경우 F9 => 마지막 데이터 저장셀 주소
                string EndStr = Convert.ToChar(cnum - 2 + 65) + rnum.ToString();      // 8개의 파일을 선택한 경우 F9 => 마지막 데이터 저장셀 주소
                eWorkSheet.get_Range("A1:" + EndStr).Value = data;     // 데이터 기록

                eWorkbook.SaveAs(fsPath, Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, false, false,
                    Excel.XlSaveAsAccessMode.xlShared, false, false, Type.Missing, Type.Missing, Type.Missing);
                eWorkbook.Close(false, Type.Missing, Type.Missing);
                eApp.Quit();
                #endregion
            }
        }

        private void btnFoundSelect_Click(object sender, EventArgs e)
        {
            string queryStr;
            
            string[] conditions = new string[5];
            conditions[0] = (tbFoundId.Text != "") ? "found_id=@found_id" : null;
            conditions[1] = (cbFoundPlace.Text != "") ? "found_place=@found_place" : null;
            conditions[2] = (mtbFoundDate.Text != "    -  -") ? "found_date=@found_date" : null;
            conditions[3] = (cbType.Text != "") ? "type_id=@type_id" : null;
            conditions[4] = (tbStuId.Text != "") ? "stu_id=@stu_id" : null;

            if (conditions[0] != null || conditions[1] != null || conditions[2] != null || conditions[3] != null || conditions[4] != null)
            {
                queryStr = $"SELECT * FROM found WHERE ";
                bool firstCondition = true;
                for (int i = 0; i < conditions.Length; i++)
                {
                    if (conditions[i] != null)
                        if (firstCondition)
                        {
                            queryStr += conditions[i];
                            firstCondition = false;
                        }
                        else
                        {
                            queryStr += " and " + conditions[i];
                        }
                }
            }
            else
            {
                queryStr = "SELECT * FROM found";
            }

            dataAdapter.SelectCommand = new MySqlCommand(queryStr, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@found_id", tbFoundId.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@found_place", cbFoundPlace.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@found_date", mtbFoundDate.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@type_id", cbType.Text);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@stu_id", tbStuId.Text);

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "found") > 0)
                    FoundGridView.DataSource = dataSet.Tables["found"];
                else
                    MessageBox.Show("찾는 데이터가 없습니다.");
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
