namespace EventPlayground
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button btnChangeText;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ComboBox comboBoxColors;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnChangeColor = new Button();
            btnChangeText = new Button();
            lblMessage = new Label();
            comboBoxColors = new ComboBox();
            SuspendLayout();
            // 
            // btnChangeColor
            // 
            btnChangeColor.Location = new Point(142, 153);
            btnChangeColor.Name = "btnChangeColor";
            btnChangeColor.Size = new Size(184, 83);
            btnChangeColor.TabIndex = 0;
            btnChangeColor.Text = "Change Color";
            btnChangeColor.UseVisualStyleBackColor = true;
            btnChangeColor.Click += btnChangeColor_Click;
            // 
            // btnChangeText
            // 
            btnChangeText.Location = new Point(374, 152);
            btnChangeText.Name = "btnChangeText";
            btnChangeText.Size = new Size(193, 84);
            btnChangeText.TabIndex = 1;
            btnChangeText.Text = "Change Text";
            btnChangeText.UseVisualStyleBackColor = true;
            btnChangeText.Click += btnChangeText_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(269, 28);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(163, 20);
            lblMessage.TabIndex = 2;
            lblMessage.Text = "Welcome to Events Lab";
            // 
            // comboBoxColors
            // 
            comboBoxColors.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxColors.FormattingEnabled = true;
            comboBoxColors.Items.AddRange(new object[] { "Red", "Green", "Blue" });
            comboBoxColors.Location = new Point(240, 70);
            comboBoxColors.Name = "comboBoxColors";
            comboBoxColors.Size = new Size(219, 28);
            comboBoxColors.TabIndex = 3;
            comboBoxColors.SelectedIndexChanged += comboBoxColors_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 300);
            Controls.Add(comboBoxColors);
            Controls.Add(lblMessage);
            Controls.Add(btnChangeText);
            Controls.Add(btnChangeColor);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "EventPlayground";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}