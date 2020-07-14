namespace PracticeWorkVKURS
{
    partial class GeneralWindow
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
            this.comboBoxBanksCitySelector = new System.Windows.Forms.ComboBox();
            this.comboBoxCurrencySelector = new System.Windows.Forms.ComboBox();
            this.listViewBanks = new System.Windows.Forms.ListView();
            this.columnHeader0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewCurrencies = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFindBanks = new System.Windows.Forms.Button();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.checkBoxSell = new System.Windows.Forms.CheckBox();
            this.checkBoxBuy = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCurrentDateData = new System.Windows.Forms.Label();
            this.buttonInternetStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxBanksCitySelector
            // 
            this.comboBoxBanksCitySelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxBanksCitySelector.FormattingEnabled = true;
            this.comboBoxBanksCitySelector.Location = new System.Drawing.Point(10, 93);
            this.comboBoxBanksCitySelector.Name = "comboBoxBanksCitySelector";
            this.comboBoxBanksCitySelector.Size = new System.Drawing.Size(380, 33);
            this.comboBoxBanksCitySelector.TabIndex = 5;
            this.comboBoxBanksCitySelector.Text = "Все города";
            this.comboBoxBanksCitySelector.SelectedIndexChanged += new System.EventHandler(this.comboBoxBanksCitySelector_SelectedIndexChanged);
            // 
            // comboBoxCurrencySelector
            // 
            this.comboBoxCurrencySelector.FormattingEnabled = true;
            this.comboBoxCurrencySelector.Location = new System.Drawing.Point(10, 45);
            this.comboBoxCurrencySelector.Name = "comboBoxCurrencySelector";
            this.comboBoxCurrencySelector.Size = new System.Drawing.Size(380, 33);
            this.comboBoxCurrencySelector.TabIndex = 6;
            this.comboBoxCurrencySelector.Text = "Все валюты";
            this.comboBoxCurrencySelector.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrencySelector_SelectedIndexChanged);
            // 
            // listViewBanks
            // 
            this.listViewBanks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewBanks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.listViewBanks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewBanks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader0,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewBanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewBanks.FullRowSelect = true;
            this.listViewBanks.HideSelection = false;
            this.listViewBanks.Location = new System.Drawing.Point(3, 40);
            this.listViewBanks.MultiSelect = false;
            this.listViewBanks.Name = "listViewBanks";
            this.listViewBanks.Size = new System.Drawing.Size(579, 667);
            this.listViewBanks.TabIndex = 6;
            this.listViewBanks.UseCompatibleStateImageBehavior = false;
            this.listViewBanks.View = System.Windows.Forms.View.Details;
            this.listViewBanks.SelectedIndexChanged += new System.EventHandler(this.listViewBanks_SelectedIndexChanged);
            // 
            // columnHeader0
            // 
            this.columnHeader0.Text = "id";
            this.columnHeader0.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Банк";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Регион";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Город";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Адрес";
            this.columnHeader4.Width = 200;
            // 
            // listViewCurrencies
            // 
            this.listViewCurrencies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCurrencies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.listViewCurrencies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewCurrencies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader5,
            this.columnHeader12,
            this.columnHeader13});
            this.listViewCurrencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listViewCurrencies.HideSelection = false;
            this.listViewCurrencies.Location = new System.Drawing.Point(596, 48);
            this.listViewCurrencies.Name = "listViewCurrencies";
            this.listViewCurrencies.Size = new System.Drawing.Size(740, 451);
            this.listViewCurrencies.TabIndex = 8;
            this.listViewCurrencies.UseCompatibleStateImageBehavior = false;
            this.listViewCurrencies.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Валюта";
            this.columnHeader11.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Полное название";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Покупка";
            this.columnHeader12.Width = 90;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Продажа";
            this.columnHeader13.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(5, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Используйте точку как разделитель!";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.buttonFindBanks);
            this.panel1.Controls.Add(this.textBoxTo);
            this.panel1.Controls.Add(this.textBoxFrom);
            this.panel1.Controls.Add(this.checkBoxSell);
            this.panel1.Controls.Add(this.checkBoxBuy);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel1.Location = new System.Drawing.Point(1008, 505);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 204);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(134, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 18);
            this.label6.TabIndex = 20;
            this.label6.Text = "до";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(15, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "от";
            // 
            // buttonFindBanks
            // 
            this.buttonFindBanks.AutoSize = true;
            this.buttonFindBanks.Location = new System.Drawing.Point(8, 150);
            this.buttonFindBanks.Name = "buttonFindBanks";
            this.buttonFindBanks.Size = new System.Drawing.Size(137, 42);
            this.buttonFindBanks.TabIndex = 18;
            this.buttonFindBanks.Text = "Найти банки";
            this.buttonFindBanks.UseVisualStyleBackColor = true;
            this.buttonFindBanks.Click += new System.EventHandler(this.buttonFindBanks_Click);
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(128, 54);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(100, 30);
            this.textBoxTo.TabIndex = 17;
            this.textBoxTo.Text = "до";
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(8, 54);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(100, 30);
            this.textBoxFrom.TabIndex = 16;
            this.textBoxFrom.Text = "от";
            // 
            // checkBoxSell
            // 
            this.checkBoxSell.AutoSize = true;
            this.checkBoxSell.Location = new System.Drawing.Point(185, 163);
            this.checkBoxSell.Name = "checkBoxSell";
            this.checkBoxSell.Size = new System.Drawing.Size(119, 29);
            this.checkBoxSell.TabIndex = 15;
            this.checkBoxSell.Text = "Продажа";
            this.checkBoxSell.UseVisualStyleBackColor = true;
            // 
            // checkBoxBuy
            // 
            this.checkBoxBuy.AutoSize = true;
            this.checkBoxBuy.Location = new System.Drawing.Point(185, 128);
            this.checkBoxBuy.Name = "checkBoxBuy";
            this.checkBoxBuy.Size = new System.Drawing.Size(109, 29);
            this.checkBoxBuy.TabIndex = 14;
            this.checkBoxBuy.Text = "Покупка";
            this.checkBoxBuy.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Выберите желаемый курс";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBoxCurrencySelector);
            this.panel2.Controls.Add(this.comboBoxBanksCitySelector);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel2.Location = new System.Drawing.Point(596, 505);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 204);
            this.panel2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Фильтр";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.listViewBanks);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Location = new System.Drawing.Point(5, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(585, 710);
            this.panel3.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(186)))), ((int)(((byte)(174)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.обновитьИнформациюToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(585, 31);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(72, 27);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // обновитьИнформациюToolStripMenuItem
            // 
            this.обновитьИнформациюToolStripMenuItem.Name = "обновитьИнформациюToolStripMenuItem";
            this.обновитьИнформациюToolStripMenuItem.Size = new System.Drawing.Size(166, 27);
            this.обновитьИнформациюToolStripMenuItem.Text = "Обновить данные";
            this.обновитьИнформациюToolStripMenuItem.Click += new System.EventHandler(this.обновитьИнформациюToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(131, 27);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(73, 27);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(601, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Данные за: ";
            // 
            // labelCurrentDateData
            // 
            this.labelCurrentDateData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentDateData.AutoSize = true;
            this.labelCurrentDateData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCurrentDateData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCurrentDateData.Location = new System.Drawing.Point(741, 9);
            this.labelCurrentDateData.Name = "labelCurrentDateData";
            this.labelCurrentDateData.Size = new System.Drawing.Size(121, 25);
            this.labelCurrentDateData.TabIndex = 17;
            this.labelCurrentDateData.Text = "неизвестно";
            // 
            // buttonInternetStatus
            // 
            this.buttonInternetStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInternetStatus.AutoSize = true;
            this.buttonInternetStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonInternetStatus.ForeColor = System.Drawing.Color.Red;
            this.buttonInternetStatus.Location = new System.Drawing.Point(1153, 9);
            this.buttonInternetStatus.Name = "buttonInternetStatus";
            this.buttonInternetStatus.Size = new System.Drawing.Size(0, 25);
            this.buttonInternetStatus.TabIndex = 18;
            // 
            // GeneralWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.buttonInternetStatus);
            this.Controls.Add(this.labelCurrentDateData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewCurrencies);
            this.Name = "GeneralWindow";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxBanksCitySelector;
        private System.Windows.Forms.ListView listViewBanks;
        private System.Windows.Forms.ColumnHeader columnHeader0;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listViewCurrencies;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox comboBoxCurrencySelector;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьИнформациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCurrentDateData;
        private System.Windows.Forms.CheckBox checkBoxSell;
        private System.Windows.Forms.CheckBox checkBoxBuy;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Button buttonFindBanks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label buttonInternetStatus;
    }
}

