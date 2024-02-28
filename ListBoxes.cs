using System.Windows.Forms;

namespace ListBoxes
{
    public partial class ListBoxes : Form
    {
        public ListBoxes()
        {
            InitializeComponent();
            LeftListBox.AllowDrop = true;
            RightListBox.AllowDrop = true;
        }
        private void ButtonMoveToTheRight_Click(object sender, EventArgs e)
        {
            if (LeftListBox.SelectedIndex >= 0)
            {
                RightListBox.Items.Add(LeftListBox.Items[LeftListBox.SelectedIndex]);
                LeftListBox.Items.RemoveAt(LeftListBox.SelectedIndex);
            }
        }
        private void ButtonMoveAllToTheRight_Click(object sender, EventArgs e)
        {
            if (LeftListBox.Items.Count > 0)
            {
                foreach (var item in LeftListBox.Items)
                {
                    RightListBox.Items.Add(item);
                }
                LeftListBox.Items.Clear();
            }
        }
        private void ButtonMoveAllToTheLeft_Click(object sender, EventArgs e)
        {
            if (RightListBox.Items.Count >= 0)
            {
                foreach (var item in RightListBox.Items)
                {
                    LeftListBox.Items.Add(item);
                }
                RightListBox.Items.Clear();
            }
        }
        private void ButtonMoveToTheLeft_Click(object sender, EventArgs e)
        {
            if (RightListBox.SelectedIndex >= 0)
            {
                LeftListBox.Items.Add(RightListBox.Items[RightListBox.SelectedIndex]);
                RightListBox.Items.RemoveAt(RightListBox.SelectedIndex);
            }
        }
        private void listBoxLeft_DragDrop(object sender, DragEventArgs e)
        {
            if (!LeftListBox.Items.Contains(e.Data.GetData(DataFormats.Text)))
            {
                LeftListBox.Items.Add(e.Data.GetData(DataFormats.Text));
                RightListBox.Items.Remove(e.Data.GetData(DataFormats.Text));
            }
        }
        private void listBoxLeft_MouseDown(object sender, MouseEventArgs e)
        {
            RightListBox.DoDragDrop(LeftListBox.SelectedItem.ToString(), DragDropEffects.Move);
        }
        private void listBoxRight_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void listBoxRight_DragDrop(object sender, DragEventArgs e)
        {
            if (!RightListBox.Items.Contains(e.Data.GetData(DataFormats.Text)))
            {
                RightListBox.Items.Add(e.Data.GetData(DataFormats.Text));
                LeftListBox.Items.Remove(e.Data.GetData(DataFormats.Text));
            }
        }
        private void listBoxLeft_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void listBoxRight_MouseDown(object sender, MouseEventArgs e)
        {
            LeftListBox.DoDragDrop(RightListBox.SelectedItem.ToString(), DragDropEffects.Move);
        }
    }
}
