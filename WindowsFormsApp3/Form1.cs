using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region "Custom methods"
        private void Init()
        {
            this.tukaikata.SelectedIndex = 0;
            this.cckatu.SelectedIndex = 0;
            this.kextuka.Text = "";
        }

        //private double GetTaxPercentage()
        //{
           // string selectendItem = this.kakutei.Text
       // }
        #endregion
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tukaikata.SelectedIndex == 0)
            {
                this.cckatu.Items.Clear();
                this.cckatu.Items.Add("150以下/12HP以下(12.2PS以下");
                this.cckatu.Items.Add("151-250/12.1-20HP(12.3-20.3PS)");
                this.cckatu.Items.Add("251-500/20.1HP以上(20.4PS以上");
                this.cckatu.Items.Add("501-600");
                this.cckatu.Items.Add("601-1200");
                this.cckatu.Items.Add("1201-1800");
                this.cckatu.Items.Add("1801或以上");
                this.cckatu.SelectedIndex = 0;
            }

            if (this.tukaikata.SelectedIndex ==1)
            {
                this.cckatu.Items.Clear();
                this.cckatu.Items.Add("500以下");
                this.cckatu.Items.Add("501-600");
                this.cckatu.Items.Add("601-1200");
                this.cckatu.Items.Add("1201-1800");
                this.cckatu.Items.Add("1801-2400");
                this.cckatu.Items.Add("2401-3000/138HP以下(140.1PS以下");
                this.cckatu.Items.Add("3001-3600");
                this.cckatu.Items.Add("3601-4200/138.1-200HP(140.2-203.0PS");
                this.cckatu.Items.Add("4201-4800");
                this.cckatu.Items.Add("4801-5400/200.1-247HP(203.1-250.7PS");
                this.cckatu.Items.Add("5401-6000");
                this.cckatu.Items.Add("6001-6600/247.1-286HP(250.8-290.3PS");
                this.cckatu.Items.Add("6601-7200");
                this.cckatu.Items.Add("7201.7800/286.1-336HP(290.4-341.0PS");
                this.cckatu.Items.Add("7801-8400");
                this.cckatu.Items.Add("8401-9000/336.1-361HP(341.1-366.4PS");
                this.cckatu.Items.Add("9001-9600");
                this.cckatu.Items.Add("9601.10200/361.1HP以上(366.5PS以上)");
                this.cckatu.Items.Add("10201以上");
                this.cckatu.SelectedIndex = 0;
            }

            if (tukaikata.SelectedIndex ==2)
            {
                this.cckatu.Items.Clear();
                this.cckatu.Items.Add("600以下");
                this.cckatu.Items.Add("601-1200");
                this.cckatu.Items.Add("1201-1800");
                this.cckatu.Items.Add("1801-2400");
                this.cckatu.Items.Add("2401-3000/138HP以下(140.1PS以下)");
                this.cckatu.Items.Add("3001-3600");
                this.cckatu.Items.Add("3601-4200/138.1-200HP(140.2-203.0PS)");
                this.cckatu.Items.Add("4201-4800");
                this.cckatu.Items.Add("4801-5400/200.1-247HP(203.1-250.7PS");
                this.cckatu.Items.Add("5401-6000");
                this.cckatu.Items.Add("6001-6600/247.1-286HP(250.8-290.3PS");
                this.cckatu.Items.Add("6601-7200");
                this.cckatu.Items.Add("7201-7800/286.1-336HP(290.4-341.0PS");
                this.cckatu.Items.Add("7801-8400");
                this.cckatu.Items.Add("8401-9000/336.1-361HP(341.1-366.4PS");
                this.cckatu.Items.Add("9001-9600");
                this.cckatu.Items.Add("9601-10200/361.1HP以上(366.5PS以上");
                this.cckatu.Items.Add("10201以上");
                this.cckatu.SelectedIndex = 0;
            }

            if (tukaikata.SelectedIndex ==3)
            {
                this.cckatu.Items.Clear();
                this.cckatu.Items.Add("500以下/38HP以下(38.6PS以下");
                this.cckatu.Items.Add("501~600/38.1-56HP(38.7-56.8PS)");
                this.cckatu.Items.Add("601~1200/56.1-83HP(56.9-84.2PS");
                this.cckatu.Items.Add("1201~1800/83.1-182HP(84.3-184.7PS");
                this.cckatu.Items.Add("1801~2400/182.1-262HP(184.8-265.9PS");
                this.cckatu.Items.Add("2401~3000/262.1-322HP(266-326.8PS");
                this.cckatu.Items.Add("3001-4200/322.1-414HP(326.9-420.2PS)");
                this.cckatu.Items.Add("4201-5400/414.1-469HP(420.3-476.0PS");
                this.cckatu.Items.Add("5401-6600/469.1-509HP(476.1-516.6PS");
                this.cckatu.Items.Add("6601-7800/509.1HP以上(516.7PS以上");
                this.cckatu.Items.Add("7801以上");
                this.cckatu.SelectedIndex = 0;
            }

            if (tukaikata.SelectedIndex ==4)
            {
                this.cckatu.Items.Clear();
                this.cckatu.Items.Add("500以下/38HP以下(38.6PS以下)");
                this.cckatu.Items.Add("501~600/38.1-56HP(38.7-56.8PS)");
                this.cckatu.Items.Add("601~1200/56.1-83HP(56.9-84.2PS)");
                this.cckatu.Items.Add("1201~1800/83.1-182HP(84.3-184.7PS");
                this.cckatu.Items.Add("1801~2400/182.1-262HP(184.8-265.9PS");
                this.cckatu.Items.Add("2401~3000/262.1-322HP(266-326.8PS");
                this.cckatu.Items.Add("3001-4200/322.1-414HP(326.9-420.2PS");
                this.cckatu.Items.Add("4201-5400/414.1-469HP(420.3-476.0PS");
                this.cckatu.Items.Add("5401-6600/469.1-509HP(476.1516.6PS");
                this.cckatu.Items.Add("6601-7800/509.1HP以上(516.7PS以上");
                this.cckatu.Items.Add("7801以上");
                this.cckatu.SelectedIndex = 0;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Init();
        }

        private void kyanseru_Click(object sender, EventArgs e)
        {
            this.Init();
        }

        private void kikan_CheckedChanged(object sender, EventArgs e)
        {
            if (kikan.Checked == true)
            {
                this.label6.Visible = true;
                this.label7.Visible = true;
                this.kikan2.Visible = true;
                this.kikan3.Visible = true;
            }

            if (kikan.Checked == false)
            {
                this.label6.Visible = false;
                this.label7.Visible = false;
                this.kikan2.Visible = false;
                this.kikan3.Visible = false;
            }
        }

        void keisankextuka(string a, string b, int c)
        {
            DateTime date1 = kikan2.Value;
            DateTime date2 = kikan3.Value;
            int ryoukin;
            int nen;
            int nenkextuka;
            string nenkan;

            var twCalendar = new System.Globalization.TaiwanCalendar();
            string yearTW = twCalendar.GetYear(DateTime.Now).ToString();

            if  (DateTime.IsLeapYear(DateTime.Now.Year))
            {
                nen = 366;
            }
            else
            {
                nen = 356;
            }

            if (kikan.Checked == true)
            {
                TimeSpan span = date2 - date1;
                nenkextuka = span.Days + 1;
                nenkan = (kikan2.Value.Year - 1911).ToString() + kikan2.Value.ToString("-MM-dd") + "~" + (kikan3.Value.Year - 1911).ToString() + kikan3.Value.ToString("-MM-dd");
            }

            else
            {
                nenkextuka = nen;
                nenkan = (kikan2.Value.Year - 1911).ToString() + "-01-01" + "~" + (kikan3.Value.Year - 1911).ToString() + "-12-31";
            }

            ryoukin = c * nenkextuka / nen;

            if (nenkextuka < 0 && kikan2.Value.Year < 1911)
            {
                this.kextuka.Text = "日期設定錯誤";
            }

            else
            {
                this.kextuka.Text = 
                "使用時間:" + nenkan + "\r\n " +
                "計算天數:" + nenkextuka.ToString() + "天" + "\r\n" +
                "汽缸CC數:" + a + "\r\n" +
                "用途:" + b + "\r\n" +
                "計算公式:" + c.ToString() + " * " + nenkextuka.ToString() + " / " + nen.ToString() + " = " + ryoukin.ToString() + "\r\n" +
                "應納稅額: 共 " + ryoukin.ToString() + " 元 ";
            }
        }

        private void kakutei_Click(object sender, EventArgs e)
        {
            DateTime date1 = kikan2.Value;
            DateTime date2 = kikan3.Value;
            int nenkextuka;
            int ryoukin;
            

            if (this.tukaikata.SelectedIndex == 0 && this.cckatu.SelectedIndex == 0)
            {
                keisankextuka("150以下 / 12HP以下(12.2PS以下)", "機車", 0);
            }

            else if (this.tukaikata.SelectedIndex == 0 && this.cckatu.SelectedIndex == 1)
            {
                keisankextuka("151-250/12.1-20HP(12.3-20.3PS)", "機車", 800);
            }

            else if (this.tukaikata.SelectedIndex == 0 && this.cckatu.SelectedIndex == 2)
            {
                keisankextuka("251-50/20.1HP以上(20.4PS以上)", "機車", 1620);
            }

            else if (this.tukaikata.SelectedIndex == 0 && this.cckatu.SelectedIndex == 3)
            {
                keisankextuka("501-600", "機車", 2160);
            }

            else if (this.tukaikata.SelectedIndex == 0 && this.cckatu.SelectedIndex == 4)
            {
                keisankextuka("601-1200", "機車", 4320);
            }

            else if (this.tukaikata.SelectedIndex == 0 && this.cckatu.SelectedIndex == 5)
            {
                keisankextuka("1201-1800", "機車", 7120);
            }

            else if (this.tukaikata.SelectedIndex == 0 && this.cckatu.SelectedIndex == 6)
            {
                keisankextuka("1801以上", "機車", 11230);
            }

            if (this.tukaikata.SelectedIndex == 1 && this.cckatu.SelectedIndex == 0)
            {
                keisankextuka("500以下", "貨車", 900);
            }

            else if (this.tukaikata.SelectedIndex == 1 && this.cckatu.SelectedIndex == 1)
            {
                keisankextuka("501-600", "貨車", 1080);
            }

            else if (this.tukaikata.SelectedIndex == 1 && this.cckatu.SelectedIndex == 2)
            {
                keisankextuka("601-1200", "貨車", 1800);
            }

            else if (this.tukaikata.SelectedIndex == 1 && this.cckatu.SelectedIndex == 3)
            {
                keisankextuka("1201-1800", "貨車", 2700);
            }

            else if (this.tukaikata.SelectedIndex == 1 && this.cckatu.SelectedIndex == 4)
            {
                keisankextuka("1801-2400", "貨車", 3600);
            }

            else if (this.tukaikata.SelectedIndex == 1 && this.cckatu.SelectedIndex == 5)
            {
                keisankextuka("2401-3000/138HP以下(140.1PS以下)", "貨車", 4500);
            }

            else if (this.tukaikata.SelectedIndex == 1 && this.cckatu.SelectedIndex == 6)
            {
                keisankextuka("3001-3600", "貨車", 5400);
            }

            else if (this.tukaikata.SelectedIndex == 1 && this.cckatu.SelectedIndex == 7)
            {
                keisankextuka("3601-4200/138.1-200HP(140.2-203.0PS)", "貨車", 6300);
            }

            else if (this.tukaikata.SelectedIndex == 1 && this.cckatu.SelectedIndex == 8)
            {
                keisankextuka("4201-4800", "貨車", 7200);
            }

            else if (this.tukaikata.SelectedIndex == 1 && this.cckatu.SelectedIndex == 9)
            {
                keisankextuka("4801-5400/200.1-247HP(203.1-250.7PS)", "貨車", 8100);
            }

            else if (this.tukaikata.SelectedIndex == 1 && this.cckatu.SelectedIndex == 10)
            {
                keisankextuka("5401-6000", "貨車", 9000);
            }

            else if (this.tukaikata.SelectedIndex == 1 && this.cckatu.SelectedIndex == 11)
            {
                keisankextuka("6001-6600/247.1-286HP(250.8-290.3PS)", "貨車", 9900);
            }

            else if (this.tukaikata.SelectedIndex == 1 && this.cckatu.SelectedIndex == 12)
            {
                keisankextuka("6601-7200", "貨車", 10800);
            }

            else if (this.tukaikata.SelectedIndex == 1 && this.cckatu.SelectedIndex == 13)
            {
                keisankextuka("7201-7800/286.1-336HP(290.4-341.0PS)", "貨車", 11700);
            }

            else if (this.tukaikata.SelectedIndex == 1 && this.cckatu.SelectedIndex == 14)
            {
                keisankextuka("7801-8400", "貨車", 12600);
            }

            else if (this.tukaikata.SelectedIndex == 1 && this.cckatu.SelectedIndex == 15)
            {
                keisankextuka("501-600", "貨車", 1080);
            }
        }

        private void kextuka_Click(object sender, EventArgs e)
        {

        }
    }
}
