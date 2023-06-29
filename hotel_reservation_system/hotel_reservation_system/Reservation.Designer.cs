namespace hotel_reservation_system
{
    partial class Reservation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addresstextbox = new System.Windows.Forms.TextBox();
            this.phonetextbox = new System.Windows.Forms.TextBox();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateoutTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateinTimePicker = new System.Windows.Forms.DateTimePicker();
            this.typecombobox = new System.Windows.Forms.ComboBox();
            this.Nobutton = new System.Windows.Forms.RadioButton();
            this.Yesbutton = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book a room with us:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addresstextbox);
            this.groupBox1.Controls.Add(this.phonetextbox);
            this.groupBox1.Controls.Add(this.nametextbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(114, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 348);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Detail";
            // 
            // addresstextbox
            // 
            this.addresstextbox.Location = new System.Drawing.Point(144, 198);
            this.addresstextbox.Multiline = true;
            this.addresstextbox.Name = "addresstextbox";
            this.addresstextbox.Size = new System.Drawing.Size(331, 41);
            this.addresstextbox.TabIndex = 2;
            this.addresstextbox.TextChanged += new System.EventHandler(this.addresstextbox_TextChanged);
            // 
            // phonetextbox
            // 
            this.phonetextbox.Location = new System.Drawing.Point(144, 98);
            this.phonetextbox.Multiline = true;
            this.phonetextbox.Name = "phonetextbox";
            this.phonetextbox.Size = new System.Drawing.Size(331, 41);
            this.phonetextbox.TabIndex = 3;
            this.phonetextbox.TextChanged += new System.EventHandler(this.phonetextbox_TextChanged);
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(109, 25);
            this.nametextbox.Multiline = true;
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(354, 40);
            this.nametextbox.TabIndex = 4;
            this.nametextbox.TextChanged += new System.EventHandler(this.nametextbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telephone:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateoutTimePicker);
            this.groupBox2.Controls.Add(this.dateinTimePicker);
            this.groupBox2.Controls.Add(this.typecombobox);
            this.groupBox2.Controls.Add(this.Nobutton);
            this.groupBox2.Controls.Add(this.Yesbutton);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1027, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 348);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Booking Detail";
            // 
            // dateoutTimePicker
            // 
            this.dateoutTimePicker.Location = new System.Drawing.Point(159, 167);
            this.dateoutTimePicker.Name = "dateoutTimePicker";
            this.dateoutTimePicker.Size = new System.Drawing.Size(208, 26);
            this.dateoutTimePicker.TabIndex = 6;
            this.dateoutTimePicker.ValueChanged += new System.EventHandler(this.dateoutTimePicker_ValueChanged);
            // 
            // dateinTimePicker
            // 
            this.dateinTimePicker.Location = new System.Drawing.Point(159, 105);
            this.dateinTimePicker.Name = "dateinTimePicker";
            this.dateinTimePicker.Size = new System.Drawing.Size(208, 26);
            this.dateinTimePicker.TabIndex = 5;
            this.dateinTimePicker.ValueChanged += new System.EventHandler(this.dateinTimePicker_ValueChanged);
            // 
            // typecombobox
            // 
            this.typecombobox.FormattingEnabled = true;
            this.typecombobox.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Family",
            "Suite"});
            this.typecombobox.Location = new System.Drawing.Point(159, 54);
            this.typecombobox.Name = "typecombobox";
            this.typecombobox.Size = new System.Drawing.Size(208, 28);
            this.typecombobox.TabIndex = 3;
            this.typecombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Nobutton
            // 
            this.Nobutton.AutoSize = true;
            this.Nobutton.Location = new System.Drawing.Point(93, 242);
            this.Nobutton.Name = "Nobutton";
            this.Nobutton.Size = new System.Drawing.Size(56, 24);
            this.Nobutton.TabIndex = 3;
            this.Nobutton.TabStop = true;
            this.Nobutton.Text = "No";
            this.Nobutton.UseVisualStyleBackColor = true;
            // 
            // Yesbutton
            // 
            this.Yesbutton.AutoSize = true;
            this.Yesbutton.Location = new System.Drawing.Point(93, 212);
            this.Yesbutton.Name = "Yesbutton";
            this.Yesbutton.Size = new System.Drawing.Size(65, 24);
            this.Yesbutton.TabIndex = 4;
            this.Yesbutton.TabStop = true;
            this.Yesbutton.Text = "Yes";
            this.Yesbutton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Pet:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Date Out:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Date in:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Room Type:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(720, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Make Reservation";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1746, 835);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox addresstextbox;
        private System.Windows.Forms.TextBox phonetextbox;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton Nobutton;
        private System.Windows.Forms.RadioButton Yesbutton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox typecombobox;
        private System.Windows.Forms.DateTimePicker dateoutTimePicker;
        private System.Windows.Forms.DateTimePicker dateinTimePicker;
        private System.Windows.Forms.Button button1;
    }
}