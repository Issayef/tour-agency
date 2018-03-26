namespace tour_agency
{
    partial class Review
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxManager = new System.Windows.Forms.ComboBox();
            this.comboBoxHotel = new System.Windows.Forms.ComboBox();
            this.comboBoxFood = new System.Windows.Forms.ComboBox();
            this.comboBoxFlight = new System.Windows.Forms.ComboBox();
            this.comboBoxEx = new System.Windows.Forms.ComboBox();
            this.textBoxContract = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.richTextBoxReview = new System.Windows.Forms.RichTextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер договора:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Работа менеджера:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label3.Location = new System.Drawing.Point(97, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отель:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label4.Location = new System.Drawing.Point(29, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Питание в Отеле:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label5.Location = new System.Drawing.Point(46, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Авиакомпания:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label6.Location = new System.Drawing.Point(70, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Экскурсия:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(214, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Отзыв";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label8.Location = new System.Drawing.Point(51, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Комментарий:";
            // 
            // comboBoxManager
            // 
            this.comboBoxManager.AutoCompleteCustomSource.AddRange(new string[] {
            "1 2 3 4 5"});
            this.comboBoxManager.FormattingEnabled = true;
            this.comboBoxManager.Items.AddRange(new object[] {
            "1 ",
            "2 ",
            "3 ",
            "4 ",
            "5"});
            this.comboBoxManager.Location = new System.Drawing.Point(168, 89);
            this.comboBoxManager.Name = "comboBoxManager";
            this.comboBoxManager.Size = new System.Drawing.Size(197, 21);
            this.comboBoxManager.TabIndex = 8;
            // 
            // comboBoxHotel
            // 
            this.comboBoxHotel.AutoCompleteCustomSource.AddRange(new string[] {
            "1 2 3 4 5"});
            this.comboBoxHotel.FormattingEnabled = true;
            this.comboBoxHotel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxHotel.Location = new System.Drawing.Point(168, 123);
            this.comboBoxHotel.Name = "comboBoxHotel";
            this.comboBoxHotel.Size = new System.Drawing.Size(197, 21);
            this.comboBoxHotel.TabIndex = 9;
            // 
            // comboBoxFood
            // 
            this.comboBoxFood.AutoCompleteCustomSource.AddRange(new string[] {
            "1 2 3 4 5"});
            this.comboBoxFood.FormattingEnabled = true;
            this.comboBoxFood.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxFood.Location = new System.Drawing.Point(168, 156);
            this.comboBoxFood.Name = "comboBoxFood";
            this.comboBoxFood.Size = new System.Drawing.Size(197, 21);
            this.comboBoxFood.TabIndex = 10;
            // 
            // comboBoxFlight
            // 
            this.comboBoxFlight.AutoCompleteCustomSource.AddRange(new string[] {
            "1 2 3 4 5"});
            this.comboBoxFlight.FormattingEnabled = true;
            this.comboBoxFlight.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxFlight.Location = new System.Drawing.Point(168, 188);
            this.comboBoxFlight.Name = "comboBoxFlight";
            this.comboBoxFlight.Size = new System.Drawing.Size(197, 21);
            this.comboBoxFlight.TabIndex = 11;
            // 
            // comboBoxEx
            // 
            this.comboBoxEx.AutoCompleteCustomSource.AddRange(new string[] {
            "1 2 3 4 5"});
            this.comboBoxEx.FormattingEnabled = true;
            this.comboBoxEx.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxEx.Location = new System.Drawing.Point(168, 216);
            this.comboBoxEx.Name = "comboBoxEx";
            this.comboBoxEx.Size = new System.Drawing.Size(197, 21);
            this.comboBoxEx.TabIndex = 12;
            // 
            // textBoxContract
            // 
            this.textBoxContract.Location = new System.Drawing.Point(168, 54);
            this.textBoxContract.Name = "textBoxContract";
            this.textBoxContract.Size = new System.Drawing.Size(197, 20);
            this.textBoxContract.TabIndex = 14;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.buttonSave.Location = new System.Drawing.Point(236, 353);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(83, 35);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // richTextBoxReview
            // 
            this.richTextBoxReview.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.richTextBoxReview.Location = new System.Drawing.Point(168, 244);
            this.richTextBoxReview.Name = "richTextBoxReview";
            this.richTextBoxReview.Size = new System.Drawing.Size(197, 84);
            this.richTextBoxReview.TabIndex = 16;
            this.richTextBoxReview.Text = "";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.buttonClose.Location = new System.Drawing.Point(325, 353);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(83, 35);
            this.buttonClose.TabIndex = 17;
            this.buttonClose.Text = "Выход";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 406);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.richTextBoxReview);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxContract);
            this.Controls.Add(this.comboBoxEx);
            this.Controls.Add(this.comboBoxFlight);
            this.Controls.Add(this.comboBoxFood);
            this.Controls.Add(this.comboBoxHotel);
            this.Controls.Add(this.comboBoxManager);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Review";
            this.Text = "Review";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxManager;
        private System.Windows.Forms.ComboBox comboBoxHotel;
        private System.Windows.Forms.ComboBox comboBoxFood;
        private System.Windows.Forms.ComboBox comboBoxFlight;
        private System.Windows.Forms.ComboBox comboBoxEx;
        private System.Windows.Forms.TextBox textBoxContract;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.RichTextBox richTextBoxReview;
        private System.Windows.Forms.Button buttonClose;
    }
}