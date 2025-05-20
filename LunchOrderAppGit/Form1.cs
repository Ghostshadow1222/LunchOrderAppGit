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
            HamburgerRdo.CheckedChanged += new EventHandler(MainCourseRdo_CheckedChanged);
            PizzaRdo.CheckedChanged += new EventHandler(MainCourseRdo_CheckedChanged);
            SaladRdo.CheckedChanged += new EventHandler(MainCourseRdo_CheckedChanged);
            HamburgerSide1Cbo.CheckedChanged += new EventHandler(AddOnCbo_CheckedChanged);
            HamburgerSide2Cbo.CheckedChanged += new EventHandler(AddOnCbo_CheckedChanged);
            HamburgerSide3Cbo.CheckedChanged += new EventHandler(AddOnCbo_CheckedChanged);
            PizzaSide1Cbo.CheckedChanged += new EventHandler(AddOnCbo_CheckedChanged);
            PizzaSide2Cbo.CheckedChanged += new EventHandler(AddOnCbo_CheckedChanged);
            PizzaSide3Cbo.CheckedChanged += new EventHandler(AddOnCbo_CheckedChanged);
            SaladSide1Cbo.CheckedChanged += new EventHandler(AddOnCbo_CheckedChanged);
            SaladSide2Cbo.CheckedChanged += new EventHandler(AddOnCbo_CheckedChanged);
            SaladSide3Cbo.CheckedChanged += new EventHandler(AddOnCbo_CheckedChanged);
        }

        private void MainCourseRdo_CheckedChanged(object sender, EventArgs e)
        {
            HamburgerGrp.Visible = HamburgerRdo.Checked;
            PizzaGrp.Visible = PizzaRdo.Checked;
            SaladGrp.Visible = SaladRdo.Checked;
            ClearOrderTotals();
            ClearAddOns();
        }

        private void AddOnCbo_CheckedChanged(object sender, EventArgs e)
        {
            ClearOrderTotals();
        }

        private void ClearOrderTotals()
        {
            SubtotalTxt.Text = string.Empty;
            TaxTxt.Text = string.Empty;
            OrderTotalTxt.Text = string.Empty;
        }
        private void ClearAddOns()
        {
            HamburgerSide1Cbo.Checked = false;
            HamburgerSide2Cbo.Checked = false;
            HamburgerSide3Cbo.Checked = false;
            PizzaSide1Cbo.Checked = false;
            PizzaSide2Cbo.Checked = false;
            PizzaSide3Cbo.Checked = false;
            SaladSide1Cbo.Checked = false;
            SaladSide2Cbo.Checked = false;
            SaladSide3Cbo.Checked = false;
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
