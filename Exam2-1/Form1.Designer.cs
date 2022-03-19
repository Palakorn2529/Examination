namespace Exam2_1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.TextBox();
            this.inputGroup = new System.Windows.Forms.GroupBox();
            this.lbSequence = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultGroup = new System.Windows.Forms.GroupBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.seachBtn = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.inputGroup.SuspendLayout();
            this.ResultGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exam2-1";
            // 
            // inputText
            // 
            this.inputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputText.Location = new System.Drawing.Point(70, 49);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(157, 24);
            this.inputText.TabIndex = 2;
            this.inputText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputText_KeyPress);
            // 
            // inputGroup
            // 
            this.inputGroup.Controls.Add(this.lbSequence);
            this.inputGroup.Controls.Add(this.refreshBtn);
            this.inputGroup.Controls.Add(this.saveBtn);
            this.inputGroup.Controls.Add(this.label3);
            this.inputGroup.Controls.Add(this.inputText);
            this.inputGroup.Location = new System.Drawing.Point(27, 73);
            this.inputGroup.Name = "inputGroup";
            this.inputGroup.Size = new System.Drawing.Size(311, 156);
            this.inputGroup.TabIndex = 3;
            this.inputGroup.TabStop = false;
            this.inputGroup.Text = "เก็บบันทึกข้อมูล";
            // 
            // lbSequence
            // 
            this.lbSequence.AutoSize = true;
            this.lbSequence.Location = new System.Drawing.Point(244, 54);
            this.lbSequence.Name = "lbSequence";
            this.lbSequence.Size = new System.Drawing.Size(46, 17);
            this.lbSequence.TabIndex = 6;
            this.lbSequence.Text = "label2";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(107, 117);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(95, 31);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.Text = "รีเฟรช";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(107, 79);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(95, 32);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "บันทึกข้อมูล";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "ใส่ข้อมูลเข้าระบบ (5 ครั้ง)";
            // 
            // ResultGroup
            // 
            this.ResultGroup.Controls.Add(this.lbResult);
            this.ResultGroup.Location = new System.Drawing.Point(27, 371);
            this.ResultGroup.Name = "ResultGroup";
            this.ResultGroup.Size = new System.Drawing.Size(311, 67);
            this.ResultGroup.TabIndex = 4;
            this.ResultGroup.TabStop = false;
            this.ResultGroup.Text = "ผลลัพธ์การค้นหา";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(16, 28);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(60, 24);
            this.lbResult.TabIndex = 0;
            this.lbResult.Text = "label2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.seachBtn);
            this.groupBox2.Controls.Add(this.searchText);
            this.groupBox2.Location = new System.Drawing.Point(27, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 130);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ข้อมูลที่ต้องการค้นหา";
            // 
            // seachBtn
            // 
            this.seachBtn.Location = new System.Drawing.Point(107, 62);
            this.seachBtn.Name = "seachBtn";
            this.seachBtn.Size = new System.Drawing.Size(95, 34);
            this.seachBtn.TabIndex = 1;
            this.seachBtn.Text = "ค้นหา";
            this.seachBtn.UseVisualStyleBackColor = true;
            this.seachBtn.Click += new System.EventHandler(this.seachBtn_Click);
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.Location = new System.Drawing.Point(70, 34);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(157, 24);
            this.searchText.TabIndex = 0;
            this.searchText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchText_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ResultGroup);
            this.Controls.Add(this.inputGroup);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam2-1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.inputGroup.ResumeLayout(false);
            this.inputGroup.PerformLayout();
            this.ResultGroup.ResumeLayout(false);
            this.ResultGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.GroupBox inputGroup;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox ResultGroup;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button seachBtn;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Label lbSequence;
    }
}

