using System;
using Guna.UI2.WinForms;

namespace OrderingSystem.KioskApplication.Component
{
    public partial class MyRadioButton2 : Guna2Panel
    {
        public event EventHandler<bool> check;
        private bool xd;
        public MyRadioButton2(string title)
        {
            InitializeComponent();
            name.Text = title;
        }

        private void clicked(object sender, EventArgs e)
        {
            xd = !xd;
            check.Invoke(this, xd);
        }

        private void name_Click(object sender, EventArgs e)
        {
            clicked(this, e);
        }



    }
}
