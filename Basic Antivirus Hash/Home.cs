using System.Security.Cryptography;
using MaterialSkin.Controls;
namespace Basic_Antivirus_Hash
{
    public partial class Home : MaterialForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            DownloadDataBaseHASH();
        }

        /// <summary>
        /// Descargar todos los archivos md5 que contiene HASH de virus previamente escaneados
        /// desde https://virusshare.com
        /// </summary>
        private async void DownloadDataBaseHASH()
        {
            for (int i = 0; i < 404; i++)
            {
                string number = "00000";
                if (i < 10)
                    number = "0000" + i;
                else if (i < 100)
                    number = "000" + i;
                else if (i < 1000)
                    number = "00" + i;
                string _pathfile = @"DataBase\" + number + ".md5";
                if (!Directory.Exists("DataBase"))
                    Directory.CreateDirectory("DataBase");
                if (!File.Exists(_pathfile))
                {
                    string dataDownload = "https://virusshare.com/hashfiles/VirusShare_" + number + ".md5";
                    var httpClient = new HttpClient();
                    using var stream = await httpClient.GetStreamAsync(dataDownload);
                    LblDataBaseHash.Text = "Descargando: " + number + ".md5";
                    using var fileStream = new FileStream(_pathfile, FileMode.CreateNew);
                    await stream.CopyToAsync(fileStream);
                }
                else
                {
                    LblDataBaseHash.Text = "Complete!";
                }
            }
        }

        //Codigo Obtenido de https://pastebin.com/nMfCQCpV
        public string GetMD5FromFile(string filenPath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filenPath))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();
                }
            }
        }

        private void BtnAnalizerFile_Click(object sender, EventArgs e)
        {
            Task.Run(new Action(() => Analizer()));
        }

        private void Analizer()
        {
            Invoke(new Action(() => BtnAnalizerFile.Enabled = false));
            Invoke(new Action(() => BtnLoadFile.Enabled = false));
            Invoke(new Action(() => TxtHASHfile.Enabled = false));

            string[] DataBaseFile = Directory.GetFiles("DataBase", "*.md5");
            Invoke(new Action(() => progressBarAnalizer.Maximum = DataBaseFile.Length));
            for (int i = 0; i < DataBaseFile.Length; i++)
            {
                var md5Firmas = File.ReadAllLines(DataBaseFile[i]);
                if (md5Firmas.Contains(TxtHASHfile.Text))
                {
                    Invoke(new Action(() => LblStatus.Text = "Status: Infectado"));
                    Invoke(new Action(() => LblStatus.ForeColor = Color.Red));
                    Invoke(new Action(() => progressBarAnalizer.Value = progressBarAnalizer.Maximum));
                    return;
                }
                else
                {
                    Invoke(new Action(() => LblStatus.Text = "Status: Limpio"));
                    Invoke(new Action(() => LblStatus.ForeColor = Color.Green));
                }
                Invoke(new Action(() => LblDataBaseHash.Text ="Base de Dato N° : "+ (i + 1) + "/" + DataBaseFile.Length));
                Invoke(new Action(() => progressBarAnalizer.Value = i + 1));
            }

            Invoke(new Action(() => BtnAnalizerFile.Enabled = true));
            Invoke(new Action(() => BtnLoadFile.Enabled = true));
            Invoke(new Action(() => TxtHASHfile.Enabled = true));
        }

        private void BtnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivo | *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TxtFileInput.Text = ofd.FileName;
                TxtHASHfile.Text = GetMD5FromFile(ofd.FileName);
            }
            LblStatus.Text = "Status: N/A";
            LblStatus.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
        }
    }
}