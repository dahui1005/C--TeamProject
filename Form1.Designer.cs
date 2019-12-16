namespace CSharpTeamProject
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStuId = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStuSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tmon몬소리 Black", 28F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(128, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lost And Found";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "학번";
            // 
            // tbStuId
            // 
            this.tbStuId.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 13F, System.Drawing.FontStyle.Bold);
            this.tbStuId.Location = new System.Drawing.Point(12, 175);
            this.tbStuId.Name = "tbStuId";
            this.tbStuId.Size = new System.Drawing.Size(254, 32);
            this.tbStuId.TabIndex = 3;
            this.tbStuId.Text = "예) 2201";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 13F, System.Drawing.FontStyle.Bold);
            this.tbName.Location = new System.Drawing.Point(12, 247);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(254, 32);
            this.tbName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "이름";
            // 
            // btnStuSelect
            // 
            this.btnStuSelect.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStuSelect.Location = new System.Drawing.Point(281, 144);
            this.btnStuSelect.Name = "btnStuSelect";
            this.btnStuSelect.Size = new System.Drawing.Size(152, 135);
            this.btnStuSelect.TabIndex = 11;
            this.btnStuSelect.Text = "학생 조회";
            this.btnStuSelect.UseVisualStyleBackColor = true;
            this.btnStuSelect.Click += new System.EventHandler(this.btnStuSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 298);
            this.Controls.Add(this.btnStuSelect);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbStuId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStuId;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStuSelect;
    }
}

