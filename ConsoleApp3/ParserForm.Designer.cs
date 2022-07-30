namespace ConsoleApp3
{
    partial class ParserForm
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textFirstFile = new System.Windows.Forms.TextBox();
            this.textSecondFile = new System.Windows.Forms.TextBox();
            this.textFinalDistan = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkedListDlg = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(51, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Начать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MOD 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MOD 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fim MOD";
            // 
            // textFirstFile
            // 
            this.textFirstFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFirstFile.Location = new System.Drawing.Point(72, 7);
            this.textFirstFile.Name = "textFirstFile";
            this.textFirstFile.Size = new System.Drawing.Size(321, 20);
            this.textFirstFile.TabIndex = 4;
            this.textFirstFile.DoubleClick += new System.EventHandler(this.OpenFileMode);
            // 
            // textSecondFile
            // 
            this.textSecondFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSecondFile.Location = new System.Drawing.Point(72, 33);
            this.textSecondFile.Name = "textSecondFile";
            this.textSecondFile.Size = new System.Drawing.Size(321, 20);
            this.textSecondFile.TabIndex = 5;
            this.textSecondFile.DoubleClick += new System.EventHandler(this.OpenFileMode);
            // 
            // textFinalDistan
            // 
            this.textFinalDistan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFinalDistan.Location = new System.Drawing.Point(72, 320);
            this.textFinalDistan.Name = "textFinalDistan";
            this.textFinalDistan.Size = new System.Drawing.Size(321, 20);
            this.textFinalDistan.TabIndex = 6;
            this.textFinalDistan.DoubleClick += new System.EventHandler(this.OpenFolder);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.fileName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.checkedListDlg);
            this.panel1.Controls.Add(this.textSecondFile);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textFinalDistan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textFirstFile);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 489);
            this.panel1.TabIndex = 7;
            // 
            // checkedListDlg
            // 
            this.checkedListDlg.FormattingEnabled = true;
            this.checkedListDlg.Location = new System.Drawing.Point(14, 88);
            this.checkedListDlg.Name = "checkedListDlg";
            this.checkedListDlg.Size = new System.Drawing.Size(378, 214);
            this.checkedListDlg.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(32, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(328, 53);
            this.button2.TabIndex = 8;
            this.button2.Text = "РАСПАКОВАТЬ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Выберите необходимые файлы";
            // 
            // fileName
            // 
            this.fileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileName.Location = new System.Drawing.Point(72, 346);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(320, 20);
            this.fileName.TabIndex = 10;
            this.fileName.Text = "MOD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Имя файла";
            // 
            // ParserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 489);
            this.Controls.Add(this.panel1);
            this.Name = "ParserForm";
            this.Text = "ParserForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textFirstFile;
        private System.Windows.Forms.TextBox textSecondFile;
        private System.Windows.Forms.TextBox textFinalDistan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox checkedListDlg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fileName;
    }
}