using System.Globalization;
using System.Windows.Forms;
using OrderingSystem.Model;

namespace OrderingSystem.CashierApp.Forms.Order
{
    public partial class OrderDetail : Form
    {
        public OrderDetail(OrderItemModel om)
        {
            InitializeComponent();
            image.Image = om.PurchaseMenu.MenuImage;
            name.Text = om.PurchaseMenu.MenuName;
            flavor.Text = om.PurchaseMenu.FlavorName;
            size.Text = om.PurchaseMenu.SizeName;

            price.Text = om.PurchaseMenu.getPriceAfterVatWithDiscount().ToString("N2", new CultureInfo("en-PH"));
            qty.Text = om.PurchaseQty.ToString();
            total.Text = om.getSubtotal().ToString("N2", new CultureInfo("en-PH"));
        }

        private void guna2PictureBox1_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
