namespace CinemaTicketSales
{
    public partial class Form1 : Form
    {
        int freeSeats = 80;
        int totalTickets = 0;
        double totalRevenue = 0;

        List<int> soldTickets = new List<int>();
        List<double> salePrices = new List<double>();

        public Form1()
        {
            InitializeComponent();

            cmbMovies.Items.Add("Avatar - 12 лв.");
            cmbMovies.Items.Add("Titanic - 14 лв.");
            cmbMovies.Items.Add("Interstellar - 16 лв.");
            cmbMovies.Items.Add("Inception - 12 лв.");

            cmbMovies.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (cmbMovies.SelectedIndex == -1)
            {
                MessageBox.Show("Моля, изберете филм!");

            }
            int count;
            if (!int.TryParse(txtTickets.Text, out count) || count < 1 || count > 10)
            {
                MessageBox.Show("Може да купите от 1 до 10 билета!");
                return;
            }

            if (count > freeSeats)
            {
                MessageBox.Show("Няма достатъчно свободни места!");
                return;
            }
            double price = 12;

            if (cmbMovies.SelectedIndex == 1)
            {
                price = 12;
            }
            else if (cmbMovies.SelectedIndex == 2)
            {
                price = 16;
            }

            if (rbVIP.Checked)
            {
                price += 5;
            }

            if (rbBalcony.Checked)
            {
                price -= 2;
            }

            if (chk3D.Checked)
            {
                price += 2;
            }

            if (chkDiscount.Checked)
            {
                price *= 0.80;
            }

            double total = price * count;
            MessageBox.Show("Обща цена" + total.ToString("F2") + " лв. ");

            string movie = cmbMovies.Text;
            lstSales.Items.Add(movie + " - " + count + "билета - " + total.ToString("F2") +
                " лв. ");

            soldTickets.Add(count);
            salePrices.Add(total);

            totalTickets = 0;
            totalRevenue = 0;

            for (int i = 0; i < soldTickets.Count; i++)
            {
                totalTickets += soldTickets[i];
                totalRevenue += salePrices[i];
            }

            double average = totalRevenue / salePrices.Count;
            freeSeats -= count;
            lblFreeSeats.Text = " Свободни места: " + freeSeats;
            lblTotalTickets.Text = " Общо продадени билета: " + totalTickets;
            lblTotalRevenue.Text = " Общи приходи " + totalRevenue.ToString("F2") + " лв. ";
            lblAverage.Text = "Средна цена на покупка: " + average.ToString("F2") + " лв. ";

            cmbMovies.SelectedIndex = -1;
            txtTickets.Clear();

            rbStandard.Checked = true;
            chk3D.Checked = false;
            chkDiscount.Checked = false;






        }

    }
}
