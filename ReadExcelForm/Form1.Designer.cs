
namespace ReadExcelForm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.textList = new System.Windows.Forms.TextBox();
            this.readButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowerButton = new System.Windows.Forms.Button();
            this.textFolder = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.copyButton1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.copyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pageNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pageNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // textList
            // 
            this.textList.Location = new System.Drawing.Point(27, 61);
            this.textList.Multiline = true;
            this.textList.Name = "textList";
            this.textList.ReadOnly = true;
            this.textList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textList.Size = new System.Drawing.Size(262, 431);
            this.textList.TabIndex = 0;
            // 
            // readButton
            // 
            this.readButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.readButton.Location = new System.Drawing.Point(330, 382);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(90, 38);
            this.readButton.TabIndex = 1;
            this.readButton.Text = "Copy";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // folderBrowerButton
            // 
            this.folderBrowerButton.Location = new System.Drawing.Point(744, 88);
            this.folderBrowerButton.Name = "folderBrowerButton";
            this.folderBrowerButton.Size = new System.Drawing.Size(38, 23);
            this.folderBrowerButton.TabIndex = 2;
            this.folderBrowerButton.Text = "...";
            this.folderBrowerButton.UseVisualStyleBackColor = true;
            this.folderBrowerButton.Click += new System.EventHandler(this.folderBrowerButton_Click);
            // 
            // textFolder
            // 
            this.textFolder.Location = new System.Drawing.Point(334, 88);
            this.textFolder.Name = "textFolder";
            this.textFolder.Size = new System.Drawing.Size(404, 23);
            this.textFolder.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // copyButton1
            // 
            this.copyButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyButton1.Location = new System.Drawing.Point(330, 299);
            this.copyButton1.Name = "copyButton1";
            this.copyButton1.Size = new System.Drawing.Size(90, 38);
            this.copyButton1.TabIndex = 7;
            this.copyButton1.Text = "Read";
            this.copyButton1.UseVisualStyleBackColor = true;
            this.copyButton1.Click += new System.EventHandler(this.readButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // copyLabel
            // 
            this.copyLabel.AutoSize = true;
            this.copyLabel.Location = new System.Drawing.Point(330, 423);
            this.copyLabel.Name = "copyLabel";
            this.copyLabel.Size = new System.Drawing.Size(45, 15);
            this.copyLabel.TabIndex = 8;
            this.copyLabel.Text = "Copied";
            this.copyLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(330, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Folder:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(330, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Page:";
            // 
            // pageNumber
            // 
            this.pageNumber.Location = new System.Drawing.Point(380, 194);
            this.pageNumber.Name = "pageNumber";
            this.pageNumber.Size = new System.Drawing.Size(120, 23);
            this.pageNumber.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.pageNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copyLabel);
            this.Controls.Add(this.copyButton1);
            this.Controls.Add(this.textFolder);
            this.Controls.Add(this.folderBrowerButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.textList);
            this.Name = "Form1";
            this.Text = "Reading Excel";
            ((System.ComponentModel.ISupportInitialize)(this.pageNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textList;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button folderBrowerButton;
        private System.Windows.Forms.TextBox textFolder;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button copyButton1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label copyLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown pageNumber;
    }
}

