using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CSO_Text_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            rtbErrors.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select File";
            openFileDialog.InitialDirectory = @"C:";//--"C:\";
            openFileDialog.FilterIndex = 2;
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                DisplayFileName.Text = openFileDialog.FileName;
            }
            else
            {
                DisplayFileName.Text = "You didn't select the file!";
            }
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName == "cso_na_en.txt")
                {
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);
                    int batchSize = 100;
                    int numBatches = (int)Math.Ceiling((double)lines.Length / batchSize);
                    int errorCount = 0;

                    for (int i = 0; i < numBatches; i++)
                    {
                        int start = i * batchSize;
                        int end = Math.Min(start + batchSize, lines.Length);

                        for (int j = start; j < end; j++)
                        {
                            if (string.IsNullOrWhiteSpace(lines[j]) || lines[j].StartsWith("{") || lines[j].StartsWith("}") || lines[j].StartsWith("//") || lines[j].StartsWith("/") || lines[j].Contains("/") || lines[j].Contains("//") || lines[j].Contains("Tokens") || lines[j].Contains("}") || lines[j].Contains("{") || lines[j].Contains("Language") || lines[j].Contains("lang"))
                            {
                                continue;
                            }

                            int quoteCount = 0;
                            for (int k = 0; k < lines[j].Length; k++)
                            {
                                if (lines[j][k] == '"')
                                {
                                    quoteCount++;
                                    if (quoteCount == 4)
                                    {
                                        break;
                                    }
                                }
                            }
                            if (quoteCount != 4)
                            {
                                rtbErrors.AppendText(string.Format("Line {0}: {1}{2}", j + 1, lines[j], Environment.NewLine));
                                for (int k = 0; k < lines[j].Length; k++)
                                {
                                    if (lines[j][k] == '"')
                                    {
                                    }
                                    else
                                    {
                                    }
                                }
                                rtbErrors.AppendText(Environment.NewLine);
                                errorCount++;
                            }
                        }
                    }

                    MessageBox.Show(string.Format("Finished processing {0} lines with {1} errors.", lines.Length, errorCount));
                }
                else
                {
                        string[] lines = File.ReadAllLines(openFileDialog.FileName);
                        int batchSize = 100;
                        int numBatches = (int)Math.Ceiling((double)lines.Length / batchSize);
                        int errorCount = 0;

                        for (int i = 0; i < numBatches; i++)
                        {
                            int start = i * batchSize;
                            int end = Math.Min(start + batchSize, lines.Length);

                            for (int j = start; j < end; j++)
                            {
                                if (string.IsNullOrWhiteSpace(lines[j]) || lines[j].StartsWith("{") || lines[j].StartsWith("}") || lines[j].StartsWith("//") || lines[j].StartsWith("/") || lines[j].Contains("/") || lines[j].Contains("//") || lines[j].Contains("Tokens") || lines[j].Contains("}") || lines[j].Contains("{") || lines[j].Contains("Language") || lines[j].Contains("lang"))
                                {
                                    continue;
                                }

                                int quoteCount = 0;
                                for (int k = 0; k < lines[j].Length; k++)
                                {
                                    if (lines[j][k] == '"')
                                    {
                                        quoteCount++;
                                        if (quoteCount == 2 && quoteCount == 4 )
                                        {
                                            break;
                                        }
                                    }
                                }
                            if (quoteCount != 2 && quoteCount != 4)
                            {
                                    rtbErrors.AppendText(string.Format("Line {0}: {1}{2}", j + 1, lines[j], Environment.NewLine));
                                    for (int k = 0; k < lines[j].Length; k++)
                                    {
                                        if (lines[j][k] == '"')
                                        {
                                        }
                                        else
                                        {
                                        }
                                    }
                                    rtbErrors.AppendText(Environment.NewLine);
                                    errorCount++;
                                }
                            }
                        }
                        MessageBox.Show(string.Format("Finished processing {0} lines with {1} errors.", lines.Length, errorCount));
                    }

            }
        }

        private bool IsValidLine(string line)
        {
            if (string.IsNullOrWhiteSpace(line) ||
                line.StartsWith("{") ||
                line.StartsWith("}") ||
                line.StartsWith("//") ||
                line.StartsWith("/") ||
                line.Contains("/") ||
                line.Contains("//") ||
                line.Contains("Tokens") ||
                line.Contains("}") ||
                line.Contains("{") ||
                line.Contains("Language") ||
                line.Contains("lang"))
            {
                return false;
            }
            return true;
        }
        private int GetLineIndex(string[] allLines, string line)
        {
            for (int i = 0; i < allLines.Length; i++)
            {
                if (allLines[i] == line)
                {
                    return i;
                }
            }
            return -1;
        }

        private void DisplayFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtbErrors_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfile()
        {

        }

        private void sconfig()
        {

        }

        private void MD(object sender, MouseEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/TAJassson",
                UseShellExecute = true
            });
        }
    }
}
