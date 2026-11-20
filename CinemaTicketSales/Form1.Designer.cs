namespace CinemaTicketSales
{
    partial class Form1
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
            cmbMovies = new ComboBox();
            lblMovie = new Label();
            rbStandard = new RadioButton();
            rbVIP = new RadioButton();
            rbBalcony = new RadioButton();
            txtTickets = new TextBox();
            lblTickets = new Label();
            chk3D = new CheckBox();
            chkDiscount = new CheckBox();
            btnSell = new Button();
            lstSales = new ListBox();
            lblHistory = new Label();
            lblFreeSeats = new Label();
            lblTotalTickets = new Label();
            lblTotalRevenue = new Label();
            lblAverage = new Label();
            SuspendLayout();
            // 
            // cmbMovies
            // 
            cmbMovies.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMovies.FormattingEnabled = true;
            cmbMovies.Location = new Point(12, 52);
            cmbMovies.Name = "cmbMovies";
            cmbMovies.Size = new Size(215, 33);
            cmbMovies.TabIndex = 0;
            // 
            // lblMovie
            // 
            lblMovie.AutoSize = true;
            lblMovie.Location = new Point(12, 24);
            lblMovie.Name = "lblMovie";
            lblMovie.Size = new Size(141, 25);
            lblMovie.TabIndex = 1;
            lblMovie.Text = "Изберете филм:";
            // 
            // rbStandard
            // 
            rbStandard.AutoSize = true;
            rbStandard.Checked = true;
            rbStandard.Location = new Point(12, 100);
            rbStandard.Name = "rbStandard";
            rbStandard.Size = new Size(192, 29);
            rbStandard.TabIndex = 2;
            rbStandard.TabStop = true;
            rbStandard.Text = "Стандартен партер";
            rbStandard.UseVisualStyleBackColor = true;
            // 
            // rbVIP
            // 
            rbVIP.AutoSize = true;
            rbVIP.Location = new Point(12, 135);
            rbVIP.Name = "rbVIP";
            rbVIP.Size = new Size(175, 29);
            rbVIP.TabIndex = 3;
            rbVIP.Text = "VIP ложа (+5 лв.)";
            rbVIP.UseVisualStyleBackColor = true;
            // 
            // rbBalcony
            // 
            rbBalcony.AutoSize = true;
            rbBalcony.Location = new Point(12, 170);
            rbBalcony.Name = "rbBalcony";
            rbBalcony.Size = new Size(150, 29);
            rbBalcony.TabIndex = 4;
            rbBalcony.Text = "Балкон(-2 лв.)";
            rbBalcony.UseVisualStyleBackColor = true;
            // 
            // txtTickets
            // 
            txtTickets.Location = new Point(12, 244);
            txtTickets.MaxLength = 2;
            txtTickets.Name = "txtTickets";
            txtTickets.Size = new Size(192, 31);
            txtTickets.TabIndex = 5;
            // 
            // lblTickets
            // 
            lblTickets.AutoSize = true;
            lblTickets.Location = new Point(12, 216);
            lblTickets.Name = "lblTickets";
            lblTickets.Size = new Size(118, 25);
            lblTickets.TabIndex = 6;
            lblTickets.Text = "Брой билети:";
            // 
            // chk3D
            // 
            chk3D.AutoSize = true;
            chk3D.Location = new Point(12, 292);
            chk3D.Name = "chk3D";
            chk3D.Size = new Size(175, 29);
            chk3D.TabIndex = 7;
            chk3D.Text = "3D очила(+2 лв.)";
            chk3D.UseVisualStyleBackColor = true;
            // 
            // chkDiscount
            // 
            chkDiscount.AutoSize = true;
            chkDiscount.Location = new Point(12, 327);
            chkDiscount.Name = "chkDiscount";
            chkDiscount.Size = new Size(234, 29);
            chkDiscount.TabIndex = 8;
            chkDiscount.Text = "Студентска карта (-20%)";
            chkDiscount.UseVisualStyleBackColor = true;
            // 
            // btnSell
            // 
            btnSell.Location = new Point(12, 362);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(168, 43);
            btnSell.TabIndex = 9;
            btnSell.Text = "Продай билети";
            btnSell.UseVisualStyleBackColor = true;
            btnSell.Click += btnSell_Click;
            // 
            // lstSales
            // 
            lstSales.FormattingEnabled = true;
            lstSales.ItemHeight = 25;
            lstSales.Location = new Point(427, 52);
            lstSales.Name = "lstSales";
            lstSales.Size = new Size(329, 154);
            lstSales.TabIndex = 10;
            // 
            // lblHistory
            // 
            lblHistory.AutoSize = true;
            lblHistory.Location = new Point(427, 24);
            lblHistory.Name = "lblHistory";
            lblHistory.Size = new Size(214, 25);
            lblHistory.TabIndex = 11;
            lblHistory.Text = "История на продажбите:";
            // 
            // lblFreeSeats
            // 
            lblFreeSeats.AutoSize = true;
            lblFreeSeats.Location = new Point(426, 216);
            lblFreeSeats.Name = "lblFreeSeats";
            lblFreeSeats.Size = new Size(175, 25);
            lblFreeSeats.TabIndex = 12;
            lblFreeSeats.Text = "Свободни места: 80";
            // 
            // lblTotalTickets
            // 
            lblTotalTickets.AutoSize = true;
            lblTotalTickets.Location = new Point(426, 241);
            lblTotalTickets.Name = "lblTotalTickets";
            lblTotalTickets.Size = new Size(236, 25);
            lblTotalTickets.TabIndex = 13;
            lblTotalTickets.Text = "Общо продадени билети: 0";
            lblTotalTickets.Click += label1_Click;
            // 
            // lblTotalRevenue
            // 
            lblTotalRevenue.AutoSize = true;
            lblTotalRevenue.Location = new Point(426, 266);
            lblTotalRevenue.Name = "lblTotalRevenue";
            lblTotalRevenue.Size = new Size(207, 25);
            lblTotalRevenue.TabIndex = 14;
            lblTotalRevenue.Text = "Общи приходи: 0.00 лв.";
            // 
            // lblAverage
            // 
            lblAverage.AutoSize = true;
            lblAverage.Location = new Point(426, 291);
            lblAverage.Name = "lblAverage";
            lblAverage.Size = new Size(283, 25);
            lblAverage.TabIndex = 15;
            lblAverage.Text = "Средна цена на покупка: 0.00 лв.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 464);
            Controls.Add(lblAverage);
            Controls.Add(lblTotalRevenue);
            Controls.Add(lblTotalTickets);
            Controls.Add(lblFreeSeats);
            Controls.Add(lblHistory);
            Controls.Add(lstSales);
            Controls.Add(btnSell);
            Controls.Add(chkDiscount);
            Controls.Add(chk3D);
            Controls.Add(lblTickets);
            Controls.Add(txtTickets);
            Controls.Add(rbBalcony);
            Controls.Add(rbVIP);
            Controls.Add(rbStandard);
            Controls.Add(lblMovie);
            Controls.Add(cmbMovies);
            Name = "Form1";
            Text = "Cinema Tickets Sales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMovies;
        private Label lblMovie;
        private RadioButton rbStandard;
        private RadioButton rbVIP;
        private RadioButton rbBalcony;
        private TextBox txtTickets;
        private Label lblTickets;
        private CheckBox chk3D;
        private CheckBox chkDiscount;
        private Button btnSell;
        private ListBox lstSales;
        private Label lblHistory;
        private Label lblFreeSeats;
        private Label lblTotalTickets;
        private Label lblTotalRevenue;
        private Label lblAverage;
    }
}
