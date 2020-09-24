namespace AD工程创建App
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveDir = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTemplate = new System.Windows.Forms.Label();
            this.lblStore = new System.Windows.Forms.Label();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPreview = new System.Windows.Forms.Label();
            this.picBPreview = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPara = new System.Windows.Forms.Label();
            this.btnDelPara = new System.Windows.Forms.Button();
            this.btnAddPara = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ParaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParaVale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBPreview)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSaveDir);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblTemplate);
            this.panel1.Controls.Add(this.lblStore);
            this.panel1.Controls.Add(this.lblProjectName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 112);
            this.panel1.TabIndex = 0;
            // 
            // btnSaveDir
            // 
            this.btnSaveDir.Location = new System.Drawing.Point(680, 46);
            this.btnSaveDir.Name = "btnSaveDir";
            this.btnSaveDir.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDir.TabIndex = 4;
            this.btnSaveDir.Text = "…";
            this.btnSaveDir.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(660, 25);
            this.comboBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(579, 23);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(660, 23);
            this.textBox1.TabIndex = 3;
            // 
            // lblTemplate
            // 
            this.lblTemplate.AutoSize = true;
            this.lblTemplate.Location = new System.Drawing.Point(21, 79);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.Size = new System.Drawing.Size(68, 17);
            this.lblTemplate.TabIndex = 2;
            this.lblTemplate.Text = "项目模板：";
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Location = new System.Drawing.Point(21, 49);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(68, 17);
            this.lblStore.TabIndex = 1;
            this.lblStore.Text = "存储目录：";
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(21, 20);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(68, 17);
            this.lblProjectName.TabIndex = 0;
            this.lblProjectName.Text = "项目名称：";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblPreview);
            this.panel2.Controls.Add(this.picBPreview);
            this.panel2.Location = new System.Drawing.Point(12, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 247);
            this.panel2.TabIndex = 1;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(9, 12);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(56, 17);
            this.lblPreview.TabIndex = 1;
            this.lblPreview.Text = "层叠预览";
            // 
            // picBPreview
            // 
            this.picBPreview.Location = new System.Drawing.Point(9, 32);
            this.picBPreview.Name = "picBPreview";
            this.picBPreview.Size = new System.Drawing.Size(276, 206);
            this.picBPreview.TabIndex = 0;
            this.picBPreview.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblPara);
            this.panel3.Controls.Add(this.btnDelPara);
            this.panel3.Controls.Add(this.btnAddPara);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Location = new System.Drawing.Point(316, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 247);
            this.panel3.TabIndex = 2;
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Location = new System.Drawing.Point(13, 12);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(80, 17);
            this.lblPara.TabIndex = 3;
            this.lblPara.Text = "全局参数设置";
            // 
            // btnDelPara
            // 
            this.btnDelPara.Location = new System.Drawing.Point(394, 220);
            this.btnDelPara.Name = "btnDelPara";
            this.btnDelPara.Size = new System.Drawing.Size(57, 23);
            this.btnDelPara.TabIndex = 2;
            this.btnDelPara.Text = "删除";
            this.btnDelPara.UseVisualStyleBackColor = true;
            // 
            // btnAddPara
            // 
            this.btnAddPara.Location = new System.Drawing.Point(313, 220);
            this.btnAddPara.Name = "btnAddPara";
            this.btnAddPara.Size = new System.Drawing.Size(75, 23);
            this.btnAddPara.TabIndex = 1;
            this.btnAddPara.Text = "增加";
            this.btnAddPara.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParaName,
            this.ParaVale});
            this.dataGridView2.Location = new System.Drawing.Point(13, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(438, 182);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.Text = "dataGridView2";
            // 
            // ParaName
            // 
            this.ParaName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ParaName.HeaderText = "Name";
            this.ParaName.Name = "ParaName";
            this.ParaName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ParaVale
            // 
            this.ParaVale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ParaVale.HeaderText = "Value";
            this.ParaVale.Name = "ParaVale";
            this.ParaVale.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(533, 384);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "确认";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(629, 384);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "AltiumDesigner项目快速创建";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBPreview)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSaveDir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTemplate;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picBPreview;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParaVale;
        private System.Windows.Forms.Button btnDelPara;
        private System.Windows.Forms.Button btnAddPara;
        private System.Windows.Forms.Label lblPara;
    }
}

