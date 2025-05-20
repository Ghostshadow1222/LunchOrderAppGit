namespace LunchOrderAppGit
{
    public partial class Form1 : Form
    {
        private const decimal HAMBURGER_PRICE = 6.95m;
        private const decimal PIZZA_PRICE = 5.95m;
        private const decimal SALAD_PRICE = 4.95m;
        private const decimal HAMBURGER_ADDON_PRICE = 0.75m;
        private const decimal PIZZA_ADDON_PRICE = 0.50m;
        private const decimal SALAD_ADDON_PRICE = 0.25m;
        private const decimal TAX_RATE = 0.0775m;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0m;

            if (HamburgerRdo.Checked)
            {
                subtotal = HAMBURGER_PRICE;
                if (HamburgerSide1Cbo.Checked) subtotal += HAMBURGER_ADDON_PRICE;
                if (HamburgerSide2Cbo.Checked) subtotal += HAMBURGER_ADDON_PRICE;
                if (HamburgerSide3Cbo.Checked) subtotal += HAMBURGER_ADDON_PRICE;
            }
            else if (PizzaRdo.Checked)
            {
                subtotal = PIZZA_PRICE;
                if (PizzaSide1Cbo.Checked) subtotal += PIZZA_ADDON_PRICE;
                if (PizzaSide2Cbo.Checked) subtotal += PIZZA_ADDON_PRICE;
                if (PizzaSide3Cbo.Checked) subtotal += PIZZA_ADDON_PRICE;
            }
            else if (SaladRdo.Checked)
            {
                subtotal = SALAD_PRICE;
                if (SaladSide1Cbo.Checked) subtotal += SALAD_ADDON_PRICE;
                if (SaladSide2Cbo.Checked) subtotal += SALAD_ADDON_PRICE;
                if (SaladSide3Cbo.Checked) subtotal += SALAD_ADDON_PRICE;
            }

            decimal tax = subtotal * TAX_RATE;
            decimal total = subtotal + tax;

            SubtotalTxt.Text = subtotal.ToString("c");
            TaxTxt.Text = tax.ToString("c");
            OrderTotalTxt.Text = total.ToString("c");
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
