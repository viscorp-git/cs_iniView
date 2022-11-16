namespace IniView
{
    partial class IniView_F1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exposure1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Exposure2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkSpacePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stream = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edtIniDir = new System.Windows.Forms.TextBox();
            this.btnIniDir = new System.Windows.Forms.Button();
            this.btnIniLoad = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.edtFilename = new System.Windows.Forms.TextBox();
            this.edtExposure1 = new System.Windows.Forms.TextBox();
            this.edtExposure2 = new System.Windows.Forms.TextBox();
            this.edtChannel1 = new System.Windows.Forms.TextBox();
            this.edtChannel2 = new System.Windows.Forms.TextBox();
            this.edtWorkspace = new System.Windows.Forms.TextBox();
            this.edtStream = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAllSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filename,
            this.Exposure1,
            this.Exposure2,
            this.Channel1,
            this.Channel2,
            this.WorkSpacePath,
            this.Stream});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(978, 508);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // filename
            // 
            this.filename.HeaderText = "Filename";
            this.filename.MinimumWidth = 6;
            this.filename.Name = "filename";
            this.filename.Width = 200;
            // 
            // Exposure1
            // 
            this.Exposure1.HeaderText = "Exposure1";
            this.Exposure1.Name = "Exposure1";
            // 
            // Exposure2
            // 
            this.Exposure2.HeaderText = "Exposure2";
            this.Exposure2.Name = "Exposure2";
            // 
            // Channel1
            // 
            this.Channel1.HeaderText = "Channel1";
            this.Channel1.Name = "Channel1";
            // 
            // Channel2
            // 
            this.Channel2.HeaderText = "Channel2";
            this.Channel2.Name = "Channel2";
            // 
            // WorkSpacePath
            // 
            this.WorkSpacePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WorkSpacePath.HeaderText = "WorkSpacePath";
            this.WorkSpacePath.Name = "WorkSpacePath";
            // 
            // Stream
            // 
            this.Stream.HeaderText = "Stream";
            this.Stream.Name = "Stream";
            // 
            // edtIniDir
            // 
            this.edtIniDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtIniDir.Location = new System.Drawing.Point(100, 3);
            this.edtIniDir.Name = "edtIniDir";
            this.edtIniDir.Size = new System.Drawing.Size(776, 21);
            this.edtIniDir.TabIndex = 14;
            // 
            // btnIniDir
            // 
            this.btnIniDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIniDir.Location = new System.Drawing.Point(3, 3);
            this.btnIniDir.Name = "btnIniDir";
            this.btnIniDir.Size = new System.Drawing.Size(91, 23);
            this.btnIniDir.TabIndex = 13;
            this.btnIniDir.Text = "Dir Change";
            this.btnIniDir.UseVisualStyleBackColor = true;
            this.btnIniDir.Click += new System.EventHandler(this.btnIniDir_Click);
            // 
            // btnIniLoad
            // 
            this.btnIniLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIniLoad.Location = new System.Drawing.Point(882, 3);
            this.btnIniLoad.Name = "btnIniLoad";
            this.btnIniLoad.Size = new System.Drawing.Size(93, 23);
            this.btnIniLoad.TabIndex = 12;
            this.btnIniLoad.Text = "Ini Load";
            this.btnIniLoad.UseVisualStyleBackColor = true;
            this.btnIniLoad.Click += new System.EventHandler(this.btnIniLoad_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(984, 602);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.btnIniLoad, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnIniDir, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.edtIniDir, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(978, 29);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(978, 54);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 7;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel4.Controls.Add(this.label7, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.label6, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.edtFilename, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.edtExposure1, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.edtExposure2, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.edtChannel1, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.edtChannel2, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.edtWorkspace, 5, 1);
            this.tableLayoutPanel4.Controls.Add(this.edtStream, 6, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(874, 48);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(802, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Stream";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(453, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(343, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "WorkSpacePath";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(384, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Channel 2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(315, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Channel 1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(246, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Exposure 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(177, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Exposure 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // edtFilename
            // 
            this.edtFilename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtFilename.Location = new System.Drawing.Point(3, 27);
            this.edtFilename.Name = "edtFilename";
            this.edtFilename.Size = new System.Drawing.Size(168, 21);
            this.edtFilename.TabIndex = 0;
            // 
            // edtExposure1
            // 
            this.edtExposure1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtExposure1.Location = new System.Drawing.Point(177, 27);
            this.edtExposure1.Name = "edtExposure1";
            this.edtExposure1.Size = new System.Drawing.Size(63, 21);
            this.edtExposure1.TabIndex = 1;
            // 
            // edtExposure2
            // 
            this.edtExposure2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtExposure2.Location = new System.Drawing.Point(246, 27);
            this.edtExposure2.Name = "edtExposure2";
            this.edtExposure2.Size = new System.Drawing.Size(63, 21);
            this.edtExposure2.TabIndex = 2;
            // 
            // edtChannel1
            // 
            this.edtChannel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtChannel1.Location = new System.Drawing.Point(315, 27);
            this.edtChannel1.Name = "edtChannel1";
            this.edtChannel1.Size = new System.Drawing.Size(63, 21);
            this.edtChannel1.TabIndex = 3;
            // 
            // edtChannel2
            // 
            this.edtChannel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtChannel2.Location = new System.Drawing.Point(384, 27);
            this.edtChannel2.Name = "edtChannel2";
            this.edtChannel2.Size = new System.Drawing.Size(63, 21);
            this.edtChannel2.TabIndex = 4;
            // 
            // edtWorkspace
            // 
            this.edtWorkspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtWorkspace.Location = new System.Drawing.Point(453, 27);
            this.edtWorkspace.Name = "edtWorkspace";
            this.edtWorkspace.Size = new System.Drawing.Size(343, 21);
            this.edtWorkspace.TabIndex = 5;
            // 
            // edtStream
            // 
            this.edtStream.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtStream.Location = new System.Drawing.Point(802, 27);
            this.edtStream.Name = "edtStream";
            this.edtStream.Size = new System.Drawing.Size(69, 21);
            this.edtStream.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "FileName";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIniSave
            // 
            this.btnIniSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIniSave.Location = new System.Drawing.Point(3, 3);
            this.btnIniSave.Name = "btnIniSave";
            this.btnIniSave.Size = new System.Drawing.Size(92, 21);
            this.btnIniSave.TabIndex = 1;
            this.btnIniSave.Text = "ini Save";
            this.btnIniSave.UseVisualStyleBackColor = true;
            this.btnIniSave.Click += new System.EventHandler(this.btnIniSave_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btnIniSave, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnAllSave, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(880, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(98, 54);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // btnAllSave
            // 
            this.btnAllSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAllSave.Location = new System.Drawing.Point(3, 30);
            this.btnAllSave.Name = "btnAllSave";
            this.btnAllSave.Size = new System.Drawing.Size(92, 21);
            this.btnAllSave.TabIndex = 1;
            this.btnAllSave.Text = "All Save";
            this.btnAllSave.UseVisualStyleBackColor = true;
            this.btnAllSave.Click += new System.EventHandler(this.btnAllSave_Click);
            // 
            // IniView_F1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 602);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "IniView_F1";
            this.Text = "Ini View";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox edtIniDir;
        private System.Windows.Forms.Button btnIniDir;
        private System.Windows.Forms.Button btnIniLoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exposure1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Exposure2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkSpacePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stream;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox edtFilename;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtExposure1;
        private System.Windows.Forms.TextBox edtExposure2;
        private System.Windows.Forms.TextBox edtChannel1;
        private System.Windows.Forms.TextBox edtChannel2;
        private System.Windows.Forms.TextBox edtWorkspace;
        private System.Windows.Forms.TextBox edtStream;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnAllSave;
    }
}

