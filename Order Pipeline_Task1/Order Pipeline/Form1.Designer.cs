namespace Order_Pipeline
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtCustomer = new TextBox();
            cmbProduct = new ComboBox();
            numQuantity = new NumericUpDown();
            btnProcessOrder = new Button();
            lblCustomerName = new Label();
            lblProduct = new Label();
            lblQuantity = new Label();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(420, 39);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(150, 31);
            txtCustomer.TabIndex = 0;
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Items.AddRange(new object[] { "Laptop", "Mouse", "Keyboard" });
            cmbProduct.Location = new Point(405, 124);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(182, 33);
            cmbProduct.TabIndex = 1;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(405, 206);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(180, 31);
            numQuantity.TabIndex = 2;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnProcessOrder
            // 
            btnProcessOrder.Font = new Font("Arial Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProcessOrder.Location = new Point(314, 294);
            btnProcessOrder.Name = "btnProcessOrder";
            btnProcessOrder.Size = new Size(112, 34);
            btnProcessOrder.TabIndex = 3;
            btnProcessOrder.Text = "Click it";
            btnProcessOrder.UseVisualStyleBackColor = true;
            btnProcessOrder.Click += btnProcessOrder_Click;
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.BackColor = Color.Transparent;
            lblCustomerName.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.ForeColor = SystemColors.ButtonHighlight;
            lblCustomerName.Location = new Point(132, 39);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(234, 26);
            lblCustomerName.TabIndex = 4;
            lblCustomerName.Text = "Please Enter Your name  :";
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.BackColor = Color.Transparent;
            lblProduct.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProduct.ForeColor = SystemColors.ButtonHighlight;
            lblProduct.Location = new Point(200, 124);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(154, 26);
            lblProduct.TabIndex = 5;
            lblProduct.Text = "Select Product  :";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.Transparent;
            lblQuantity.Font = new Font("Arial Narrow", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = SystemColors.ButtonHighlight;
            lblQuantity.Location = new Point(202, 211);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(152, 26);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Enter Quantity  :";
            // 

            // lblStatus
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = SystemColors.ButtonHighlight;
            lblStatus.Location = new Point(130, 350);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 26);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "";



            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(lblQuantity);
            Controls.Add(lblProduct);
            Controls.Add(lblCustomerName);
            Controls.Add(btnProcessOrder);
            Controls.Add(numQuantity);
            Controls.Add(cmbProduct);
            Controls.Add(txtCustomer);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomer;
        private ComboBox cmbProduct;
        private NumericUpDown numQuantity;
        private Button btnProcessOrder;
        private Label lblCustomerName;
        private Label lblProduct;
        private Label lblQuantity;
        private Label lblStatus;
    }
}
