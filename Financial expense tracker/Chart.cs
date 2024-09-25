using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Financial_expense_tracker
{
    public partial class frmChart : Form
    {
        public frmChart()
        {
            InitializeComponent();

            // Initialize the chart
            InitializeChart();
        }

        private void InitializeChart()
        {
            // Clear any existing data in the chart
            this.chart1.Series.Clear();

            // Define an array of categories
            string[] categories = { "Food", "Transport", "Saving", "Education" };

            // Add a series for each category
            foreach (string category in categories)
            {
                Series series = this.chart1.Series.Add(category);
                series.ChartType = SeriesChartType.Bar;

                // Populate data for all months
                string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
                Random random = new Random();

                foreach (string month in months)
                {
                    int amount = random.Next(1, 100); // Random amount between 1 and 100
                    series.Points.AddXY(month, amount);
                }
            }

            // Set the axis labels
            this.chart1.ChartAreas[0].AxisX.Title = "Months";
            this.chart1.ChartAreas[0].AxisY.Title = "Amount";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmWelcome().Show();
            this.Hide();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            // Chart click event handler (if needed)
        }
    }
}
