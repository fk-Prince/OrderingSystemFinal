using System;
using System.Data;
using System.Windows.Forms;
using OrderingSystem.CashierApp.Layout;
using OrderingSystem.CashierApp.SessionData;
using OrderingSystem.KioskApplication.Services;
using OrderingSystem.Model;

namespace OrderingSystem.CashierApp.Forms.Order
{
    public partial class OrdersPopup : Form
    {
        private int offSet = 0;
        private readonly OrderServices orderServices;
        private DataView view;
        private int page = 1;
        public event EventHandler<string> selectedOrder;
        public OrdersPopup(OrderServices orderServices)
        {
            InitializeComponent();
            this.orderServices = orderServices;
            pp.Text = page.ToString();
            fetchData();
        }
        private void fetchData()
        {
            try
            {
                view = orderServices.getOrders(offSet);
                dataGridView1.DataSource = view;
                addViewButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void next(object sender, EventArgs e)
        {
            offSet += 50;
            fetchData();
            pp.Text = (page += 1).ToString();
        }

        private void prev(object sender, EventArgs e)
        {
            if (offSet != 0)
            {
                offSet -= 50;
                fetchData();
                pp.Text = (page -= 1).ToString();
            }
        }
        private void addViewButton()
        {
            if (dataGridView1.Columns["Void Order"] == null)
            {
                DataGridViewButtonColumn voidOrder = new DataGridViewButtonColumn();
                voidOrder.HeaderText = "Action";
                voidOrder.Name = "Void Order";
                voidOrder.Text = "Void Order";
                voidOrder.UseColumnTextForButtonValue = true;
                voidOrder.Width = 70;
                dataGridView1.Columns.Add(voidOrder);
            }
            if (dataGridView1.Columns["Select Order"] == null)
            {
                DataGridViewButtonColumn selectOrder = new DataGridViewButtonColumn();
                selectOrder.HeaderText = "Select Order";
                selectOrder.Name = "Select Order";
                selectOrder.Text = "Select Order";
                selectOrder.UseColumnTextForButtonValue = true;
                selectOrder.Width = 70;
                dataGridView1.Columns.Add(selectOrder);
            }


        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            view.Sort = guna2CheckBox1.Checked ? "[Available Until] DESC" : "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Void Order")
            {
                string orderId = dataGridView1.Rows[e.RowIndex].Cells["Order ID"].Value.ToString();
                string status = dataGridView1.Rows[e.RowIndex].Cells["Status"].Value.ToString();

                if (!status.Equals("Pending", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Only orders with status 'Pending' can be voided.\nCurrent status: {status}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (SessionStaffData.Role != StaffModel.StaffRole.Manager)
                {
                    ManagerLogin ml = new ManagerLogin();
                    DialogResult rs1 = ml.ShowDialog(this);
                    if (rs1 == DialogResult.OK)
                    {
                        DialogResult confirm = MessageBox.Show(
                              $"Are you sure you want to void order #{orderId}?",
                              "Confirm Void",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Warning
                           );

                        if (confirm == DialogResult.Yes)
                        {
                            try
                            {
                                bool suc = orderServices.voidOrder(orderId);

                                if (suc)
                                {
                                    MessageBox.Show("Order has been voided successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    fetchData();
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Internal Server Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }


            }

            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "Select Order")
            {
                string orderId = dataGridView1.Rows[e.RowIndex].Cells["Order ID"].Value.ToString();
                selectedOrder?.Invoke(this, orderId);
                DialogResult = DialogResult.OK;
            }
        }
    }
}
