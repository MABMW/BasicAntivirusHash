namespace Basic_Antivirus_Hash
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.LblDataBaseHash = new System.Windows.Forms.Label();
            this.TxtHASHfile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAnalizerFile = new System.Windows.Forms.Button();
            this.BtnLoadFile = new System.Windows.Forms.Button();
            this.LblFile = new System.Windows.Forms.Label();
            this.TxtFileInput = new System.Windows.Forms.TextBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.progressBarAnalizer = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // LblDataBaseHash
            // 
            this.LblDataBaseHash.AutoSize = true;
            this.LblDataBaseHash.Location = new System.Drawing.Point(12, 156);
            this.LblDataBaseHash.Name = "LblDataBaseHash";
            this.LblDataBaseHash.Size = new System.Drawing.Size(112, 15);
            this.LblDataBaseHash.TabIndex = 0;
            this.LblDataBaseHash.Text = "Download:BaseData";
            // 
            // TxtHASHfile
            // 
            this.TxtHASHfile.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtHASHfile.Location = new System.Drawing.Point(116, 68);
            this.TxtHASHfile.Name = "TxtHASHfile";
            this.TxtHASHfile.Size = new System.Drawing.Size(384, 30);
            this.TxtHASHfile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "MD5: ";
            // 
            // BtnAnalizerFile
            // 
            this.BtnAnalizerFile.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAnalizerFile.Location = new System.Drawing.Point(402, 104);
            this.BtnAnalizerFile.Name = "BtnAnalizerFile";
            this.BtnAnalizerFile.Size = new System.Drawing.Size(98, 43);
            this.BtnAnalizerFile.TabIndex = 3;
            this.BtnAnalizerFile.Text = "Analizar";
            this.BtnAnalizerFile.UseVisualStyleBackColor = true;
            this.BtnAnalizerFile.Click += new System.EventHandler(this.BtnAnalizerFile_Click);
            // 
            // BtnLoadFile
            // 
            this.BtnLoadFile.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLoadFile.Location = new System.Drawing.Point(228, 104);
            this.BtnLoadFile.Name = "BtnLoadFile";
            this.BtnLoadFile.Size = new System.Drawing.Size(168, 43);
            this.BtnLoadFile.TabIndex = 4;
            this.BtnLoadFile.Text = "Cargar Archivo";
            this.BtnLoadFile.UseVisualStyleBackColor = true;
            this.BtnLoadFile.Click += new System.EventHandler(this.BtnLoadFile_Click);
            // 
            // LblFile
            // 
            this.LblFile.AutoSize = true;
            this.LblFile.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblFile.Location = new System.Drawing.Point(12, 32);
            this.LblFile.Name = "LblFile";
            this.LblFile.Size = new System.Drawing.Size(98, 23);
            this.LblFile.TabIndex = 5;
            this.LblFile.Text = "Archivo: ";
            // 
            // TxtFileInput
            // 
            this.TxtFileInput.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtFileInput.Location = new System.Drawing.Point(116, 32);
            this.TxtFileInput.Name = "TxtFileInput";
            this.TxtFileInput.Size = new System.Drawing.Size(384, 30);
            this.TxtFileInput.TabIndex = 6;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblStatus.Location = new System.Drawing.Point(12, 114);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(139, 23);
            this.LblStatus.TabIndex = 7;
            this.LblStatus.Text = "Status: N/A";
            // 
            // progressBarAnalizer
            // 
            this.progressBarAnalizer.Location = new System.Drawing.Point(12, 174);
            this.progressBarAnalizer.Name = "progressBarAnalizer";
            this.progressBarAnalizer.Size = new System.Drawing.Size(479, 40);
            this.progressBarAnalizer.TabIndex = 8;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 221);
            this.Controls.Add(this.progressBarAnalizer);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.TxtFileInput);
            this.Controls.Add(this.LblFile);
            this.Controls.Add(this.BtnLoadFile);
            this.Controls.Add(this.BtnAnalizerFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtHASHfile);
            this.Controls.Add(this.LblDataBaseHash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analizer HASH";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblDataBaseHash;
        private TextBox TxtHASHfile;
        private Label label1;
        private Button BtnAnalizerFile;
        private Button BtnLoadFile;
        private Label LblFile;
        private TextBox TxtFileInput;
        private Label LblStatus;
        private ProgressBar progressBarAnalizer;
    }
}