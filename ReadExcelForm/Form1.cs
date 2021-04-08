using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadExcelForm
{
    public partial class Form1 : Form
    {
        SoundPlayer sound = new(@"C:\Windows\Media\Windows Background.wav");

        public Form1()
        {
            InitializeComponent();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            textList.Text = null;
            if (textFolder.Text.Contains(".xlsx"))
            {
                WireUpListAsync((int)(pageNumber.Value));
            }
            else
            {
                sound.Play();
                MessageBox.Show("Invalid Directory");
            }
        }
        private void copyButton_Click(object sender, EventArgs e)
        {
            if (textList.Text != "")
            {
                Clipboard.SetText(textList.Text);
                copyLabel.Visible = true;
                copyLabel.ForeColor = Color.Black;
                timer1.Start();
            }
            else
            {
                try
                {
                    sound.Play();
                }
                catch { }
                MessageBox.Show("Nothing On The List.");
            }
        }

        private async Task WireUpListAsync(int worksheet)
        {
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            var file = new FileInfo(textFolder.Text);

            List<ExcelData> output = new();

            using var package = new ExcelPackage(file);

            await package.LoadAsync(file);

            var ws = package.Workbook.Worksheets[worksheet];

            int row = 1;
            int col = 2;

            while (string.IsNullOrWhiteSpace(ws.Cells[row, col].Value?.ToString()) == false)
            {
                if(int.Parse(ws.Cells[row + 1, col].Value.ToString()) > 0)
                {
                    textList.Text += ($"{ws.Cells[row, col].Value.ToString()}: {int.Parse(ws.Cells[row + 1, col].Value.ToString())}\r\n");
                }
                
                col++;
            }

        }

        private void folderBrowerButton_Click(object sender, EventArgs e)
        {
            //DialogResult result = folderBrowserDialog1.ShowDialog();
            //if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            //{
            //    textFolder.Text = folderBrowserDialog1.SelectedPath;
            //}

            OpenFileDialog openFileDialog = new();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textFolder.Text = openFileDialog.FileName;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int fadingSpeed = 5;
            copyLabel.ForeColor = Color.FromArgb(copyLabel.ForeColor.R + fadingSpeed, copyLabel.ForeColor.G + fadingSpeed, copyLabel.ForeColor.B + fadingSpeed);

            if (copyLabel.ForeColor.R >= this.BackColor.R)
            {
                timer1.Stop();
                copyLabel.Visible = false;
            }

        }
    }
}
