using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventPlayground
{
    public partial class Form1 : Form
    {
        // ----------------------------------------------------------
        //  CUSTOM EVENTARGS CLASSES
        // ----------------------------------------------------------

       
        public class ColorChangedEventArgs : EventArgs
        {
            public Color NewColor { get; }
            public ColorChangedEventArgs(Color newColor) => NewColor = newColor;
        }

      
        public class TextChangedEventArgs : EventArgs
        {
            public string NewText { get; }
            public TextChangedEventArgs(string newText) => NewText = newText;
        }

    
        public class ColorEventArgs : EventArgs
        {
            public string ColorName { get; }
            public ColorEventArgs(string name) => ColorName = name;
        }

      
        //  CUSTOM DELEGATES
        public delegate void ColorChangedEventHandler(object sender, ColorChangedEventArgs e);
        public delegate void TextChangedEventHandler(object sender, TextChangedEventArgs e);

        // Task 2 custom delegate
        public delegate void ColorEventHandler(object sender, ColorEventArgs e);

        // ----------------------------------------------------------
        //  EVENTS
        // ----------------------------------------------------------

        public event ColorChangedEventHandler ColorChangedEvent;
        public event TextChangedEventHandler TextChangedEvent;

        // Task 2 new event
        public event ColorEventHandler ColorChanged;

        public Form1()
        {
            InitializeComponent();

            // Task 1 Subscriptions
            this.ColorChangedEvent += OnColorChanged;
            this.TextChangedEvent += OnTextChanged;

            // Task 2 Subscriptions (multicast)
            ColorChanged += UpdateLabelColor;
            ColorChanged += ShowNotification;
        }


        // ----------------------------------------------------------
        //  BUTTON HANDLERS — EVENT RAISING
        // ----------------------------------------------------------

        // Task 1: Change Color (using ColorChangedEvent with Color object)
        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            var selected = comboBoxColors.SelectedItem as string ?? "Black";

            Color color = selected switch
            {
                "Red" => Color.Red,
                "Green" => Color.Green,
                "Blue" => Color.Blue,
                _ => Color.Black
            };

            ColorChangedEvent?.Invoke(this, new ColorChangedEventArgs(color));

            // Task 2: Also raise the extended event for multicast
            ColorChanged?.Invoke(this, new ColorEventArgs(selected));
        }

        // Task 1: Change Text
        private void btnChangeText_Click(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToString("F");
            TextChangedEvent?.Invoke(this, new TextChangedEventArgs(now));
        }


        // ----------------------------------------------------------
        //  EVENT HANDLERS
        // ----------------------------------------------------------

        // Task 1 color updater
        private void OnColorChanged(object sender, ColorChangedEventArgs e)
        {
            lblMessage.ForeColor = e.NewColor;
        }

        // Task 2 subscriber #1
        private void UpdateLabelColor(object sender, ColorEventArgs e)
        {
            lblMessage.ForeColor = Color.FromName(e.ColorName);
            lblMessage.Text = "Color Selected: " + e.ColorName;
        }

        // Task 1 text updater
        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            lblMessage.Text = e.NewText;
        }

        // Task 2 subscriber #2 — MessageBox popup
        private void ShowNotification(object sender, ColorEventArgs e)
        {
            MessageBox.Show(
                "Color changed to: " + e.ColorName,
                "Color Notification",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        private void comboBoxColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            // not used
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // optional initial settings
        }
    }
}
