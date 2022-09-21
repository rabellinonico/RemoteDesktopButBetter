namespace RemoteDesktopButBetter.Helpers
{
    public static class Prompt
    {
        public static string ShowDialogOneInput(string text, string title)
        {
            Form prompt = new()
            {
                Width = 400,
                Height = 130,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                ShowIcon = false
            };
            Label textLabel = new() { Left = 16, Top = 10, Width = 340, Text = text };
            TextBox textBox = new() { Left = 20, Top = 30, Width = 340 };
            Button confirmation = new() { Text = "Add", Left = 260, Width = 100, Top = 60, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
        public static string ShowDialogOneInput(string text, string title, string inputText)
        {
            Form prompt = new()
            {
                Width = 400,
                Height = 130,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                ShowIcon = false
            };
            Label textLabel = new() { Left = 16, Top = 10, Width = 340, Text = text };
            TextBox textBox = new() { Left = 20, Top = 30, Width = 340, Text = inputText };
            Button confirmation = new() { Text = "Edit", Left = 260, Width = 100, Top = 60, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
        public static string[]? ShowDialogTwoInput(string title, string label1, string label2)
        {
            Form prompt = new()
            {
                Width = 400,
                Height = 175,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                ShowIcon = false
            };
            Label textLabel1 = new() { Left = 16, Top = 10, Width = 340, Text = label1 };
            TextBox textBox1 = new() { Left = 20, Top = 30, Width = 340 };
            Label textLabel2 = new() { Left = 16, Top = 55, Width = 340, Text = label2 };
            TextBox textBox2 = new() { Left = 20, Top = 75, Width = 340 };
            Button confirmation = new() { Text = "Add", Left = 260, Width = 100, Top = 105, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox1);
            prompt.Controls.Add(textBox2);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel1);
            prompt.Controls.Add(textLabel2);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? new List<string> { textBox1.Text, textBox2.Text }.ToArray() : null;
        }
        public static string[]? ShowDialogTwoInput(string title, string label1, string label2, string textbox1, string textbox2)
        {
            Form prompt = new()
            {
                Width = 400,
                Height = 175,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                ShowIcon = false
            };
            Label textLabel1 = new() { Left = 16, Top = 10, Width = 340, Text = label1 };
            TextBox textBox1 = new() { Left = 20, Top = 30, Width = 340, Text = textbox1 };
            Label textLabel2 = new() { Left = 16, Top = 55, Width = 340, Text = label2 };
            TextBox textBox2 = new() { Left = 20, Top = 75, Width = 340, Text = textbox2 };
            Button confirmation = new() { Text = "Edit", Left = 260, Width = 100, Top = 105, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox1);
            prompt.Controls.Add(textBox2);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel1);
            prompt.Controls.Add(textLabel2);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? new List<string> { textBox1.Text, textBox2.Text }.ToArray() : null;
        }
    }
}
