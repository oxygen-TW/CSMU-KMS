using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CSMU_KMS
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void Boffice2010_Click(object sender, EventArgs e)
        {
            this.Hide();
            browser browserForm = new browser();
            browserForm.ShowDialog(this); ;

            CMD_Output.Text = "";
            ChangeWaitCursor(true);
            ExecuteCommand("scripts\\office2010_KMS.bat");
            LabelChangeStatus();
            ChangeWaitCursor(false);
        }

        private void Boffice2013_Click(object sender, EventArgs e)
        {
            this.Hide();
            browser browserForm = new browser();
            browserForm.ShowDialog(this); ;

            CMD_Output.Text = "";
            ChangeWaitCursor(true);
            ExecuteCommand("scripts\\office2013_KMS.bat");
            LabelChangeStatus();
            ChangeWaitCursor(false);
        }

        private void Boffice2016_Click(object sender, EventArgs e)
        {
            this.Hide();
            browser browserForm = new browser();
            browserForm.ShowDialog(this); ;

            CMD_Output.Text = "";
            ChangeWaitCursor(true);
            ExecuteCommand("scripts\\office2016_KMS.bat");
            LabelChangeStatus();
            ChangeWaitCursor(false);
        }

        private void Bwindows_Click(object sender, EventArgs e)
        {
            this.Hide();
            browser browserForm = new browser();
            browserForm.ShowDialog(this); ;

            CMD_Output.Text = "";
            ChangeWaitCursor(true);
            ExecuteCommand("scripts\\windows_KMS.bat");
            LabelChangeStatus();
            ChangeWaitCursor(false);
        }

        private void BWindowsDyu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("kms 主機設定為 mskms.dyu.edu.tw:1688","注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CMD_Output.Text = "";
            ChangeWaitCursor(true);
            ExecuteCommand("scripts\\windows_KMS_dyu.bat");
            LabelChangeStatus();
            ChangeWaitCursor(false);
        }

        private void ExecuteCommand(string BatchFileName)
        {
            BatchFileName = Directory.GetCurrentDirectory() +"\\"+ BatchFileName;
            Console.WriteLine(BatchFileName);

            int exitCode;
            ProcessStartInfo processInfo;
            Process process;

            processInfo = new ProcessStartInfo(BatchFileName);
            processInfo.CreateNoWindow = true;
            processInfo.UseShellExecute = false;
            // *** Redirect the output ***
            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            process = Process.Start(processInfo);
            process.WaitForExit();

            // *** Read the streams ***
            // Warning: This approach can lead to deadlocks, see Edit #2
            while (!process.StandardOutput.EndOfStream)
            {
                string output = process.StandardOutput.ReadLine();
                string error = process.StandardError.ReadLine();

                exitCode = process.ExitCode;

                if (output.Contains("finished"))
                {
                    break;
                }

                Console.WriteLine("output>>" + (String.IsNullOrEmpty(output) ? "(none)" : output));
                Console.WriteLine("error>>" + (String.IsNullOrEmpty(error) ? "(none)" : error));
                Console.WriteLine("ExitCode: " + exitCode.ToString(), "ExecuteCommand");

                TextBox _CMD_Output = new TextBox();
                _CMD_Output = CMD_Output;
                _CMD_Output.Text += (string.IsNullOrEmpty(output) ? "(none)" : output) + "\r\n";

                //自動捲動程式碼
                _CMD_Output.ScrollBars = ScrollBars.Vertical;
                _CMD_Output.SelectionStart = _CMD_Output.Text.Length;
                _CMD_Output.ScrollToCaret();
            }
            process.Close();
        }

        private void LabelChangeStatus()
        {
            BatchStatus.Text = "啟動狀態：" + (CMD_Output.Text.Contains("Product activation successful") || CMD_Output.Text.Contains("產品已成功啟用") ? "成功" : "失敗，請確認是否已成功驗證 IP");
        }

        private void BClearConsole_Click(object sender, EventArgs e)
        {
            CMD_Output.Text = "";
        }

        private void ChangeWaitCursor(bool status)
        {
            Cursor.Current = status ? Cursors.WaitCursor : Cursors.Default;
        }

        private void Boffice2019_Click(object sender, EventArgs e)
        {
            this.Hide();
            browser browserForm = new browser();
            browserForm.ShowDialog(this); ;

            CMD_Output.Text = "";
            ChangeWaitCursor(true);
            ExecuteCommand("scripts\\office2019_KMS.bat");
            LabelChangeStatus();
            ChangeWaitCursor(false);
        }

        private void ProgramInfo_Click(object sender, EventArgs e)
        {

        }

        private void 清除目前OfficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CMD_Output.Text = "";
            ChangeWaitCursor(true);
            ExecuteCommand("scripts\\o15-ctrremove.diagcab");
            //LabelChangeStatus();
            ChangeWaitCursor(false);
        }

        private void 關於AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string authorText = "CSMU-KMS GUI v1.3\nLiu, Tzu-Hao CSMT-107";
            string sourceText = "Source:\nKMS script from CSMU and alternate script from DYU.";
            string iconCredit = "Credit:\nWrench icons created by Freepik-Flaticon";

            MessageBox.Show(String.Format("{0}\n\n{1}\n\n{2}", authorText, sourceText, iconCredit), "About | Credit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
