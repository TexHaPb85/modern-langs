namespace lab2_browser
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.навігаторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обранеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.впередToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додомуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choosenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.введітьПосиланняДляБлокуванняToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.authorMishkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(8, 58);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(780, 211);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.UseWaitCursor = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "youtube.com",
            "google.com",
            "github.com",
            "facebook.com"});
            this.comboBox1.Location = new System.Drawing.Point(8, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Улюблені сайти";
            this.comboBox1.UseWaitCursor = true;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.навігаторToolStripMenuItem,
            this.обранеToolStripMenuItem,
            this.довідкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // навігаторToolStripMenuItem
            // 
            this.навігаторToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.впередToolStripMenuItem,
            this.назадToolStripMenuItem,
            this.додомуToolStripMenuItem});
            this.навігаторToolStripMenuItem.Name = "навігаторToolStripMenuItem";
            this.навігаторToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.навігаторToolStripMenuItem.Text = "навігатор";
            // 
            // обранеToolStripMenuItem
            // 
            this.обранеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choosenToolStripMenuItem,
            this.blockToolStripMenuItem});
            this.обранеToolStripMenuItem.Name = "обранеToolStripMenuItem";
            this.обранеToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.обранеToolStripMenuItem.Text = "обране";
            // 
            // довідкаToolStripMenuItem
            // 
            this.довідкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorMishkaToolStripMenuItem});
            this.довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            this.довідкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.довідкаToolStripMenuItem.Text = "довідка";
            // 
            // впередToolStripMenuItem
            // 
            this.впередToolStripMenuItem.Name = "впередToolStripMenuItem";
            this.впередToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.впередToolStripMenuItem.Text = "вперед";
            this.впередToolStripMenuItem.Click += new System.EventHandler(this.впередToolStripMenuItem_Click);
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.назадToolStripMenuItem.Text = "назад";
            this.назадToolStripMenuItem.Click += new System.EventHandler(this.назадToolStripMenuItem_Click);
            // 
            // додомуToolStripMenuItem
            // 
            this.додомуToolStripMenuItem.Name = "додомуToolStripMenuItem";
            this.додомуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.додомуToolStripMenuItem.Text = "додому";
            this.додомуToolStripMenuItem.Click += new System.EventHandler(this.додомуToolStripMenuItem_Click);
            // 
            // choosenToolStripMenuItem
            // 
            this.choosenToolStripMenuItem.Name = "choosenToolStripMenuItem";
            this.choosenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.choosenToolStripMenuItem.Text = "choosen";
            this.choosenToolStripMenuItem.Click += new System.EventHandler(this.choosenToolStripMenuItem_Click);
            // 
            // blockToolStripMenuItem
            // 
            this.blockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.введітьПосиланняДляБлокуванняToolStripMenuItem});
            this.blockToolStripMenuItem.Name = "blockToolStripMenuItem";
            this.blockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blockToolStripMenuItem.Text = "block";
            this.blockToolStripMenuItem.Click += new System.EventHandler(this.blockToolStripMenuItem_Click);
            // 
            // введітьПосиланняДляБлокуванняToolStripMenuItem
            // 
            this.введітьПосиланняДляБлокуванняToolStripMenuItem.Name = "введітьПосиланняДляБлокуванняToolStripMenuItem";
            this.введітьПосиланняДляБлокуванняToolStripMenuItem.Size = new System.Drawing.Size(265, 23);
            this.введітьПосиланняДляБлокуванняToolStripMenuItem.Text = "введіть посилання для блокування";
            this.введітьПосиланняДляБлокуванняToolStripMenuItem.Click += new System.EventHandler(this.введітьПосиланняДляБлокуванняToolStripMenuItem_Click);
            // 
            // authorMishkaToolStripMenuItem
            // 
            this.authorMishkaToolStripMenuItem.Name = "authorMishkaToolStripMenuItem";
            this.authorMishkaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.authorMishkaToolStripMenuItem.Text = "author - Mishka:)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 281);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Yevtushenko`s browser";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem навігаторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem впередToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додомуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обранеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choosenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox введітьПосиланняДляБлокуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorMishkaToolStripMenuItem;
    }
}

