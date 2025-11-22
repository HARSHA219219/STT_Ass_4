using System;
using System.Windows.Forms;

namespace Order_Pipeline
{
    public partial class Form1 : Form
    {
        //Custom EventArgs 
        public class ShipEventArgs : EventArgs
        {
            public string Product { get; }
            public bool Express { get; }

            public ShipEventArgs(string product, bool express)
                => (Product, Express) = (product, express);
        }

        // Event Declarations 
        public event EventHandler<ShipEventArgs> OrderCreated;
        public event EventHandler OrderRejected;
        public event EventHandler OrderConfirmed;
        public event EventHandler<ShipEventArgs> OrderShipped; // New event

        // Track order confirmation state
        private bool orderConfirmed = false;

        // Constructor
        public Form1()
        {
            InitializeComponent();

            // Fill combo box
            if (cmbProduct.Items.Count == 0)
                cmbProduct.Items.AddRange(new string[] { "Laptop", "Mouse", "Keyboard" });

            // Event subscriptions
            OrderCreated += ValidateOrder;
            OrderCreated += DisplayOrderInfo;
            OrderRejected += ShowRejection;
            OrderConfirmed += ShowConfirmation;

            // Subscribe to ship button
            btnShipOrder.Click += btnShipOrder_Click;
        }

        // Order Creation 
        private void btnProcessOrder_Click(object sender, EventArgs e)
        {
            string customer = txtCustomer.Text.Trim();
            string product = cmbProduct.SelectedItem?.ToString();
            int quantity = (int)numQuantity.Value;

            if (string.IsNullOrWhiteSpace(customer))
            {
                lblStatus.Text = "Please enter your name first!";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (cmbProduct.SelectedItem == null)
            {
                lblStatus.Text = "Please select a product.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            bool express = quantity > 5; // sample rule
            OrderCreated?.Invoke(this, new ShipEventArgs(product!, express));
        }

        // Validation 
        private void ValidateOrder(object? sender, ShipEventArgs e)
        {
            int quantity = (int)numQuantity.Value;

            if (quantity <= 0)
            {
                lblStatus.Text = "Order Invalid – Quantity must be > 0";
                lblStatus.ForeColor = System.Drawing.Color.White;
                OrderRejected?.Invoke(this, EventArgs.Empty);
                return;
            }

            lblStatus.Text = "Order Validated – Processing...";
            lblStatus.ForeColor = System.Drawing.Color.White;
            OrderConfirmed?.Invoke(this, EventArgs.Empty);
        }

        // Order Summary
        private void DisplayOrderInfo(object? sender, ShipEventArgs e)
        {
            string customer = txtCustomer.Text;
            int quantity = (int)numQuantity.Value;

            MessageBox.Show(
                $"Customer: {customer}\nProduct: {e.Product}\nQuantity: {quantity}\nExpress Shipping: {e.Express}",
                "Order Summary",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        //  Rejection 
        private void ShowRejection(object? sender, EventArgs e)
        {
            lblStatus.Text = "Order Invalid – Please retry.";
            lblStatus.ForeColor = System.Drawing.Color.White;
            orderConfirmed = false;
        }

        // Confirmation 
        private void ShowConfirmation(object? sender, EventArgs e)
        {
            lblStatus.Text = $"Order Processed Successfully for {txtCustomer.Text}";
            lblStatus.ForeColor = System.Drawing.Color.White;
            orderConfirmed = true;
        }

        // Shipping Button
        private void btnShipOrder_Click(object? sender, EventArgs e)
        {
            if (!orderConfirmed)
            {
                MessageBox.Show("You must confirm an order before shipping!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string product = cmbProduct.SelectedItem?.ToString() ?? "Unknown";
            bool express = chkExpress.Checked;

            // Always ensure ShowDispatch is subscribed
            OrderShipped -= ShowDispatch;
            OrderShipped += ShowDispatch;

            // Dynamic subscription filtering
            OrderShipped -= NotifyCourier;
            if (express)
                OrderShipped += NotifyCourier;

            // Trigger event
            OrderShipped?.Invoke(this, new ShipEventArgs(product, express));
        }

        // Shipping Handlers 
        private void ShowDispatch(object? sender, ShipEventArgs e)
        {
            lblStatus.Text = $"Product dispatched: {e.Product}";
            lblStatus.ForeColor = System.Drawing.Color.White;
        }

        private void NotifyCourier(object? sender, ShipEventArgs e)
        {
            if (e.Express)
            {
                MessageBox.Show("🚚 Express delivery initiated!",
                    "Courier Notification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            if (cmbProduct.Items.Count > 0)
                cmbProduct.SelectedIndex = 0;

            lblStatus.Text = "";
        }
    }
}
