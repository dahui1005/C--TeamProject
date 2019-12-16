namespace CSharpTeamProject
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFoundSelect = new System.Windows.Forms.Button();
            this.FoundGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.gbFoundSelect = new System.Windows.Forms.GroupBox();
            this.gbFoundUD = new System.Windows.Forms.GroupBox();
            this.cbUDType = new System.Windows.Forms.ComboBox();
            this.mtbUDFoundDate = new System.Windows.Forms.MaskedTextBox();
            this.cbUDFoundPlace = new System.Windows.Forms.ComboBox();
            this.tbUDStuId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbUDFoundId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.mtbFoundDate = new System.Windows.Forms.MaskedTextBox();
            this.cbFoundPlace = new System.Windows.Forms.ComboBox();
            this.tbStuId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFoundId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFoundInsert = new System.Windows.Forms.Button();
            this.btnFoundDelete = new System.Windows.Forms.Button();
            this.btnFoundUpdate = new System.Windows.Forms.Button();
            this.TypeGridView = new System.Windows.Forms.DataGridView();
            this.StudentGridView = new System.Windows.Forms.DataGridView();
            this.textSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.excelSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoundGridView)).BeginInit();
            this.gbFoundSelect.SuspendLayout();
            this.gbFoundUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(145, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1054, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lost And Found";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnFoundSelect
            // 
            this.btnFoundSelect.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFoundSelect.Location = new System.Drawing.Point(15, 182);
            this.btnFoundSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFoundSelect.Name = "btnFoundSelect";
            this.btnFoundSelect.Size = new System.Drawing.Size(242, 55);
            this.btnFoundSelect.TabIndex = 4;
            this.btnFoundSelect.Text = "습득물 조회";
            this.btnFoundSelect.UseVisualStyleBackColor = true;
            this.btnFoundSelect.Click += new System.EventHandler(this.btnFoundSelect_Click);
            // 
            // FoundGridView
            // 
            this.FoundGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FoundGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoundGridView.Location = new System.Drawing.Point(15, 245);
            this.FoundGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FoundGridView.Name = "FoundGridView";
            this.FoundGridView.RowHeadersWidth = 51;
            this.FoundGridView.RowTemplate.Height = 23;
            this.FoundGridView.Size = new System.Drawing.Size(491, 374);
            this.FoundGridView.TabIndex = 6;
            this.FoundGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FoundGridView_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(994, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 42);
            this.label2.TabIndex = 7;
            this.label2.Text = "2211 유정화님";
            // 
            // gbFoundSelect
            // 
            this.gbFoundSelect.Controls.Add(this.gbFoundUD);
            this.gbFoundSelect.Controls.Add(this.cbType);
            this.gbFoundSelect.Controls.Add(this.mtbFoundDate);
            this.gbFoundSelect.Controls.Add(this.cbFoundPlace);
            this.gbFoundSelect.Controls.Add(this.tbStuId);
            this.gbFoundSelect.Controls.Add(this.label7);
            this.gbFoundSelect.Controls.Add(this.label6);
            this.gbFoundSelect.Controls.Add(this.label5);
            this.gbFoundSelect.Controls.Add(this.label4);
            this.gbFoundSelect.Controls.Add(this.tbFoundId);
            this.gbFoundSelect.Controls.Add(this.label3);
            this.gbFoundSelect.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbFoundSelect.Location = new System.Drawing.Point(522, 182);
            this.gbFoundSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFoundSelect.Name = "gbFoundSelect";
            this.gbFoundSelect.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFoundSelect.Size = new System.Drawing.Size(438, 580);
            this.gbFoundSelect.TabIndex = 8;
            this.gbFoundSelect.TabStop = false;
            this.gbFoundSelect.Text = "습득물 조회 and 추가";
            // 
            // gbFoundUD
            // 
            this.gbFoundUD.Controls.Add(this.cbUDType);
            this.gbFoundUD.Controls.Add(this.mtbUDFoundDate);
            this.gbFoundUD.Controls.Add(this.cbUDFoundPlace);
            this.gbFoundUD.Controls.Add(this.tbUDStuId);
            this.gbFoundUD.Controls.Add(this.label8);
            this.gbFoundUD.Controls.Add(this.label9);
            this.gbFoundUD.Controls.Add(this.label10);
            this.gbFoundUD.Controls.Add(this.label11);
            this.gbFoundUD.Controls.Add(this.tbUDFoundId);
            this.gbFoundUD.Controls.Add(this.label12);
            this.gbFoundUD.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gbFoundUD.Location = new System.Drawing.Point(0, 0);
            this.gbFoundUD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFoundUD.Name = "gbFoundUD";
            this.gbFoundUD.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbFoundUD.Size = new System.Drawing.Size(438, 580);
            this.gbFoundUD.TabIndex = 13;
            this.gbFoundUD.TabStop = false;
            this.gbFoundUD.Text = "습득물 변경 and 제거";
            this.gbFoundUD.Visible = false;
            // 
            // cbUDType
            // 
            this.cbUDType.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbUDType.FormattingEnabled = true;
            this.cbUDType.Location = new System.Drawing.Point(13, 414);
            this.cbUDType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbUDType.Name = "cbUDType";
            this.cbUDType.Size = new System.Drawing.Size(418, 36);
            this.cbUDType.TabIndex = 12;
            // 
            // mtbUDFoundDate
            // 
            this.mtbUDFoundDate.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mtbUDFoundDate.Location = new System.Drawing.Point(13, 304);
            this.mtbUDFoundDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbUDFoundDate.Mask = "0000-00-00";
            this.mtbUDFoundDate.Name = "mtbUDFoundDate";
            this.mtbUDFoundDate.Size = new System.Drawing.Size(418, 35);
            this.mtbUDFoundDate.TabIndex = 11;
            this.mtbUDFoundDate.ValidatingType = typeof(System.DateTime);
            // 
            // cbUDFoundPlace
            // 
            this.cbUDFoundPlace.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbUDFoundPlace.FormattingEnabled = true;
            this.cbUDFoundPlace.Location = new System.Drawing.Point(13, 189);
            this.cbUDFoundPlace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbUDFoundPlace.Name = "cbUDFoundPlace";
            this.cbUDFoundPlace.Size = new System.Drawing.Size(418, 36);
            this.cbUDFoundPlace.TabIndex = 10;
            // 
            // tbUDStuId
            // 
            this.tbUDStuId.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbUDStuId.Location = new System.Drawing.Point(13, 522);
            this.tbUDStuId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUDStuId.Name = "tbUDStuId";
            this.tbUDStuId.Size = new System.Drawing.Size(418, 35);
            this.tbUDStuId.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(7, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 38);
            this.label8.TabIndex = 8;
            this.label8.Text = "stu_id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(7, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 38);
            this.label9.TabIndex = 6;
            this.label9.Text = "type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(7, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 38);
            this.label10.TabIndex = 4;
            this.label10.Text = "found_date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(7, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 38);
            this.label11.TabIndex = 2;
            this.label11.Text = "found_place";
            // 
            // tbUDFoundId
            // 
            this.tbUDFoundId.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbUDFoundId.Location = new System.Drawing.Point(13, 74);
            this.tbUDFoundId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUDFoundId.Name = "tbUDFoundId";
            this.tbUDFoundId.Size = new System.Drawing.Size(418, 35);
            this.tbUDFoundId.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(7, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 38);
            this.label12.TabIndex = 0;
            this.label12.Text = "found_id";
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(13, 414);
            this.cbType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(418, 36);
            this.cbType.TabIndex = 12;
            // 
            // mtbFoundDate
            // 
            this.mtbFoundDate.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mtbFoundDate.Location = new System.Drawing.Point(13, 304);
            this.mtbFoundDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mtbFoundDate.Mask = "0000-00-00";
            this.mtbFoundDate.Name = "mtbFoundDate";
            this.mtbFoundDate.Size = new System.Drawing.Size(418, 35);
            this.mtbFoundDate.TabIndex = 11;
            this.mtbFoundDate.ValidatingType = typeof(System.DateTime);
            // 
            // cbFoundPlace
            // 
            this.cbFoundPlace.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbFoundPlace.FormattingEnabled = true;
            this.cbFoundPlace.Location = new System.Drawing.Point(13, 189);
            this.cbFoundPlace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbFoundPlace.Name = "cbFoundPlace";
            this.cbFoundPlace.Size = new System.Drawing.Size(418, 36);
            this.cbFoundPlace.TabIndex = 10;
            // 
            // tbStuId
            // 
            this.tbStuId.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbStuId.Location = new System.Drawing.Point(13, 522);
            this.tbStuId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbStuId.Name = "tbStuId";
            this.tbStuId.Size = new System.Drawing.Size(418, 35);
            this.tbStuId.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(7, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 38);
            this.label7.TabIndex = 8;
            this.label7.Text = "stu_id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(7, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 38);
            this.label6.TabIndex = 6;
            this.label6.Text = "type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(7, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 38);
            this.label5.TabIndex = 4;
            this.label5.Text = "found_date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(7, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 38);
            this.label4.TabIndex = 2;
            this.label4.Text = "found_place";
            // 
            // tbFoundId
            // 
            this.tbFoundId.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbFoundId.Location = new System.Drawing.Point(13, 74);
            this.tbFoundId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbFoundId.Name = "tbFoundId";
            this.tbFoundId.Size = new System.Drawing.Size(418, 35);
            this.tbFoundId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(7, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "found_id";
            // 
            // btnFoundInsert
            // 
            this.btnFoundInsert.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFoundInsert.Location = new System.Drawing.Point(264, 182);
            this.btnFoundInsert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFoundInsert.Name = "btnFoundInsert";
            this.btnFoundInsert.Size = new System.Drawing.Size(242, 55);
            this.btnFoundInsert.TabIndex = 5;
            this.btnFoundInsert.Text = "습득물 추가";
            this.btnFoundInsert.UseVisualStyleBackColor = true;
            this.btnFoundInsert.Click += new System.EventHandler(this.btnFoundInsert_Click);
            // 
            // btnFoundDelete
            // 
            this.btnFoundDelete.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFoundDelete.Location = new System.Drawing.Point(264, 182);
            this.btnFoundDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFoundDelete.Name = "btnFoundDelete";
            this.btnFoundDelete.Size = new System.Drawing.Size(242, 55);
            this.btnFoundDelete.TabIndex = 9;
            this.btnFoundDelete.Text = "습득물 삭제";
            this.btnFoundDelete.UseVisualStyleBackColor = true;
            this.btnFoundDelete.Visible = false;
            this.btnFoundDelete.Click += new System.EventHandler(this.btnFoundDelete_Click);
            // 
            // btnFoundUpdate
            // 
            this.btnFoundUpdate.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnFoundUpdate.Location = new System.Drawing.Point(14, 182);
            this.btnFoundUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFoundUpdate.Name = "btnFoundUpdate";
            this.btnFoundUpdate.Size = new System.Drawing.Size(242, 55);
            this.btnFoundUpdate.TabIndex = 10;
            this.btnFoundUpdate.Text = "습득물 변경";
            this.btnFoundUpdate.UseVisualStyleBackColor = true;
            this.btnFoundUpdate.Visible = false;
            this.btnFoundUpdate.Click += new System.EventHandler(this.btnFoundUpdate_Click);
            // 
            // TypeGridView
            // 
            this.TypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TypeGridView.Location = new System.Drawing.Point(967, 182);
            this.TypeGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TypeGridView.Name = "TypeGridView";
            this.TypeGridView.RowHeadersWidth = 51;
            this.TypeGridView.RowTemplate.Height = 23;
            this.TypeGridView.Size = new System.Drawing.Size(232, 580);
            this.TypeGridView.TabIndex = 11;
            // 
            // StudentGridView
            // 
            this.StudentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.StudentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView.Location = new System.Drawing.Point(15, 627);
            this.StudentGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StudentGridView.Name = "StudentGridView";
            this.StudentGridView.RowHeadersWidth = 51;
            this.StudentGridView.RowTemplate.Height = 23;
            this.StudentGridView.Size = new System.Drawing.Size(491, 71);
            this.StudentGridView.TabIndex = 12;
            // 
            // textSave
            // 
            this.textSave.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 18F, System.Drawing.FontStyle.Bold);
            this.textSave.Location = new System.Drawing.Point(15, 705);
            this.textSave.Name = "textSave";
            this.textSave.Size = new System.Drawing.Size(241, 57);
            this.textSave.TabIndex = 13;
            this.textSave.Text = "Text";
            this.textSave.UseVisualStyleBackColor = true;
            this.textSave.Click += new System.EventHandler(this.textSave_Click);
            // 
            // excelSave
            // 
            this.excelSave.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 18F, System.Drawing.FontStyle.Bold);
            this.excelSave.Location = new System.Drawing.Point(264, 705);
            this.excelSave.Name = "excelSave";
            this.excelSave.Size = new System.Drawing.Size(242, 57);
            this.excelSave.TabIndex = 14;
            this.excelSave.Text = "Excel";
            this.excelSave.UseVisualStyleBackColor = true;
            this.excelSave.Click += new System.EventHandler(this.excelSave_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 778);
            this.Controls.Add(this.excelSave);
            this.Controls.Add(this.textSave);
            this.Controls.Add(this.StudentGridView);
            this.Controls.Add(this.TypeGridView);
            this.Controls.Add(this.btnFoundUpdate);
            this.Controls.Add(this.btnFoundDelete);
            this.Controls.Add(this.gbFoundSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FoundGridView);
            this.Controls.Add(this.btnFoundInsert);
            this.Controls.Add(this.btnFoundSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoundGridView)).EndInit();
            this.gbFoundSelect.ResumeLayout(false);
            this.gbFoundSelect.PerformLayout();
            this.gbFoundUD.ResumeLayout(false);
            this.gbFoundUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFoundSelect;
        private System.Windows.Forms.DataGridView FoundGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbFoundSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.MaskedTextBox mtbFoundDate;
        private System.Windows.Forms.ComboBox cbFoundPlace;
        private System.Windows.Forms.TextBox tbStuId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFoundId;
        private System.Windows.Forms.Button btnFoundInsert;
        private System.Windows.Forms.GroupBox gbFoundUD;
        private System.Windows.Forms.ComboBox cbUDType;
        private System.Windows.Forms.MaskedTextBox mtbUDFoundDate;
        private System.Windows.Forms.ComboBox cbUDFoundPlace;
        private System.Windows.Forms.TextBox tbUDStuId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbUDFoundId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnFoundDelete;
        private System.Windows.Forms.Button btnFoundUpdate;
        private System.Windows.Forms.DataGridView TypeGridView;
        private System.Windows.Forms.DataGridView StudentGridView;
        private System.Windows.Forms.Button textSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button excelSave;
    }
}