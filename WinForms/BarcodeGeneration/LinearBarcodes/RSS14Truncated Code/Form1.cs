﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

using Spire.Barcode;

namespace BarcodeLibUtilizationInWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BarcodeSettings bs = new BarcodeSettings();
            bs.Type = BarCodeType.RSS14Truncated;
            bs.Data = "12345";
            BarCodeGenerator bg = new BarCodeGenerator(bs);
            bg.GenerateImage().Save("RSS14TruncatedCode.png");
            System.Diagnostics.Process.Start("RSS14TruncatedCode.png");
        }
    }
}
