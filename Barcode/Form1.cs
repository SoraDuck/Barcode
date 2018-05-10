using BarcodeLib;
using BarcodeLib.Barcode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Barcode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setdropdown();
        }

        private void setdropdown()
        {
            object[,] arg_type = { { "Code39", 1 }, { "Code128", 2 }, { "PDF417", 3 }, { "DataMatrix", 4 }, { "QR Code", 5 } };
            for (int i = 0; i < arg_type.Length / 2; i++)
            {
                cbType.Items.Add(new Options { Name = arg_type[i, 0].ToString(), Value = Convert.ToInt32(arg_type[i, 1]) });
            }
            cbType.DisplayMember = "Name";
            cbType.ValueMember = "Value";
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            
            Options opt = (Options)cbType.SelectedItem;
            string strCont = tbCon.Text.Trim();
            string pic="D:\\Temp\\Barcode_"+DateTime.Now.ToString("MMddHHmmss")+".jpg";
            picbc.Invalidate();
            if (strCont != "")
            {
                if (opt == null)
                {
                    MessageBox.Show("Please choice \"Label Type\"!!");
                }
                else
                {
                    switch (opt.Value)
                    {
                        case 1:
                        case 2:
                            Linear lb = new Linear();
                            if (opt.Value == 1)
                            {
                                lb.Type = BarcodeType.CODE39;
                                lb.Data = strCont.ToUpper();
                            }
                            else
                            {
                                lb.Type = BarcodeType.CODE128;
                                lb.Data = strCont;
                            }
                            if (cbox.Checked)
                                lb.ShowText = true;
                            else
                                lb.ShowText = false;
                            lb.BearerBarWidth = 2;
                            lb.BarHeight = 50;
                            lb.drawBarcode(pic);

                            break;
                        case 3:
                            PDF417 p = new PDF417();
                            p.Data = strCont;
                            p.Columns = 5;
                            p.Rows = 10;
                            p.drawBarcode(pic);
                            break;
                        case 4:
                            DataMatrix dm = new DataMatrix();
                            dm.ModuleSize = 8;
                            dm.RightMargin = 6;
                            dm.LeftMargin = 6;
                            dm.TopMargin = 6;
                            dm.BottomMargin = 6;
                            dm.drawBarcode(pic);
                            break;
                        case 5:
                            QRCode qr = new QRCode();
                            qr.ModuleSize = 7;
                            qr.RightMargin = 3;
                            qr.LeftMargin = 3;
                            qr.TopMargin = 3;
                            qr.BottomMargin = 3;
                            qr.drawBarcode(pic);
                            break;
                        default:
                            break;
                    }
                    if (File.Exists(pic))
                    {
                        Bitmap bmp = new Bitmap(pic);
                        try
                        {
                            picbc.Width = bmp.Width;
                            picbc.Height = bmp.Height;
                            int pw = (panel1.Width - picbc.Width) / 2;
                            int ph = (panel1.Height - picbc.Height) / 2;
                            picbc.Left = pw;
                            picbc.Top = ph;
                            picbc.Image = bmp;

                        }
                        catch (Exception err)
                        {
                            MessageBox.Show(err.Message);
                        }

                    }
                }
            }
            else
                MessageBox.Show("Conten is empty!!");
        }


    }

    internal class Options
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
