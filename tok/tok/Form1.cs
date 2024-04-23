using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // const double DAY_OLD = 20441;
            // const double NIGHT_OLD = 8652;

            // const double DAY_PRICE = 0.245;
            // const double NIGHT_PRICE = 0.137;

            double dayOld = double.Parse(this.textBox1.Text);
            double dayNew = double.Parse(this.textBox2.Text);
            double nightOld = double.Parse(this.textBox3.Text);
            double nightNew = double.Parse(this.textBox4.Text);
            double dayPrice = double.Parse(this.textBoxDay.Text);
            double nightPrice = double.Parse(this.textBoxNight.Text);
            string date = (this.textBoxDate.Text);

            double diffDay = dayNew - dayOld;
            double diffNight = nightNew - nightOld;

            double dayResult = diffDay * dayPrice;
            double nightResult = diffNight * nightPrice;
            double totalSum = dayResult + nightResult;

           // textBox1.Text = dayOld.ToString();
           // textBox3.Text = dayNew.ToString();

            textBox9.Text = diffDay.ToString();
            textBox6.Text = diffNight.ToString();

           
            textBoxDay.Text = dayPrice.ToString();
            textBoxNight.Text = nightPrice.ToString();

            textBoxSum1.Text = dayResult.ToString();
            textBoxSum2.Text = nightResult.ToString();
            textBoxSum3.Text = totalSum.ToString();
            textBoxDate.Text = date.ToString();

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

      

        private void saveButton_Click(object sender, EventArgs e)
        {
            Settings2.Default.dayOld = textBox1.Text;
            Settings2.Default.nightOld = textBox3.Text;
            Settings2.Default.dayNew = textBox2.Text;
            Settings2.Default.nightNew = textBox4.Text;
            Settings2.Default.diffDay = textBox9.Text;
            Settings2.Default.diffNight = textBox6.Text;
            Settings2.Default.dayPrice = textBoxDay.Text;
            Settings2.Default.nightPrice = textBoxNight.Text;
            Settings2.Default.dayResult = textBoxSum1.Text;
            Settings2.Default.nightResult = textBoxSum2.Text;
            Settings2.Default.totalSum = textBoxSum3.Text;
            Settings2.Default.date = textBoxDate.Text;
            
            Settings2.Default.Save();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LOAD();
        }
        private void loadButton_Click(object sender, EventArgs e)
        {
            LOAD();
        }
        void LOAD()
        {
            textBox1.Text = Settings2.Default.dayOld;
            textBox3.Text = Settings2.Default.nightOld;
            textBox2.Text = Settings2.Default.dayNew;
            textBox4.Text = Settings2.Default.nightNew;
            textBox9.Text = Settings2.Default.diffDay;
            textBox6.Text = Settings2.Default.diffNight;
            textBoxDay.Text = Settings2.Default.dayPrice;
            textBoxNight.Text = Settings2.Default.nightPrice;
            textBoxSum1.Text = Settings2.Default.dayResult;
            textBoxSum2.Text = Settings2.Default.nightResult;
            textBoxSum3.Text = Settings2.Default.totalSum;
            textBoxDate.Text = Settings2.Default.date;
        }

        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



//private void loadButton_Click(object sender, EventArgs e)
//{
//    LOAD();
//}
//void LOAD()
//{
//    textBox1.Text = Settings2.Default.dayOld;
//    textBox3.Text = Settings2.Default.nightOld;
//    textBox2.Text = Settings2.Default.dayNew;
//    textBox4.Text = Settings2.Default.nightNew;
//    textBox9.Text = Settings2.Default.diffDay;
//    textBox6.Text = Settings2.Default.diffNight;
//    textBoxDay.Text = Settings2.Default.dayPrice;
//    textBoxNight.Text = Settings2.Default.nightPrice;
//    textBoxSum1.Text = Settings2.Default.dayResult;
//    textBoxSum2.Text = Settings2.Default.nightResult;
//    textBoxSum3.Text = Settings2.Default.totalSum;
//}