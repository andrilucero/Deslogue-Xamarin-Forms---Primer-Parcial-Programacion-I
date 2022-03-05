using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Deslogue
{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            int CA200, CA100, CA50, CA20, CA10, CA5, CA1;
            float CAN;
            CAN = CA200 = CA100 = CA50 = CA20 = CA10 = CA5 = CA1 = 0;
            CAN = float.Parse(entrytexto.Text);


            if (CAN >= 200)
            {
                CA200 = (((int)(CAN / 200)));
                CAN = CAN - (CA200 * 200);

            }

            if ((CAN >= 100))
            {
                CA100 = ((int)(CAN / 100));
                CAN = CAN - (CA100 * 100);

            }

            if ((CAN >= 50))
            {
                CA50 = ((int)(CAN / 50));
                CAN = CAN - (CA50 * 50);

            }

            if ((CAN >= 20))
            {
                CA20 = ((int)(CAN / 20));
                CAN = CAN - (CA20 * 20);

            }

            if ((CAN >= 10))
            {
                CA10 = ((int)(CAN / 10));
                CAN = CAN - (CA10 * 10);

            }

            if ((CAN >= 5))
            {
                CA5 = ((int)(CAN / 5));
                CAN = CAN - (CA5 * 5);

            }

            if ((CAN >= 1))
            {
                CA1 = ((int)(CAN / 1));
                CAN = CAN - (CA1 * 1);

            }

        int CA050, CA025, CA010, CA05, CA01;
            CA050 = CA025 = CA010 = CA05 = CA01 = 0;

            if ((CAN >= 0.50))
            {
                CA050 = (int)(CAN / 0.50);
                CAN = (CAN - (float)(CA050 * 0.50));


            }

            if ((CAN >= 0.25))
            {
                CA025 = (int)(CAN / 0.25);
                CAN = (CAN - (float)(CA025 * 0.25));


            }

            if ((CAN >= 0.10))
            {
                CA010 = (int)(CAN / 0.10);
                CAN = (CAN - (float)(CA010 * 0.10));

            }

            if ((CAN >= 0.05))
            {
                CA05 = (int)(CAN / 0.05);
                CAN = (CAN - (float)(CA05 * 0.05));

            }

            if ((CAN >= 0.01))
            {
                CA01 = (int)(float)Math.Round(CAN / 0.01);
                CAN = (CAN - (float)(CA01 * 0.01));

            }
            Ca200.Text = ($"\t\tBilletes de Q200:{CA200}");
            Ca100.Text = ($"\t\tBilletes de Q100:{CA100}");
            Ca50.Text = ($"\t\tBilletes de Q50:{CA50}");
            Ca20.Text = ($"\t\tBilletes de Q20:{CA20}");
            Ca10.Text = ($"\t\tBilletes de Q10:{CA10}");
            Ca5.Text = ($"\t\tBilletes de Q5:{CA5}");
            Ca1.Text = ($"\t\tBilletes de Q1:{CA1}");
            Ca050.Text = ($"\t\tMonedas de 50 centavos:{CA050}");
            Ca025.Text = ($"\t\tMonedas de 25 centavos:{CA025}");
            Ca010.Text = ($"\t\tMonedas de 10 centavos:{CA010}");
            Ca05.Text = ($"\t\tMonedas de 5 centavos:{CA05}");
            Ca01.Text = ($"\t\tMonedas de 1 centavo:{CA01}");

        }
    }
}