using System.Windows.Forms;

namespace OrderingSystem.KioskApplication.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void dinein(object sender, System.EventArgs e)
        {
            KioskLayout k = new KioskLayout();
            k.setType("Dine-in");
            loadForm(k);
        }

        private void takeout(object sender, System.EventArgs e)
        {
            KioskLayout k = new KioskLayout();
            k.setType("Take-out");
            loadForm(k);
        }

        public void loadForm(Form f)
        {
            if (mm.Controls.Count > 0) mm.Controls.Clear();

            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            mm.Controls.Add(f);
            f.Show();
        }
        public void reset()
        {
            if (mm.Controls.Count > 0) mm.Controls.Clear();
            mm.Controls.Add(bb);
        }
    }
}
