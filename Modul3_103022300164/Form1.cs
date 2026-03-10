namespace Modul3_103022300164
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double Cel_toFah(double cel)
        {
            return (cel * 9 / 5) + 32;
        }

        static double Cel_toKel(double cel)
        {
            return cel + 273.15;
        }

        static double Cel_toRea(double cel)
        {
            return cel * 4 / 5;
        }

        static double Fah_toCel(double fah)
        {
            return (fah - 32) * 5 / 9;
        }

        static double Fah_toKel(double fah)
        {
            return ((fah - 32) * 5 / 9) + 273.15;
        }

        static double Fah_toRea(double fah)
        {
            return (fah - 32) * 4 / 9;
        }

        static double Kel_toCel(double kel)
        {
            return kel - 273.15;
        }

        static double Kel_toFah(double kel)
        {
            return ((kel - 273.15) * 9 / 5) + 32;
        }

        static double Kel_toRea(double kel)
        {
            return (kel - 273.15) * 4 / 5;
        }

        static double Rea_toCel(double rea)
        {
            return rea * 5 / 4;
        }

        static double Rea_toFah(double rea)
        {
            return (rea * 9 / 4) + 32;
        }

        static double Rea_toKel(double rea)
        {
            return (rea * 5 / 4) + 273.15;
        }

        private void Bt_Convert_Click(object sender, EventArgs e)
        {
            Cb_Unit_In.Text = Cb_Unit_In.Text.ToLower();
            Cb_Unit_Out.Text = Cb_Unit_Out.Text.ToLower();

            if (Cb_Unit_Out.Text == "" || Cb_Unit_In.Text == "")
            {
                MessageBox.Show("Pilih satuan terlebih dahulu!", "Invalid unit");
                return;
            }

            if (Tb_In.Text == "" || Tb_Out.Text == "")
            {
                MessageBox.Show("Masukkan angka yang valid!", "Invalid input");
                return;
            }

            if (Cb_Unit_In.Text == "celcius")
            {
                if (Cb_Unit_Out.Text == "fahrenheit")
                {
                    Tb_Out.Text = Cel_toFah(double.Parse(Tb_In.Text)).ToString();
                }
                else if (Cb_Unit_Out.Text == "kelvin")
                {
                    Tb_Out.Text = Cel_toKel(double.Parse(Tb_In.Text)).ToString();
                }
                else if (Cb_Unit_Out.Text == "reamur")
                {
                    Tb_Out.Text = Cel_toRea(double.Parse(Tb_In.Text)).ToString();
                }
                else
                {
                    Tb_Out.Text = Tb_In.Text;
                }
            }
            else if (Cb_Unit_In.Text == "fahrenheit")
            {
                if (Cb_Unit_Out.Text == "celcius")
                {
                    Tb_Out.Text = Fah_toCel(double.Parse(Tb_In.Text)).ToString();
                }
                else if (Cb_Unit_Out.Text == "kelvin")
                {
                    Tb_Out.Text = Fah_toKel(double.Parse(Tb_In.Text)).ToString();
                }
                else if (Cb_Unit_Out.Text == "reamur")
                {
                    Tb_Out.Text = Fah_toRea(double.Parse(Tb_In.Text)).ToString();
                }
                else
                {
                    Tb_Out.Text = Tb_In.Text;
                }
            }
            else if (Cb_Unit_In.Text == "kelvin")
            {
                if (Cb_Unit_Out.Text == "celcius")
                {
                    Tb_Out.Text = Kel_toCel(double.Parse(Tb_In.Text)).ToString();
                }
                else if (Cb_Unit_Out.Text == "fahrenheit")
                {
                    Tb_Out.Text = Kel_toFah(double.Parse(Tb_In.Text)).ToString();
                }
                else if (Cb_Unit_Out.Text == "reamur")
                {
                    Tb_Out.Text = Kel_toRea(double.Parse(Tb_In.Text)).ToString();
                }
                else
                {
                    Tb_Out.Text = Tb_In.Text;
                }
            }
            else if (Cb_Unit_In.Text == "reamur")
            {
                if (Cb_Unit_Out.Text == "celcius")
                {
                    Tb_Out.Text = Rea_toCel(double.Parse(Tb_In.Text)).ToString();
                }
                else if (Cb_Unit_Out.Text == "fahrenheit")
                {
                    Tb_Out.Text = Rea_toFah(double.Parse(Tb_In.Text)).ToString();
                }
                else if (Cb_Unit_Out.Text == "kelvin")
                {
                    Tb_Out.Text = Rea_toKel(double.Parse(Tb_In.Text)).ToString();
                }
                else
                {
                    Tb_Out.Text = Tb_In.Text;
                }
            }
        }
    }
}
