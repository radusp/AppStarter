using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SmartAppStarter
{
    public partial class Form1 : Form
    {

        bool SandBoxValidator = false;
        CoreParameters diskloaderProps;
        GuiParameters guiProps;
        MakePyParameters makePiPropsCompile;
       // AutoCompleteStringCollection makepyCmdSource;
        AutoCompleteStringCollection componentSource = new AutoCompleteStringCollection();

        public Form1()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            setUpAutoCompleteForMakepyCmd();
        }

        private void setUpAutoCompleteForComponent()
        {
            txtComponent.AutoCompleteCustomSource = componentSource;
            txtComponent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtComponent.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void setUpAutoCompleteForMakepyCmd()
        {
            var makepyCmdSource = new AutoCompleteStringCollection();
            makepyCmdSource.AddRange(new string[]
                            {
                        "compile",
                        "clean",
                        "install",
                        "configure"
                            });

            txtMakepyCMD.AutoCompleteCustomSource = makepyCmdSource;
            txtMakepyCMD.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtMakepyCMD.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnLoadProjPath_Click(object sender, EventArgs e)
        {
            Util.clearAllPaths();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                parseInputFolder();
                if(SandBoxValidator == true)
                {
                    findExecutables();
                    populateDataSourceForComponent();

                    if (SandBoxValidator == true)
                    {
                        txtProjectPath.Text = Util.myPaths.projectPath;
                        lblStatusPath.Text = "OK";
                        lblStatusPath.ForeColor = Color.Green;
                        lblStatusPath.Visible = true;
                    }
                    else
                    {
                        lblStatusPath.Visible = true;
                    }
                }
            }
        }

        private void populateDataSourceForComponent()
        {

            try
            {
                string[] readTextFromExternals = File.ReadAllLines(Util.myPaths.pathToExternalsFile);
                foreach (string line in readTextFromExternals)
                {
                    string[] tempLineSplit = line.Split(' ');
                    if (tempLineSplit.Length == 3)
                    {
                        componentSource.Add(tempLineSplit[2]);
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Something happened while parsing the external files. You will not have autocomplete for the component field.");
            } 

            setUpAutoCompleteForComponent();
        }

        private void findExecutables()
        {
            if (!(Directory.Exists(Util.myPaths.pathToSandboxInstall + "//bin")))
            {
                MessageBox.Show("BIN folder does not exist in Sandbox_Install, please select another Project Folder");
            }
            else
            {
                validatePathsToExecutables();

            }
        }

        private void validatePathsToExecutables()
        {
            Util.myPaths.pathToSandboxInstallBinFolder = Util.myPaths.pathToSandboxInstall + "//bin";
            validatePathForCoreExe();
            validatePathForUniVisionExe();
            validatePathToExternals();
        }

        private static void validatePathToExternals()
        {
            DirectoryInfo d = new DirectoryInfo(Util.myPaths.projectPath);
            FileInfo[] Files = d.GetFiles("*.externals");
            foreach (FileInfo file in Files)
            {
                Util.myPaths.pathToExternalsFile = Util.myPaths.projectPath + @"\" + file.Name;
            }
        }

        private void validatePathForUniVisionExe()
        {
            if (!(File.Exists(Util.myPaths.pathToSandboxInstallBinFolder + "//uniVision.exe")))
            {
                MessageBox.Show("uniVision.exe file does not exist in Sandbox_Install, please select another Project Folder");
                SandBoxValidator = false;
            }
            else
            {
                Util.myPaths.pathToUniVisionGui = Util.myPaths.pathToSandboxInstallBinFolder + "//uniVision.exe";
            }
        }

        private void validatePathForCoreExe()
        {
            if (!(File.Exists(Util.myPaths.pathToSandboxInstallBinFolder + "//core.exe")))
            {
                MessageBox.Show("Core.exe file does not exist in Sandbox_Install, please select another Project Folder");
                SandBoxValidator = false;
            }
            else
            {
                Util.myPaths.pathToCoreApplication = Util.myPaths.pathToSandboxInstallBinFolder + "//core.exe";
            }
        }

        private void parseInputFolder()
        {
            string[] files = Directory.GetDirectories(folderBrowserDialog1.SelectedPath);
            Util.myPaths.projectPath = folderBrowserDialog1.SelectedPath;
            foreach (string str in files)
            {
                if (str.Contains("_Sandbox_INSTALL"))
                {
                    Util.myPaths.pathToSandboxInstall = str;
                    SandBoxValidator = true;
                }
            }

            if (SandBoxValidator == false)
            {
                notValidSandboxPath();
                return;
            }

        }

        private static void notValidSandboxPath()
        {
            MessageBox.Show("Please try another Directory. This Folder does not contain Sandbox_Install floder");
            Util.myPaths.projectPath = "";
            return;
        }

        private void btnStartCoreDiskloader_Click(object sender, EventArgs e)
        {
            if (isOneOfCoreFieldEmpty())
            {
                MessageBox.Show("Can't have empty fields");
                return;
            }
            setupCoreParameters();
            startCoreProcess();
        }

        private void startCoreProcess()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = Util.myPaths.pathToCoreApplication;
            startInfo.Arguments = @"-d " + diskloaderProps._d + @" -di " + diskloaderProps._di + @" -ip " + diskloaderProps._ip;
            try
            {
                Process.Start(startInfo);
            }
            catch (Exception ee)
            {
                MessageBox.Show("A project must be loaded first");
            }
        }

        private bool isOneOfCoreFieldEmpty()
        {
            return (txtD.Text == "") || (txtDi.Text == "") || (txtIP.Text == "");
        }

        private void setupCoreParameters()
        {
            diskloaderProps = new CoreParameters();
            diskloaderProps._d = txtD.Text;
            diskloaderProps._di = txtDi.Text;
            diskloaderProps._ip = txtIP.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (areGuiFieldsEmpty())
            {
                MessageBox.Show("Can't have empty fields");
                return;
            }

            setupGuiParameters();

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = Util.myPaths.pathToUniVisionGui;
            startInfo.Arguments = @"--connect --ip " + guiProps._ip + @" --port " + guiProps._port;
            try
            {
                Process.Start(startInfo);
            }
            catch(Exception ee)
            {
                MessageBox.Show("A project must be loaded first");
            }
        }

        private bool areGuiFieldsEmpty()
        {
            return (txtGuiIp.Text == "") || (txtGuiPort.Text == "");
        }

        private void setupGuiParameters()
        {
            guiProps = new GuiParameters();
            guiProps._ip = txtGuiIp.Text;
            guiProps._port = txtGuiPort.Text;
        }

        private void btnSaveCore_Click(object sender, EventArgs e)
        {
            // Create a string array with the lines of text
            List<string> lines = new List<string>();
            if (isOneOfCoreFieldEmpty())
            {
                MessageBox.Show("Can't have empty fields");
                return;
            }

            lines.Add(txtD.Text);
            lines.Add(txtDi.Text);
            lines.Add(txtIP.Text);


            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(@"CoreConfig.sas"))
            {
                foreach (string line in lines)
                {
                    outputFile.WriteLine(line);
                }
                btnSaveCore.ForeColor = Color.Green;
            }
        }

        private void btnLoadCore_Click(object sender, EventArgs e)
        {
            try
            {
                string[] readText = File.ReadAllLines(@"CoreConfig.sas");
                txtD.Text = readText[0];
                txtDi.Text = readText[1];
                txtIP.Text = readText[2];
                btnLoadCore.ForeColor = Color.Green;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Please save a configuration, before you try to open one");
            }
        }

        private void btnSaveGui_Click(object sender, EventArgs e)
        {
            // Create a string list with the lines of text
            List<string> lines = new List<string>();
            if (areGuiFieldsEmpty())
            {
                MessageBox.Show("Can't have empty fields");
                return;
            }

            lines.Add(txtGuiIp.Text);
            lines.Add(txtGuiPort.Text);

            // Write the string array to a new file named "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(@"GuiConfig.sas"))
            {
                foreach (string line in lines)
                {
                    outputFile.WriteLine(line);
                }
                btnSaveGui.ForeColor = Color.Green;
            }
        }

        private void btnLoadGui_Click(object sender, EventArgs e)
        {
            try
            {
                string[] readText = File.ReadAllLines(@"GuiConfig.sas");
                txtGuiIp.Text = readText[0];
                txtGuiPort.Text = readText[1];
                btnLoadGui.ForeColor = Color.Green;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Please save a configuration, before you try to open one");
            }
        }

        private void btnQuickStartCore_Click(object sender, EventArgs e)
        {
            btnStartCoreDiskloader_Click(sender, e);
        }

        private void btnQuickStartGUI_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void btnQuickSwitch_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Size = new System.Drawing.Size(661, 240);
        }

        private void btnSwitchToQuickView_Click(object sender, EventArgs e)
        {
            Size = new System.Drawing.Size(330, 80);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new Point(700, 0);
            this.TopMost = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (SandBoxValidator == true)
            {
                Process.Start(Util.myPaths.projectPath);
            }
            else
            {
                MessageBox.Show("First you must load a valid project");
            }
        }

        private void btnPathToBin_Click(object sender, EventArgs e)
        {
            if (SandBoxValidator == true)
            {
                Process.Start(Util.myPaths.pathToSandboxInstallBinFolder);
            }
            else
            {
                MessageBox.Show("First you must load a valid project");
            }
        }

        private void btnCompile_Click(object sender, EventArgs e)
        {
            if (txtMakepyCMD.Text == "")
            {
                MessageBox.Show("You must specify a command if you want to run Make.py");
                return;
            }

            if (SandBoxValidator == false)
            {
                MessageBox.Show("A project must be loaded if you want to compile");
                return;
            }
            startCompileProcess();
        }

        private void startCompileProcess()
        {
            Process p = new Process();

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WorkingDirectory = Util.myPaths.projectPath;
             startInfo.FileName = @"Make.py";
            startInfo.Arguments = "prompt " + txtMakepyCMD.Text + @" " + txtComponent.Text;
            p.StartInfo = startInfo;
            
            try
            {
                p.Start();
            }
            catch (Exception ee)
            {
                MessageBox.Show("A project must be loaded first");
            }
        }

        private void setupMakePiProps()
        {
            makePiPropsCompile = new MakePyParameters();
            makePiPropsCompile.operation = "compile";
            makePiPropsCompile.component = txtComponent.Text;
        }
    }
}
