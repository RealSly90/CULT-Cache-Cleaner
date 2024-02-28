using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CULT_Cache_Cleaner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Comandi per eliminare le cartelle
                string[] commands = {
                    @"rmdir /s /q ""%LocalAppData%\FiveM\FiveM.app\data\cache""",
                    @"rmdir /s /q ""%LocalAppData%\FiveM\FiveM.app\data\nui-storage""",
                    @"rmdir /s /q ""%LocalAppData%\FiveM\FiveM.app\data\nui-storage-fxdk""",
                    @"rmdir /s /q ""%LocalAppData%\FiveM\FiveM.app\data\server-cache""",
                    @"rmdir /s /q ""%LocalAppData%\FiveM\FiveM.app\data\server-cache-fxdk""",
                    @"rmdir /s /q ""%LocalAppData%\FiveM\FiveM.app\data\server-cache-priv"""
                };

                // Esecuzione dei comandi
                foreach (string command in commands)
                {
                    ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
                    processInfo.CreateNoWindow = true;
                    processInfo.UseShellExecute = false;
                    Process.Start(processInfo).WaitForExit();
                }

                MessageBox.Show("Cartelle eliminate con successo, puoi chiudere l'app e avviare FiveM.", "Operazione completata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Si è verificato un errore durante l'eliminazione delle cartelle:\n\n" + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Comandi per eliminare le cartelle e il file
                string[] commands = {
                    @"del /q ""%appdata%\CitizenFX\fivem.cfg""",
                    @"rmdir /s /q ""%LocalAppData%\FiveM\FiveM.app\data\cache""",
                    @"rmdir /s /q ""%LocalAppData%\FiveM\FiveM.app\data\nui-storage""",
                    @"rmdir /s /q ""%LocalAppData%\FiveM\FiveM.app\data\nui-storage-fxdk""",
                    @"rmdir /s /q ""%LocalAppData%\FiveM\FiveM.app\data\server-cache""",
                    @"rmdir /s /q ""%LocalAppData%\FiveM\FiveM.app\data\server-cache-fxdk""",
                    @"rmdir /s /q ""%LocalAppData%\FiveM\FiveM.app\data\server-cache-priv"""
                };

                // Esecuzione dei comandi
                foreach (string command in commands)
                {
                    ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
                    processInfo.CreateNoWindow = true;
                    processInfo.UseShellExecute = false;
                    Process.Start(processInfo).WaitForExit();
                }

                MessageBox.Show("File e cartelle eliminate con successo, chiudi l'app e avvia FiveM.", "Operazione completata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Si è verificato un errore durante l'eliminazione dei file e delle cartelle:\n\n" + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
