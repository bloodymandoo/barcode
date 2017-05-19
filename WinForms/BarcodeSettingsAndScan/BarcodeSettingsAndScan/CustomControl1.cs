using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace BarcodeLibUtilizationInWinForm
{

    public partial class myColorComboBox : ComboBox
    {

        public myColorComboBox()
        {
            InitializeComponent();
            InitItems();
        }
        public myColorComboBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            InitItems();
        }
        private void InitItems()
        {
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Items.Clear();
            Array allColors = Enum.GetValues(typeof(KnownColor));
            foreach (KnownColor var in allColors)
            {
                this.Items.Add(var.ToString());
            }
            this.SelectedIndex = 0;
        }
        protected override void OnDrawItem(DrawItemEventArgs e)
        {

            if (e.Index >= 0)
            {
                string colorName = this.Items[e.Index].ToString();
                SolidBrush brush = new SolidBrush(Color.FromName(colorName));
                Font font = new Font("宋体", 9);
                Rectangle rect = e.Bounds;
                rect.Inflate(-2, -2);
                Rectangle rectColor = new Rectangle(rect.Location, new Size(20, rect.Height));
                e.Graphics.FillRectangle(brush, rectColor);
                e.Graphics.DrawRectangle(Pens.Black, rectColor);
                e.Graphics.DrawString(colorName, font, Brushes.Black, (rect.X + 22), rect.Y);
            }

        }
        public string SelectColorName
        {
            get { return this.Text; }
        }
        public Color SelectColor
        {
            get { return Color.FromName(this.Text); }
        }

    }

}
