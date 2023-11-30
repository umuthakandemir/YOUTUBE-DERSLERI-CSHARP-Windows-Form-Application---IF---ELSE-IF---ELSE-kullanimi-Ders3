namespace Ders3_İf_else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblsonuc.Text = "";
            btnclick.Text = "Tıkla";

        }

        private void btnclick_Click(object sender, EventArgs e)
        {
            /*if(txtgirdi.Text == "isim")
            {
                lblsonuc.Text = txtgirdi.Text;
            }
            else
            {
                lblsonuc.Text = "farklı bir değer girildi..";
            }*/
            if(txtgirdi.Text.Length == 0)
            {
                lblsonuc.Text = "lütfen bır deger gırınız..";
                MessageBox.Show("lütfen bır deger gırınız..","Hata");
            }else if (txtgirdi.Text.Length == 2)
            {
                lblsonuc.Text = "gırdıgınız karakter 2 hanelı..";
            }
            else
            {
                lblsonuc.Text = txtgirdi.Text;
            }
        }
    }
}