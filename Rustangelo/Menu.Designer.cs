
namespace Rustangelo
{
    partial class Menu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.ÜstPanel = new System.Windows.Forms.Panel();
            this.HassasiyetTxt = new System.Windows.Forms.Label();
            this.FovUpDown = new System.Windows.Forms.NumericUpDown();
            this.HassasiyetUpDown = new System.Windows.Forms.NumericUpDown();
            this.GörüsAlanıTxt = new System.Windows.Forms.Label();
            this.YumusaklikCBox = new System.Windows.Forms.CheckBox();
            this.EtkinCBox = new System.Windows.Forms.CheckBox();
            this.HeadUstPanel = new System.Windows.Forms.Panel();
            this.MinimizeTxtBtn = new System.Windows.Forms.Label();
            this.KapatTxtBtn = new System.Windows.Forms.Label();
            this.HeaderTitleTxt = new System.Windows.Forms.Label();
            this.AltPanel = new System.Windows.Forms.Panel();
            this.WebsiteTxtBtn = new System.Windows.Forms.Label();
            this.SilahCBox = new System.Windows.Forms.ComboBox();
            this.SilahTxt = new System.Windows.Forms.Label();
            this.EklentiTxt = new System.Windows.Forms.Label();
            this.DürbünTxt = new System.Windows.Forms.Label();
            this.EklentiCBox = new System.Windows.Forms.ComboBox();
            this.DürbünCBox = new System.Windows.Forms.ComboBox();
            this.YumusaklıkTBar = new System.Windows.Forms.TrackBar();
            this.YumuşaklıkTxt = new System.Windows.Forms.Label();
            this.ÜstPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FovUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HassasiyetUpDown)).BeginInit();
            this.HeadUstPanel.SuspendLayout();
            this.AltPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YumusaklıkTBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ÜstPanel
            // 
            this.ÜstPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ÜstPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.ÜstPanel.Controls.Add(this.HassasiyetTxt);
            this.ÜstPanel.Controls.Add(this.FovUpDown);
            this.ÜstPanel.Controls.Add(this.HassasiyetUpDown);
            this.ÜstPanel.Controls.Add(this.GörüsAlanıTxt);
            this.ÜstPanel.Controls.Add(this.YumusaklikCBox);
            this.ÜstPanel.Controls.Add(this.EtkinCBox);
            this.ÜstPanel.Location = new System.Drawing.Point(12, 28);
            this.ÜstPanel.Name = "ÜstPanel";
            this.ÜstPanel.Size = new System.Drawing.Size(200, 125);
            this.ÜstPanel.TabIndex = 0;
            // 
            // HassasiyetTxt
            // 
            this.HassasiyetTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HassasiyetTxt.AutoSize = true;
            this.HassasiyetTxt.BackColor = System.Drawing.Color.Transparent;
            this.HassasiyetTxt.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HassasiyetTxt.ForeColor = System.Drawing.Color.White;
            this.HassasiyetTxt.Location = new System.Drawing.Point(9, 70);
            this.HassasiyetTxt.Name = "HassasiyetTxt";
            this.HassasiyetTxt.Size = new System.Drawing.Size(103, 14);
            this.HassasiyetTxt.TabIndex = 6;
            this.HassasiyetTxt.Text = "Fare Hassasiyeti :";
            this.HassasiyetTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FovUpDown
            // 
            this.FovUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FovUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.FovUpDown.ForeColor = System.Drawing.Color.White;
            this.FovUpDown.Location = new System.Drawing.Point(117, 93);
            this.FovUpDown.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.FovUpDown.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.FovUpDown.Name = "FovUpDown";
            this.FovUpDown.Size = new System.Drawing.Size(70, 20);
            this.FovUpDown.TabIndex = 3;
            this.FovUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FovUpDown.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.FovUpDown.ValueChanged += new System.EventHandler(this.FovUpDown_ValueChanged);
            // 
            // HassasiyetUpDown
            // 
            this.HassasiyetUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HassasiyetUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.HassasiyetUpDown.DecimalPlaces = 2;
            this.HassasiyetUpDown.ForeColor = System.Drawing.Color.White;
            this.HassasiyetUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.HassasiyetUpDown.Location = new System.Drawing.Point(117, 67);
            this.HassasiyetUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            65536});
            this.HassasiyetUpDown.Name = "HassasiyetUpDown";
            this.HassasiyetUpDown.Size = new System.Drawing.Size(69, 20);
            this.HassasiyetUpDown.TabIndex = 4;
            this.HassasiyetUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HassasiyetUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.HassasiyetUpDown.ValueChanged += new System.EventHandler(this.HassasiyetUpDown_ValueChanged);
            // 
            // GörüsAlanıTxt
            // 
            this.GörüsAlanıTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GörüsAlanıTxt.AutoSize = true;
            this.GörüsAlanıTxt.BackColor = System.Drawing.Color.Transparent;
            this.GörüsAlanıTxt.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GörüsAlanıTxt.ForeColor = System.Drawing.Color.White;
            this.GörüsAlanıTxt.Location = new System.Drawing.Point(12, 96);
            this.GörüsAlanıTxt.Name = "GörüsAlanıTxt";
            this.GörüsAlanıTxt.Size = new System.Drawing.Size(77, 14);
            this.GörüsAlanıTxt.TabIndex = 5;
            this.GörüsAlanıTxt.Text = "Görüş Alanı :";
            this.GörüsAlanıTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YumusaklikCBox
            // 
            this.YumusaklikCBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YumusaklikCBox.AutoSize = true;
            this.YumusaklikCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YumusaklikCBox.ForeColor = System.Drawing.Color.White;
            this.YumusaklikCBox.Location = new System.Drawing.Point(11, 28);
            this.YumusaklikCBox.Name = "YumusaklikCBox";
            this.YumusaklikCBox.Size = new System.Drawing.Size(83, 17);
            this.YumusaklikCBox.TabIndex = 2;
            this.YumusaklikCBox.Text = "Yumşaklık";
            this.YumusaklikCBox.UseVisualStyleBackColor = true;
            this.YumusaklikCBox.CheckedChanged += new System.EventHandler(this.YumusaklikCBox_CheckedChanged);
            // 
            // EtkinCBox
            // 
            this.EtkinCBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EtkinCBox.AutoSize = true;
            this.EtkinCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EtkinCBox.ForeColor = System.Drawing.Color.White;
            this.EtkinCBox.Location = new System.Drawing.Point(12, 5);
            this.EtkinCBox.Name = "EtkinCBox";
            this.EtkinCBox.Size = new System.Drawing.Size(82, 17);
            this.EtkinCBox.TabIndex = 0;
            this.EtkinCBox.Text = "Etkinleştir";
            this.EtkinCBox.UseVisualStyleBackColor = true;
            this.EtkinCBox.CheckedChanged += new System.EventHandler(this.EtkinCBox_CheckedChanged);
            // 
            // HeadUstPanel
            // 
            this.HeadUstPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.HeadUstPanel.Controls.Add(this.WebsiteTxtBtn);
            this.HeadUstPanel.Controls.Add(this.MinimizeTxtBtn);
            this.HeadUstPanel.Controls.Add(this.KapatTxtBtn);
            this.HeadUstPanel.Controls.Add(this.HeaderTitleTxt);
            this.HeadUstPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadUstPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadUstPanel.Name = "HeadUstPanel";
            this.HeadUstPanel.Size = new System.Drawing.Size(227, 22);
            this.HeadUstPanel.TabIndex = 2;
            this.HeadUstPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadUstPanel_MouseDown);
            this.HeadUstPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadUstPanel_MouseMove);
            this.HeadUstPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeadUstPanel_MouseUp);
            // 
            // MinimizeTxtBtn
            // 
            this.MinimizeTxtBtn.AutoSize = true;
            this.MinimizeTxtBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeTxtBtn.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MinimizeTxtBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.MinimizeTxtBtn.Location = new System.Drawing.Point(187, 4);
            this.MinimizeTxtBtn.Name = "MinimizeTxtBtn";
            this.MinimizeTxtBtn.Size = new System.Drawing.Size(15, 15);
            this.MinimizeTxtBtn.TabIndex = 2;
            this.MinimizeTxtBtn.Text = "--";
            this.MinimizeTxtBtn.Click += new System.EventHandler(this.MinimizeTxtBtn_Click);
            // 
            // KapatTxtBtn
            // 
            this.KapatTxtBtn.AutoSize = true;
            this.KapatTxtBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KapatTxtBtn.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KapatTxtBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.KapatTxtBtn.Location = new System.Drawing.Point(208, 4);
            this.KapatTxtBtn.Name = "KapatTxtBtn";
            this.KapatTxtBtn.Size = new System.Drawing.Size(16, 15);
            this.KapatTxtBtn.TabIndex = 1;
            this.KapatTxtBtn.Text = "X";
            this.KapatTxtBtn.Click += new System.EventHandler(this.KapatTxtBtn_Click);
            // 
            // HeaderTitleTxt
            // 
            this.HeaderTitleTxt.AutoSize = true;
            this.HeaderTitleTxt.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HeaderTitleTxt.ForeColor = System.Drawing.SystemColors.Control;
            this.HeaderTitleTxt.Location = new System.Drawing.Point(3, 4);
            this.HeaderTitleTxt.Name = "HeaderTitleTxt";
            this.HeaderTitleTxt.Size = new System.Drawing.Size(104, 15);
            this.HeaderTitleTxt.TabIndex = 0;
            this.HeaderTitleTxt.Text = "Rustangelo PRO";
            this.HeaderTitleTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderTitleTxt_MouseDown);
            this.HeaderTitleTxt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderTitleTxt_MouseMove);
            this.HeaderTitleTxt.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeaderTitleTxt_MouseUp);
            // 
            // AltPanel
            // 
            this.AltPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AltPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.AltPanel.Controls.Add(this.YumuşaklıkTxt);
            this.AltPanel.Controls.Add(this.YumusaklıkTBar);
            this.AltPanel.Controls.Add(this.DürbünCBox);
            this.AltPanel.Controls.Add(this.EklentiCBox);
            this.AltPanel.Controls.Add(this.DürbünTxt);
            this.AltPanel.Controls.Add(this.EklentiTxt);
            this.AltPanel.Controls.Add(this.SilahTxt);
            this.AltPanel.Controls.Add(this.SilahCBox);
            this.AltPanel.Location = new System.Drawing.Point(12, 159);
            this.AltPanel.Name = "AltPanel";
            this.AltPanel.Size = new System.Drawing.Size(200, 183);
            this.AltPanel.TabIndex = 1;
            // 
            // WebsiteTxtBtn
            // 
            this.WebsiteTxtBtn.AutoSize = true;
            this.WebsiteTxtBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WebsiteTxtBtn.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WebsiteTxtBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.WebsiteTxtBtn.Location = new System.Drawing.Point(166, 4);
            this.WebsiteTxtBtn.Name = "WebsiteTxtBtn";
            this.WebsiteTxtBtn.Size = new System.Drawing.Size(14, 15);
            this.WebsiteTxtBtn.TabIndex = 3;
            this.WebsiteTxtBtn.Text = "?";
            this.WebsiteTxtBtn.Click += new System.EventHandler(this.WebsiteTxtBtn_Click);
            // 
            // SilahCBox
            // 
            this.SilahCBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SilahCBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SilahCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SilahCBox.FormattingEnabled = true;
            this.SilahCBox.Items.AddRange(new object[] {
            "Taaruz Tüfeği",
            "LR-300 Taaruz Tüfeği",
            "M249",
            "Özelleştirilmiş Hafif Makinalı",
            "MP5A4",
            "Thompson",
            "Yok"});
            this.SilahCBox.Location = new System.Drawing.Point(65, 22);
            this.SilahCBox.Name = "SilahCBox";
            this.SilahCBox.Size = new System.Drawing.Size(121, 21);
            this.SilahCBox.TabIndex = 9;
            this.SilahCBox.SelectedIndexChanged += new System.EventHandler(this.SilahCBox_SelectedIndexChanged);
            // 
            // SilahTxt
            // 
            this.SilahTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SilahTxt.AutoSize = true;
            this.SilahTxt.BackColor = System.Drawing.Color.Transparent;
            this.SilahTxt.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilahTxt.ForeColor = System.Drawing.Color.White;
            this.SilahTxt.Location = new System.Drawing.Point(9, 26);
            this.SilahTxt.Name = "SilahTxt";
            this.SilahTxt.Size = new System.Drawing.Size(39, 14);
            this.SilahTxt.TabIndex = 7;
            this.SilahTxt.Text = "Silah :";
            this.SilahTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EklentiTxt
            // 
            this.EklentiTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EklentiTxt.AutoSize = true;
            this.EklentiTxt.BackColor = System.Drawing.Color.Transparent;
            this.EklentiTxt.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EklentiTxt.ForeColor = System.Drawing.Color.White;
            this.EklentiTxt.Location = new System.Drawing.Point(9, 53);
            this.EklentiTxt.Name = "EklentiTxt";
            this.EklentiTxt.Size = new System.Drawing.Size(50, 14);
            this.EklentiTxt.TabIndex = 10;
            this.EklentiTxt.Text = "Eklenti :";
            this.EklentiTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DürbünTxt
            // 
            this.DürbünTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DürbünTxt.AutoSize = true;
            this.DürbünTxt.BackColor = System.Drawing.Color.Transparent;
            this.DürbünTxt.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DürbünTxt.ForeColor = System.Drawing.Color.White;
            this.DürbünTxt.Location = new System.Drawing.Point(9, 80);
            this.DürbünTxt.Name = "DürbünTxt";
            this.DürbünTxt.Size = new System.Drawing.Size(53, 14);
            this.DürbünTxt.TabIndex = 11;
            this.DürbünTxt.Text = "Dürbün :";
            this.DürbünTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EklentiCBox
            // 
            this.EklentiCBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EklentiCBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EklentiCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EklentiCBox.FormattingEnabled = true;
            this.EklentiCBox.Items.AddRange(new object[] {
            "Namlu Kuvvetlendirici",
            "Namlu Ağız Baskısı",
            "Susturucu",
            "Yok"});
            this.EklentiCBox.Location = new System.Drawing.Point(65, 50);
            this.EklentiCBox.Name = "EklentiCBox";
            this.EklentiCBox.Size = new System.Drawing.Size(121, 21);
            this.EklentiCBox.TabIndex = 12;
            this.EklentiCBox.SelectedIndexChanged += new System.EventHandler(this.EklentiCBox_SelectedIndexChanged);
            // 
            // DürbünCBox
            // 
            this.DürbünCBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DürbünCBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DürbünCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DürbünCBox.FormattingEnabled = true;
            this.DürbünCBox.Items.AddRange(new object[] {
            "Basit El Yapımı Nişangah",
            "Holografik Görüş",
            "8x Yakınlaştırma Dürbünü",
            "16X Optik Dürbün",
            "Yok"});
            this.DürbünCBox.Location = new System.Drawing.Point(65, 77);
            this.DürbünCBox.Name = "DürbünCBox";
            this.DürbünCBox.Size = new System.Drawing.Size(121, 21);
            this.DürbünCBox.TabIndex = 13;
            this.DürbünCBox.SelectedIndexChanged += new System.EventHandler(this.DürbünCBox_SelectedIndexChanged);
            // 
            // YumusaklıkTBar
            // 
            this.YumusaklıkTBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YumusaklıkTBar.Location = new System.Drawing.Point(12, 130);
            this.YumusaklıkTBar.Minimum = 1;
            this.YumusaklıkTBar.Name = "YumusaklıkTBar";
            this.YumusaklıkTBar.Size = new System.Drawing.Size(178, 45);
            this.YumusaklıkTBar.TabIndex = 14;
            this.YumusaklıkTBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.YumusaklıkTBar.Value = 1;
            this.YumusaklıkTBar.Scroll += new System.EventHandler(this.YumusaklıkTBar_Scroll);
            // 
            // YumuşaklıkTxt
            // 
            this.YumuşaklıkTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YumuşaklıkTxt.AutoSize = true;
            this.YumuşaklıkTxt.BackColor = System.Drawing.Color.Transparent;
            this.YumuşaklıkTxt.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YumuşaklıkTxt.ForeColor = System.Drawing.Color.White;
            this.YumuşaklıkTxt.Location = new System.Drawing.Point(21, 113);
            this.YumuşaklıkTxt.Name = "YumuşaklıkTxt";
            this.YumuşaklıkTxt.Size = new System.Drawing.Size(102, 14);
            this.YumuşaklıkTxt.TabIndex = 15;
            this.YumuşaklıkTxt.Text = "Yumuşaklık oranı";
            this.YumuşaklıkTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(227, 354);
            this.Controls.Add(this.AltPanel);
            this.Controls.Add(this.HeadUstPanel);
            this.Controls.Add(this.ÜstPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rustangelo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.ÜstPanel.ResumeLayout(false);
            this.ÜstPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FovUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HassasiyetUpDown)).EndInit();
            this.HeadUstPanel.ResumeLayout(false);
            this.HeadUstPanel.PerformLayout();
            this.AltPanel.ResumeLayout(false);
            this.AltPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YumusaklıkTBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ÜstPanel;
        private System.Windows.Forms.Panel HeadUstPanel;
        private System.Windows.Forms.Panel AltPanel;
        private System.Windows.Forms.CheckBox EtkinCBox;
        private System.Windows.Forms.CheckBox YumusaklikCBox;
        private System.Windows.Forms.NumericUpDown FovUpDown;
        private System.Windows.Forms.NumericUpDown HassasiyetUpDown;
        private System.Windows.Forms.Label GörüsAlanıTxt;
        private System.Windows.Forms.Label HassasiyetTxt;
        private System.Windows.Forms.Label HeaderTitleTxt;
        private System.Windows.Forms.Label KapatTxtBtn;
        private System.Windows.Forms.Label MinimizeTxtBtn;
        private System.Windows.Forms.Label WebsiteTxtBtn;
        private System.Windows.Forms.ComboBox SilahCBox;
        private System.Windows.Forms.Label SilahTxt;
        private System.Windows.Forms.Label EklentiTxt;
        private System.Windows.Forms.Label DürbünTxt;
        private System.Windows.Forms.ComboBox DürbünCBox;
        private System.Windows.Forms.ComboBox EklentiCBox;
        private System.Windows.Forms.Label YumuşaklıkTxt;
        private System.Windows.Forms.TrackBar YumusaklıkTBar;
    }
}

