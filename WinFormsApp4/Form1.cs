namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Add()
        {
            double Fnum = double.Parse(txtFnum.Text);
            double Snum = double.Parse(txtSnum.Text);
            double ttlAdd;

            ttlAdd = Fnum + Snum;
            lblAnswer.Text = ttlAdd.ToString();
        }

        public void Sub(double x, double y)
        {
            x = double.Parse(txtFnum.Text);
            y = double.Parse(txtSnum.Text);
            double ttlSub;

            ttlSub = x - y;
            lblAnswer.Text = ttlSub.ToString();
        }
        String Mul()
        {
            double Fnum = double.Parse(txtFnum.Text);
            double Snum = double.Parse(txtSnum.Text);
            double ttlMul;

            ttlMul = Fnum * Snum;
            return ttlMul.ToString();
        }
        String div(String x, String y)
        {
            double Fnum = double.Parse(txtFnum.Text);
            double Snum = double.Parse(txtSnum.Text);
            double div;

            if (Fnum > 0 && Snum == 0)
            {
                return "can't divide by zero";
            }
            else if (Fnum == 0 && Snum == 0)
            {
                return "undefined";
            }
            else
            {
                div = Fnum / Snum;
                return div.ToString();
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnDiff_Click(object sender, EventArgs e)
        {
            Sub(double.Parse(txtFnum.Text), double.Parse(txtSnum.Text));
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = Mul();
        }

        private void btnQuo_Click(object sender, EventArgs e)
        {
            lblAnswer.Text = div(txtFnum.Text, txtSnum.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFnum.Text = "";
            txtSnum.Text = "";
            lblAnswer.Text = "---";
        }
    }
}
