using System.Data;

namespace RemoteDesktopButBetter
{
    public partial class ReorderListComponent : Form
    {
        public object[] Items = Array.Empty<object>();
        public ReorderListComponent(object[] Items, string DisplayMember, string LabelText)
        {
            InitializeComponent();

            label1.Text = LabelText;

            foreach (object item in Items)
            {
                ListBoxOrderable.Items.Add(item);
            }
            ListBoxOrderable.SetSelected(0, true);

            ListBoxOrderable.DisplayMember = DisplayMember;
        }

        private void ButtonRowUp_Click(object sender, EventArgs e)
        {
            int index = ListBoxOrderable.SelectedIndex;
            if (index > 0)
            {
                object g = ListBoxOrderable.SelectedItem;
                ListBoxOrderable.Items.Remove(g);
                ListBoxOrderable.Items.Insert(index - 1, g);
                ListBoxOrderable.SetSelected(index - 1, true);
            }
        }
        private void ButtonRowDown_Click(object sender, EventArgs e)
        {
            int index = ListBoxOrderable.SelectedIndex;
            if (index < ListBoxOrderable.Items.Count - 1)
            {
                object g = ListBoxOrderable.SelectedItem;
                ListBoxOrderable.Items.Remove(g);
                ListBoxOrderable.Items.Insert(index + 1, g);
                ListBoxOrderable.SetSelected(index + 1, true);
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Items = ListBoxOrderable.Items.Cast<object>().ToArray();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
