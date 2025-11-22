using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventPlayground
{
    public partial class Form1 : Form
    {
        // Custom EventArgs for color change
        public class ColorChangedEventArgs : EventArgs
        {
            public Color NewColor { get; }
            public ColorChangedEventArgs(Color newColor) => NewColor = newColor;
        }

        // Custom EventArgs for text change
        public class TextChangedEventArgs : EventArgs
        {
            public string NewText { get; }
            public TextChangedEventArgs(string newText) => NewText = newText;
        }

        // Custom delegate types (not using built-in EventHandler directly)
        public delegate void ColorChangedEventHandler(object sender, ColorChangedEventArgs e);
        public delegate void TextChangedEventHandler(object sender, TextChangedEventArgs e);

        // Events using custom delegates
        public event ColorChangedEventHandler ColorChangedEvent;
        public event TextChangedEventHandler TextChangedEvent;

        public Form1()
        {
            InitializeComponent();

            // Subscribe the form handlers to the custom events
            this.ColorChangedEvent += OnColorChanged;
            this.TextChangedEvent += OnTextChanged;
        }

        // Button click handlers raise the custom events
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

            // Invoke the custom event
            ColorChangedEvent?.Invoke(this, new ColorChangedEventArgs(color));
        }

        private void btnChangeText_Click(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToString("F"); // full date/time pattern
            TextChangedEvent?.Invoke(this, new TextChangedEventArgs(now));
        }

        // Event handlers update the UI
        private void OnColorChanged(object sender, ColorChangedEventArgs e)
        {
            lblMessage.ForeColor = e.NewColor;
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            lblMessage.Text = e.NewText;
        }

        private void comboBoxColors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}