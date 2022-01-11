namespace Basic_Antivirus_Hash
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.TxtFileInput = new MaterialSkin.Controls.MaterialTextBox2();
            this.TxtHASHfile = new MaterialSkin.Controls.MaterialTextBox2();
            this.LblDataBaseHash = new MaterialSkin.Controls.MaterialLabel();
            this.LblStatus = new MaterialSkin.Controls.MaterialLabel();
            this.progressBarAnalizer = new MaterialSkin.Controls.MaterialProgressBar();
            this.BtnLoadFile = new MaterialSkin.Controls.MaterialButton();
            this.BtnAnalizerFile = new MaterialSkin.Controls.MaterialButton();
            this.BtnCopy = new MaterialSkin.Controls.MaterialButton();
            this.BtnCopyPath = new MaterialSkin.Controls.MaterialButton();
            this.BtnDeleteFile = new MaterialSkin.Controls.MaterialButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // TxtFileInput
            // 
            this.TxtFileInput.AnimateReadOnly = true;
            this.TxtFileInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtFileInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtFileInput.Depth = 0;
            this.TxtFileInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtFileInput.HelperText = "Ruta del archivo";
            this.TxtFileInput.HideSelection = true;
            this.TxtFileInput.Hint = "Ruta del Archivo";
            this.TxtFileInput.LeadingIcon = null;
            this.TxtFileInput.Location = new System.Drawing.Point(6, 36);
            this.TxtFileInput.MaxLength = 32767;
            this.TxtFileInput.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtFileInput.Name = "TxtFileInput";
            this.TxtFileInput.PasswordChar = '\0';
            this.TxtFileInput.PrefixSuffixText = null;
            this.TxtFileInput.ReadOnly = true;
            this.TxtFileInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtFileInput.SelectedText = "";
            this.TxtFileInput.SelectionLength = 0;
            this.TxtFileInput.SelectionStart = 0;
            this.TxtFileInput.ShortcutsEnabled = true;
            this.TxtFileInput.ShowAssistiveText = true;
            this.TxtFileInput.Size = new System.Drawing.Size(556, 64);
            this.TxtFileInput.TabIndex = 1;
            this.TxtFileInput.TabStop = false;
            this.TxtFileInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtFileInput.TrailingIcon = null;
            this.TxtFileInput.UseSystemPasswordChar = false;
            // 
            // TxtHASHfile
            // 
            this.TxtHASHfile.AnimateReadOnly = true;
            this.TxtHASHfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TxtHASHfile.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtHASHfile.Depth = 0;
            this.TxtHASHfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TxtHASHfile.HideSelection = true;
            this.TxtHASHfile.Hint = "Firma HASH";
            this.TxtHASHfile.LeadingIcon = null;
            this.TxtHASHfile.Location = new System.Drawing.Point(6, 106);
            this.TxtHASHfile.MaxLength = 32767;
            this.TxtHASHfile.MouseState = MaterialSkin.MouseState.OUT;
            this.TxtHASHfile.Name = "TxtHASHfile";
            this.TxtHASHfile.PasswordChar = '\0';
            this.TxtHASHfile.PrefixSuffixText = null;
            this.TxtHASHfile.ReadOnly = true;
            this.TxtHASHfile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtHASHfile.SelectedText = "";
            this.TxtHASHfile.SelectionLength = 0;
            this.TxtHASHfile.SelectionStart = 0;
            this.TxtHASHfile.ShortcutsEnabled = true;
            this.TxtHASHfile.ShowAssistiveText = true;
            this.TxtHASHfile.Size = new System.Drawing.Size(556, 64);
            this.TxtHASHfile.TabIndex = 3;
            this.TxtHASHfile.TabStop = false;
            this.TxtHASHfile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtHASHfile.TrailingIcon = null;
            this.TxtHASHfile.UseSystemPasswordChar = false;
            // 
            // LblDataBaseHash
            // 
            this.LblDataBaseHash.Depth = 0;
            this.LblDataBaseHash.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblDataBaseHash.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LblDataBaseHash.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.LblDataBaseHash.ForeColor = System.Drawing.Color.CadetBlue;
            this.LblDataBaseHash.HighEmphasis = true;
            this.LblDataBaseHash.Location = new System.Drawing.Point(6, 189);
            this.LblDataBaseHash.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblDataBaseHash.Name = "LblDataBaseHash";
            this.LblDataBaseHash.Size = new System.Drawing.Size(197, 36);
            this.LblDataBaseHash.TabIndex = 4;
            this.LblDataBaseHash.Text = "DownloadDataBase";
            this.LblDataBaseHash.UseAccent = true;
            this.LblDataBaseHash.UseCompatibleTextRendering = true;
            // 
            // LblStatus
            // 
            this.LblStatus.Depth = 0;
            this.LblStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblStatus.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LblStatus.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.LblStatus.Location = new System.Drawing.Point(6, 237);
            this.LblStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(142, 19);
            this.LblStatus.TabIndex = 5;
            this.LblStatus.Text = "Status: N/A";
            this.LblStatus.UseAccent = true;
            // 
            // progressBarAnalizer
            // 
            this.progressBarAnalizer.Cursor = System.Windows.Forms.Cursors.Cross;
            this.progressBarAnalizer.Depth = 0;
            this.progressBarAnalizer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarAnalizer.ForeColor = System.Drawing.Color.Chartreuse;
            this.progressBarAnalizer.Location = new System.Drawing.Point(3, 273);
            this.progressBarAnalizer.MarqueeAnimationSpeed = 500;
            this.progressBarAnalizer.MouseState = MaterialSkin.MouseState.HOVER;
            this.progressBarAnalizer.Name = "progressBarAnalizer";
            this.progressBarAnalizer.Size = new System.Drawing.Size(643, 5);
            this.progressBarAnalizer.TabIndex = 6;
            // 
            // BtnLoadFile
            // 
            this.BtnLoadFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnLoadFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnLoadFile.Depth = 0;
            this.BtnLoadFile.HighEmphasis = true;
            this.BtnLoadFile.Icon = null;
            this.BtnLoadFile.Location = new System.Drawing.Point(497, 179);
            this.BtnLoadFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnLoadFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnLoadFile.Name = "BtnLoadFile";
            this.BtnLoadFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnLoadFile.Size = new System.Drawing.Size(145, 36);
            this.BtnLoadFile.TabIndex = 7;
            this.BtnLoadFile.Text = "Cargar Archivo";
            this.BtnLoadFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnLoadFile.UseAccentColor = false;
            this.BtnLoadFile.UseVisualStyleBackColor = true;
            this.BtnLoadFile.Click += new System.EventHandler(this.BtnLoadFile_Click);
            // 
            // BtnAnalizerFile
            // 
            this.BtnAnalizerFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnAnalizerFile.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnAnalizerFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.BtnAnalizerFile.Depth = 0;
            this.BtnAnalizerFile.HighEmphasis = true;
            this.BtnAnalizerFile.Icon = null;
            this.BtnAnalizerFile.Location = new System.Drawing.Point(552, 227);
            this.BtnAnalizerFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnAnalizerFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnAnalizerFile.Name = "BtnAnalizerFile";
            this.BtnAnalizerFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnAnalizerFile.Size = new System.Drawing.Size(90, 36);
            this.BtnAnalizerFile.TabIndex = 8;
            this.BtnAnalizerFile.Text = "Analizer";
            this.BtnAnalizerFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BtnAnalizerFile.UseAccentColor = true;
            this.BtnAnalizerFile.UseVisualStyleBackColor = false;
            this.BtnAnalizerFile.Click += new System.EventHandler(this.BtnAnalizerFile_Click);
            // 
            // BtnCopy
            // 
            this.BtnCopy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCopy.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnCopy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnCopy.Depth = 0;
            this.BtnCopy.DrawShadows = false;
            this.BtnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCopy.HighEmphasis = false;
            this.BtnCopy.Icon = null;
            this.BtnCopy.Location = new System.Drawing.Point(569, 115);
            this.BtnCopy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnCopy.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCopy.Name = "BtnCopy";
            this.BtnCopy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnCopy.Size = new System.Drawing.Size(73, 36);
            this.BtnCopy.TabIndex = 9;
            this.BtnCopy.Text = "Copiar";
            this.BtnCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCopy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.BtnCopy.UseAccentColor = true;
            this.BtnCopy.UseVisualStyleBackColor = false;
            this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // BtnCopyPath
            // 
            this.BtnCopyPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCopyPath.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnCopyPath.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnCopyPath.Depth = 0;
            this.BtnCopyPath.DrawShadows = false;
            this.BtnCopyPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCopyPath.HighEmphasis = false;
            this.BtnCopyPath.Icon = null;
            this.BtnCopyPath.Location = new System.Drawing.Point(569, 36);
            this.BtnCopyPath.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnCopyPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCopyPath.Name = "BtnCopyPath";
            this.BtnCopyPath.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnCopyPath.Size = new System.Drawing.Size(73, 36);
            this.BtnCopyPath.TabIndex = 10;
            this.BtnCopyPath.Text = "Copiar";
            this.BtnCopyPath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCopyPath.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.BtnCopyPath.UseAccentColor = true;
            this.BtnCopyPath.UseVisualStyleBackColor = false;
            this.BtnCopyPath.Click += new System.EventHandler(this.BtnCopyPath_Click);
            // 
            // BtnDeleteFile
            // 
            this.BtnDeleteFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDeleteFile.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnDeleteFile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnDeleteFile.Depth = 0;
            this.BtnDeleteFile.DrawShadows = false;
            this.BtnDeleteFile.Enabled = false;
            this.BtnDeleteFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteFile.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnDeleteFile.HighEmphasis = false;
            this.BtnDeleteFile.Icon = null;
            this.BtnDeleteFile.Location = new System.Drawing.Point(210, 189);
            this.BtnDeleteFile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnDeleteFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDeleteFile.Name = "BtnDeleteFile";
            this.BtnDeleteFile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnDeleteFile.Size = new System.Drawing.Size(89, 36);
            this.BtnDeleteFile.TabIndex = 11;
            this.BtnDeleteFile.Text = "Eliminar\r\nArchivo";
            this.BtnDeleteFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDeleteFile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.BtnDeleteFile.UseAccentColor = true;
            this.BtnDeleteFile.UseVisualStyleBackColor = false;
            this.BtnDeleteFile.Click += new System.EventHandler(this.BtnDeleteFile_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Analizador de Archivos";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Hash Analizador";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 281);
            this.Controls.Add(this.BtnDeleteFile);
            this.Controls.Add(this.BtnCopyPath);
            this.Controls.Add(this.BtnCopy);
            this.Controls.Add(this.BtnAnalizerFile);
            this.Controls.Add(this.BtnLoadFile);
            this.Controls.Add(this.progressBarAnalizer);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.LblDataBaseHash);
            this.Controls.Add(this.TxtHASHfile);
            this.Controls.Add(this.TxtFileInput);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HASH Detector";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 TxtFileInput;
        private MaterialSkin.Controls.MaterialTextBox2 TxtHASHfile;
        private MaterialSkin.Controls.MaterialLabel LblDataBaseHash;
        private MaterialSkin.Controls.MaterialLabel LblStatus;
        private MaterialSkin.Controls.MaterialProgressBar progressBarAnalizer;
        private MaterialSkin.Controls.MaterialButton BtnLoadFile;
        private MaterialSkin.Controls.MaterialButton BtnAnalizerFile;
        private MaterialSkin.Controls.MaterialButton BtnCopy;
        private MaterialSkin.Controls.MaterialButton BtnCopyPath;
        private MaterialSkin.Controls.MaterialButton BtnDeleteFile;
        private NotifyIcon notifyIcon1;
    }
}