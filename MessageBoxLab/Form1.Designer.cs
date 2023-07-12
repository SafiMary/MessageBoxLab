namespace MessageBoxLab
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBoxgreen = new System.Windows.Forms.CheckBox();
            this.comboBoxButton = new System.Windows.Forms.ComboBox();
            this.labelColour = new System.Windows.Forms.Label();
            this.groupBoxCheckColour = new System.Windows.Forms.GroupBox();
            this.checkBoxwhite = new System.Windows.Forms.CheckBox();
            this.checkBoxred = new System.Windows.Forms.CheckBox();
            this.imageListIcon = new System.Windows.Forms.ImageList(this.components);
            this.groupBoxIcon = new System.Windows.Forms.GroupBox();
            this.checkBoxIcon3 = new System.Windows.Forms.CheckBox();
            this.checkBoxIcon2 = new System.Windows.Forms.CheckBox();
            this.checkBoxIcon1 = new System.Windows.Forms.CheckBox();
            this.listBoxIcon = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonMB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCheckColour.SuspendLayout();
            this.groupBoxIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBoxgreen
            // 
            this.checkBoxgreen.AutoSize = true;
            this.checkBoxgreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkBoxgreen.Location = new System.Drawing.Point(24, 44);
            this.checkBoxgreen.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxgreen.Name = "checkBoxgreen";
            this.checkBoxgreen.Size = new System.Drawing.Size(117, 29);
            this.checkBoxgreen.TabIndex = 4;
            this.checkBoxgreen.Text = "Зеленый";
            this.checkBoxgreen.UseVisualStyleBackColor = true;
            this.checkBoxgreen.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // comboBoxButton
            // 
            this.comboBoxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxButton.FormattingEnabled = true;
            this.comboBoxButton.Items.AddRange(new object[] {
            "OK",
            "OKCancel",
            "RetryCancel",
            "YesNo",
            "YesNoCancel"});
            this.comboBoxButton.Location = new System.Drawing.Point(449, 149);
            this.comboBoxButton.Name = "comboBoxButton";
            this.comboBoxButton.Size = new System.Drawing.Size(225, 33);
            this.comboBoxButton.TabIndex = 5;
            this.comboBoxButton.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelColour
            // 
            this.labelColour.AutoSize = true;
            this.labelColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColour.Location = new System.Drawing.Point(444, 118);
            this.labelColour.Name = "labelColour";
            this.labelColour.Size = new System.Drawing.Size(228, 25);
            this.labelColour.TabIndex = 6;
            this.labelColour.Text = "Выберите кнопку MBox";
            this.labelColour.Click += new System.EventHandler(this.labelColour_Click);
            // 
            // groupBoxCheckColour
            // 
            this.groupBoxCheckColour.Controls.Add(this.checkBoxwhite);
            this.groupBoxCheckColour.Controls.Add(this.checkBoxred);
            this.groupBoxCheckColour.Controls.Add(this.checkBoxgreen);
            this.groupBoxCheckColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCheckColour.Location = new System.Drawing.Point(12, 244);
            this.groupBoxCheckColour.Name = "groupBoxCheckColour";
            this.groupBoxCheckColour.Size = new System.Drawing.Size(241, 164);
            this.groupBoxCheckColour.TabIndex = 7;
            this.groupBoxCheckColour.TabStop = false;
            this.groupBoxCheckColour.Text = "Настройка цвета окна";
            this.groupBoxCheckColour.Enter += new System.EventHandler(this.groupBoxCheckColour_Enter);
            // 
            // checkBoxwhite
            // 
            this.checkBoxwhite.AutoSize = true;
            this.checkBoxwhite.Location = new System.Drawing.Point(24, 135);
            this.checkBoxwhite.Name = "checkBoxwhite";
            this.checkBoxwhite.Size = new System.Drawing.Size(94, 29);
            this.checkBoxwhite.TabIndex = 6;
            this.checkBoxwhite.Text = "Белый";
            this.checkBoxwhite.UseVisualStyleBackColor = true;
            this.checkBoxwhite.CheckedChanged += new System.EventHandler(this.checkBoxwhite_CheckedChanged);
            // 
            // checkBoxred
            // 
            this.checkBoxred.AutoSize = true;
            this.checkBoxred.ForeColor = System.Drawing.Color.Red;
            this.checkBoxred.Location = new System.Drawing.Point(24, 90);
            this.checkBoxred.Name = "checkBoxred";
            this.checkBoxred.Size = new System.Drawing.Size(113, 29);
            this.checkBoxred.TabIndex = 5;
            this.checkBoxred.Text = "Красный";
            this.checkBoxred.UseVisualStyleBackColor = true;
            this.checkBoxred.CheckedChanged += new System.EventHandler(this.checkBoxred_CheckedChanged);
            // 
            // imageListIcon
            // 
            this.imageListIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcon.ImageStream")));
            this.imageListIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcon.Images.SetKeyName(0, "witch-flight_38005.ico");
            this.imageListIcon.Images.SetKeyName(1, "astronomy_shiny_space_forecast_stars_sky_night_star_weather_icon_253972 (1).ico");
            this.imageListIcon.Images.SetKeyName(2, "sugar_sweet_candy_food_bear_gummy_icon_253930 (1).ico");
            // 
            // groupBoxIcon
            // 
            this.groupBoxIcon.Controls.Add(this.checkBoxIcon3);
            this.groupBoxIcon.Controls.Add(this.checkBoxIcon2);
            this.groupBoxIcon.Controls.Add(this.checkBoxIcon1);
            this.groupBoxIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxIcon.Location = new System.Drawing.Point(12, 12);
            this.groupBoxIcon.Name = "groupBoxIcon";
            this.groupBoxIcon.Size = new System.Drawing.Size(237, 190);
            this.groupBoxIcon.TabIndex = 8;
            this.groupBoxIcon.TabStop = false;
            this.groupBoxIcon.Text = "Выберите значок";
            // 
            // checkBoxIcon3
            // 
            this.checkBoxIcon3.AutoSize = true;
            this.checkBoxIcon3.ImageIndex = 2;
            this.checkBoxIcon3.ImageList = this.imageListIcon;
            this.checkBoxIcon3.Location = new System.Drawing.Point(16, 160);
            this.checkBoxIcon3.Name = "checkBoxIcon3";
            this.checkBoxIcon3.Size = new System.Drawing.Size(50, 32);
            this.checkBoxIcon3.TabIndex = 2;
            this.checkBoxIcon3.UseVisualStyleBackColor = true;
            this.checkBoxIcon3.CheckedChanged += new System.EventHandler(this.checkBoxIcon3_CheckedChanged_1);
            // 
            // checkBoxIcon2
            // 
            this.checkBoxIcon2.AutoSize = true;
            this.checkBoxIcon2.ImageIndex = 1;
            this.checkBoxIcon2.ImageList = this.imageListIcon;
            this.checkBoxIcon2.Location = new System.Drawing.Point(16, 106);
            this.checkBoxIcon2.Name = "checkBoxIcon2";
            this.checkBoxIcon2.Size = new System.Drawing.Size(50, 32);
            this.checkBoxIcon2.TabIndex = 1;
            this.checkBoxIcon2.UseVisualStyleBackColor = true;
            this.checkBoxIcon2.CheckedChanged += new System.EventHandler(this.checkBoxIcon2_CheckedChanged_1);
            // 
            // checkBoxIcon1
            // 
            this.checkBoxIcon1.AutoSize = true;
            this.checkBoxIcon1.ImageIndex = 0;
            this.checkBoxIcon1.ImageList = this.imageListIcon;
            this.checkBoxIcon1.Location = new System.Drawing.Point(16, 52);
            this.checkBoxIcon1.Name = "checkBoxIcon1";
            this.checkBoxIcon1.Size = new System.Drawing.Size(50, 32);
            this.checkBoxIcon1.TabIndex = 0;
            this.checkBoxIcon1.TabStop = false;
            this.checkBoxIcon1.UseVisualStyleBackColor = true;
            this.checkBoxIcon1.CheckedChanged += new System.EventHandler(this.checkBoxIcon1_CheckedChanged);
            // 
            // listBoxIcon
            // 
            this.listBoxIcon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxIcon.FormattingEnabled = true;
            this.listBoxIcon.ItemHeight = 20;
            this.listBoxIcon.Items.AddRange(new object[] {
            "предупреждение",
            "стоп",
            "вопрос",
            "информация"});
            this.listBoxIcon.Location = new System.Drawing.Point(449, 260);
            this.listBoxIcon.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxIcon.Name = "listBoxIcon";
            this.listBoxIcon.Size = new System.Drawing.Size(225, 104);
            this.listBoxIcon.TabIndex = 9;
            this.listBoxIcon.SelectedIndexChanged += new System.EventHandler(this.listBoxIcon_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(444, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Выберите иконки в MsBox";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInput.Location = new System.Drawing.Point(449, 45);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(225, 30);
            this.textBoxInput.TabIndex = 11;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // buttonMB
            // 
            this.buttonMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMB.Location = new System.Drawing.Point(789, 395);
            this.buttonMB.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMB.Name = "buttonMB";
            this.buttonMB.Size = new System.Drawing.Size(164, 35);
            this.buttonMB.TabIndex = 12;
            this.buttonMB.Text = "Результат";
            this.buttonMB.UseVisualStyleBackColor = true;
            this.buttonMB.Click += new System.EventHandler(this.buttonMB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(444, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Введите текст";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMB);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxIcon);
            this.Controls.Add(this.groupBoxIcon);
            this.Controls.Add(this.groupBoxCheckColour);
            this.Controls.Add(this.labelColour);
            this.Controls.Add(this.comboBoxButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCheckColour.ResumeLayout(false);
            this.groupBoxCheckColour.PerformLayout();
            this.groupBoxIcon.ResumeLayout(false);
            this.groupBoxIcon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBoxgreen;
        private System.Windows.Forms.ComboBox comboBoxButton;
        private System.Windows.Forms.Label labelColour;
        private System.Windows.Forms.GroupBox groupBoxCheckColour;
        private System.Windows.Forms.CheckBox checkBoxred;
        private System.Windows.Forms.CheckBox checkBoxwhite;
        private System.Windows.Forms.ImageList imageListIcon;
        private System.Windows.Forms.GroupBox groupBoxIcon;
        private System.Windows.Forms.CheckBox checkBoxIcon3;
        private System.Windows.Forms.CheckBox checkBoxIcon2;
        private System.Windows.Forms.CheckBox checkBoxIcon1;
        private System.Windows.Forms.ListBox listBoxIcon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonMB;
        private System.Windows.Forms.Label label1;
        //        groupBox = new System.Windows.Forms.GroupBox();
        //checkBoxgreen = new System.Windows.Forms.CheckBox();
        //checkBoxred = new System.Windows.Forms.CheckBox();
        //checkBoxwhite = new System.Windows.Forms.CheckBox();
    }
}

