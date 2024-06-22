namespace Calculator_Activity
{
    public partial class Form1 : Form
    {
        bool isPerformed = false;
        bool isDecimalUsed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void numClick(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            if (output.Text == "0")
                output.Clear();
            if (isPerformed == true)
            {
                output.Clear();
                isPerformed = false;
            }

            output.AppendText(btn.Text);
        }

        private void resetBtn_MouseClick(object sender, MouseEventArgs e)
        {
            output.Clear();
            output.Text = "0";
        }

        private void clearBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (output.Text.Length > 0 && output.Text != "0")
            {
                output.Text = output.Text.Remove(output.Text.Length - 1, 1);
                if (output.Text.Length == 0)
                    output.Text = "0";
            }
        }

        private void equalBtn_MouseClick(object sender, MouseEventArgs e)
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table.Columns.Add("expression", string.Empty.GetType(), output.Text);
            System.Data.DataRow row = table.NewRow();
            table.Rows.Add(row);
            double result = double.Parse((string)row["expression"]);

            isPerformed = true;
            output.Text = result.ToString();

        }

        private void operatorClick(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            if (output.Text == "0")
                output.Clear();
            if (isPerformed == true)
            {
                output.Clear();
                isPerformed = false;
            }

            isDecimalUsed = false;
            output.AppendText(btn.Text);
        }

        private void deciClick(object sender, MouseEventArgs e)
        {
            if (!isDecimalUsed)
            {
                if (isPerformed)
                {
                    output.Clear();
                    isPerformed = false;
                }

                if (string.IsNullOrEmpty(output.Text))
                {
                    output.Text = "0";
                }

                output.AppendText(".");
                isDecimalUsed = true;
            }

        }
    }
}
