using System;
using System.Diagnostics;
using System.IO;
using System.Net;
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

        private string winScript = "scripts\\windows_KMS.bat";
        private string office16Script = "scripts\\office2016_KMS.bat";
        private string officeScript = "scripts\\office2019_KMS.bat";

        private bool SchoolBehavior()
        {
            string realIp = getIp();


            if ((string)ChangeToNTHUMode.Tag == "1" && !realIp.Contains("140.114"))
            {
                MessageBox.Show("您並非使用清大IP，請確定已連線至清大VPN\nIP="+realIp, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if((string)ChangeToNTHUMode.Tag == "0")
            {
                this.Hide();
                browser browserForm = new browser();
                browserForm.ShowDialog(this); 
            }
            return true;
        }

        private string getIp()
        {
            string externalIpString = new WebClient().DownloadString("http://icanhazip.com").Replace("\\r\\n", "").Replace("\\n", "").Trim();
            var externalIp = IPAddress.Parse(externalIpString);

            Console.WriteLine(externalIp.ToString());
            return externalIp.ToString();
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
            if (!SchoolBehavior())
            {
                return;
            }

            CMD_Output.Text = "";
            ChangeWaitCursor(true);
            ExecuteCommand(office16Script);
            LabelChangeStatus();
            ChangeWaitCursor(false);
        }

        private void Bwindows_Click(object sender, EventArgs e)
        {
            if (!SchoolBehavior())
            {
                return;
            }

            CMD_Output.Text = "";
            ChangeWaitCursor(true);
            ExecuteCommand(winScript);
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
            if (!SchoolBehavior())
            {
                return;
            }

            CMD_Output.Text = "";
            ChangeWaitCursor(true);
            ExecuteCommand(officeScript);
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
            string authorText = "CSMU-KMS GUI v1.4.1\nLiu, Tzu-Hao CSMT-107";
            string sourceText = "Source:\nKMS script from CSMU, NTHU and alternate script from DYU.";
            string iconCredit = "Credit:\nWrench icons created by Freepik-Flaticon";

            MessageBox.Show(String.Format("{0}\n\n{1}\n\n{2}", authorText, sourceText, iconCredit), "About | Credit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Tag: 0=中山醫 1=清大
        private void 切換到清華大學ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((string)ChangeToNTHUMode.Tag == "0")
            {
                groupBox1.Text = "Microsoft Office(NTHU)";
                groupBox2.Text = "Microsoft Windows OS(NTHU)";
                Boffice2010.Enabled = false;
                Boffice2013.Enabled = false;
                ChangeToNTHUMode.Text = "切換到中山醫";
                ChangeToNTHUMode.Tag = "1";
                winScript = "scripts\\WinKMSNTHU.bat";
                officeScript = "scripts\\OfficeNTHU.bat";
                office16Script = "scripts\\OfficeNTHU.bat";
            }
            else
            {
                groupBox1.Text = "Microsoft Office(CSMU)";
                groupBox2.Text = "Microsoft Windows OS(CSMU)";
                Boffice2010.Enabled = true;
                Boffice2013.Enabled = true;
                ChangeToNTHUMode.Text = "切換到清華大學";
                ChangeToNTHUMode.Tag = "0";
                winScript = "scripts\\windows_KMS.bat";
                officeScript = "scripts\\office2019_KMS.bat";
                office16Script = "scripts\\office2016_KMS.bat";
            }
            
        }
    }
}
