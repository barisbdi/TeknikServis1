using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string exchangeRate = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(exchangeRate);

            string usd = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='USD'] / BanknoteSelling").InnerXml;
            string euro = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='EUR'] / BanknoteSelling").InnerXml;

            barStaticItem3.Caption = "Dolar : " + usd;
            barStaticItem4.Caption = "| Euro : " + euro;

            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            barStaticItem6.Caption = DateTime.Now.ToLongDateString();
            barStaticItem7.Caption = DateTime.Now.ToLongTimeString();
        }
        Form2 fr;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null || fr.IsDisposed)
            {
                fr = new Form2();
                fr.MdiParent = this; 
                fr.Show();
            }
        }
    }
}
