namespace Converter.View
{
    partial class ConverterView
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbImages = new System.Windows.Forms.ListBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbGif = new System.Windows.Forms.CheckBox();
            this.cbIcon = new System.Windows.Forms.CheckBox();
            this.cbTiff = new System.Windows.Forms.CheckBox();
            this.cbPng = new System.Windows.Forms.CheckBox();
            this.cbJpg = new System.Windows.Forms.CheckBox();
            this.cbBmp = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaveFilePath = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtOpenImages = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteList = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnResize = new System.Windows.Forms.Button();
            this.tbFactor = new System.Windows.Forms.NumericUpDown();
            this.converterViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.converterViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmToolStripMenuItem,
            this.konfigurationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmToolStripMenuItem
            // 
            this.programmToolStripMenuItem.Name = "programmToolStripMenuItem";
            this.programmToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programmToolStripMenuItem.Text = "Programm";
            // 
            // konfigurationToolStripMenuItem
            // 
            this.konfigurationToolStripMenuItem.Name = "konfigurationToolStripMenuItem";
            this.konfigurationToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.konfigurationToolStripMenuItem.Text = "Konfiguration";
            // 
            // lbImages
            // 
            this.lbImages.FormattingEnabled = true;
            this.lbImages.Location = new System.Drawing.Point(386, 44);
            this.lbImages.Name = "lbImages";
            this.lbImages.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbImages.Size = new System.Drawing.Size(366, 407);
            this.lbImages.TabIndex = 2;
            this.lbImages.SelectedIndexChanged += new System.EventHandler(this.lbImages_SelectedIndexChanged);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbJpg);
            this.groupBox1.Controls.Add(this.cbBmp);
            this.groupBox1.Controls.Add(this.cbIcon);
            this.groupBox1.Controls.Add(this.cbGif);
            this.groupBox1.Controls.Add(this.cbTiff);
            this.groupBox1.Controls.Add(this.cbPng);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Konvertiere in:";
            // 
            // cbGif
            // 
            this.cbGif.AutoSize = true;
            this.cbGif.Location = new System.Drawing.Point(129, 64);
            this.cbGif.Name = "cbGif";
            this.cbGif.Size = new System.Drawing.Size(43, 17);
            this.cbGif.TabIndex = 6;
            this.cbGif.Text = "GIF";
            this.cbGif.UseVisualStyleBackColor = true;
            this.cbGif.CheckStateChanged += new System.EventHandler(this.cbGif_CheckStateChanged);
            // 
            // cbIcon
            // 
            this.cbIcon.AutoSize = true;
            this.cbIcon.Location = new System.Drawing.Point(267, 29);
            this.cbIcon.Name = "cbIcon";
            this.cbIcon.Size = new System.Drawing.Size(52, 17);
            this.cbIcon.TabIndex = 5;
            this.cbIcon.Text = "ICON";
            this.cbIcon.UseVisualStyleBackColor = true;
            this.cbIcon.CheckStateChanged += new System.EventHandler(this.cbIcon_CheckStateChanged);
            // 
            // cbTiff
            // 
            this.cbTiff.AutoSize = true;
            this.cbTiff.Location = new System.Drawing.Point(267, 64);
            this.cbTiff.Name = "cbTiff";
            this.cbTiff.Size = new System.Drawing.Size(48, 17);
            this.cbTiff.TabIndex = 3;
            this.cbTiff.Text = "TIFF";
            this.cbTiff.UseVisualStyleBackColor = true;
            this.cbTiff.CheckStateChanged += new System.EventHandler(this.cbTiff_CheckStateChanged);
            // 
            // cbPng
            // 
            this.cbPng.AutoSize = true;
            this.cbPng.Location = new System.Drawing.Point(129, 29);
            this.cbPng.Name = "cbPng";
            this.cbPng.Size = new System.Drawing.Size(49, 17);
            this.cbPng.TabIndex = 2;
            this.cbPng.Text = "PNG";
            this.cbPng.UseVisualStyleBackColor = true;
            this.cbPng.CheckStateChanged += new System.EventHandler(this.cbPng_CheckedStateChanged);
            // 
            // cbJpg
            // 
            this.cbJpg.AutoSize = true;
            this.cbJpg.Location = new System.Drawing.Point(15, 64);
            this.cbJpg.Name = "cbJpg";
            this.cbJpg.Size = new System.Drawing.Size(46, 17);
            this.cbJpg.TabIndex = 1;
            this.cbJpg.Text = "JPG";
            this.cbJpg.UseVisualStyleBackColor = true;
            this.cbJpg.CheckStateChanged += new System.EventHandler(this.cbJpg_CheckStateChanged);
            // 
            // cbBmp
            // 
            this.cbBmp.AutoSize = true;
            this.cbBmp.Location = new System.Drawing.Point(15, 29);
            this.cbBmp.Name = "cbBmp";
            this.cbBmp.Size = new System.Drawing.Size(49, 17);
            this.cbBmp.TabIndex = 0;
            this.cbBmp.Text = "BMP";
            this.cbBmp.UseVisualStyleBackColor = true;
            this.cbBmp.CheckStateChanged += new System.EventHandler(this.cbBmp_CheckStateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Speichern unter:";
            // 
            // txtSaveFilePath
            // 
            this.txtSaveFilePath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSaveFilePath.Location = new System.Drawing.Point(103, 35);
            this.txtSaveFilePath.Name = "txtSaveFilePath";
            this.txtSaveFilePath.Size = new System.Drawing.Size(181, 20);
            this.txtSaveFilePath.TabIndex = 5;
            this.txtSaveFilePath.Click += new System.EventHandler(this.txtSaveFilePath_Click);
            this.txtSaveFilePath.TextChanged += new System.EventHandler(this.txtSaveFilePath_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConvert.Location = new System.Drawing.Point(264, 427);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Konvertieren";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtOpenImages
            // 
            this.txtOpenImages.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtOpenImages.Location = new System.Drawing.Point(103, 70);
            this.txtOpenImages.Name = "txtOpenImages";
            this.txtOpenImages.Size = new System.Drawing.Size(181, 20);
            this.txtOpenImages.TabIndex = 8;
            this.txtOpenImages.Click += new System.EventHandler(this.txtOpenImages_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bilder öffnen";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnDeleteList
            // 
            this.btnDeleteList.Location = new System.Drawing.Point(12, 427);
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteList.TabIndex = 9;
            this.btnDeleteList.Text = "Lösche Liste";
            this.btnDeleteList.UseVisualStyleBackColor = true;
            this.btnDeleteList.Click += new System.EventHandler(this.btnDeleteList_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbFactor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 65);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resize";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Faktor:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtOpenImages);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtSaveFilePath);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 169);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 116);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datei:";
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(130, 427);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(75, 23);
            this.btnResize.TabIndex = 12;
            this.btnResize.Text = "Resize";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // tbFactor
            // 
            this.tbFactor.DecimalPlaces = 3;
            this.tbFactor.Location = new System.Drawing.Point(73, 38);
            this.tbFactor.Name = "tbFactor";
            this.tbFactor.Size = new System.Drawing.Size(120, 20);
            this.tbFactor.TabIndex = 2;
            this.tbFactor.ValueChanged += new System.EventHandler(this.tbFactor_ValueChanged);
            // 
            // converterViewBindingSource
            // 
            this.converterViewBindingSource.DataSource = typeof(Converter.View.ConverterView);
            // 
            // ConverterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 466);
            this.Controls.Add(this.btnDeleteList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbImages);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ConverterView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ConverterView_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.converterViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konfigurationToolStripMenuItem;
        private System.Windows.Forms.ListBox lbImages;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaveFilePath;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtOpenImages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource converterViewBindingSource;
        private System.Windows.Forms.Button btnDeleteList;
        private System.Windows.Forms.CheckBox cbPng;
        private System.Windows.Forms.CheckBox cbJpg;
        private System.Windows.Forms.CheckBox cbBmp;
        private System.Windows.Forms.CheckBox cbIcon;
        private System.Windows.Forms.CheckBox cbTiff;
        private System.Windows.Forms.CheckBox cbGif;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown tbFactor;
    }
}

