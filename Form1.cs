using System.Windows.Forms;

namespace ListBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.AllowDrop = true;
            listBox2.AllowDrop = true;
        }

        private void ButtonMoveToTheRight(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox2.Items.Add(listBox1.Items[listBox1.SelectedIndex]);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void ButtonMoveAllToTheRight(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                foreach (var item in listBox1.Items)
                {
                    listBox2.Items.Add(item);
                }
                listBox1.Items.Clear();
            }
        }

        private void ButtonMoveAllToTheLeft(object sender, EventArgs e)
        {
            if (listBox2.Items.Count >= 0)
            {
                foreach (var item in listBox2.Items)
                {
                    listBox1.Items.Add(item);
                }
                listBox2.Items.Clear();
            }
        }

        private void ButtonMoveToTheLeft(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                listBox1.Items.Add(listBox2.Items[listBox2.SelectedIndex]);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void listBoxLeft_DragDrop(object sender, DragEventArgs e)
        {
            if (!listBox1.Items.Contains(e.Data.GetData(DataFormats.Text)))
            {
                listBox1.Items.Add(e.Data.GetData(DataFormats.Text));
                listBox2.Items.Remove(e.Data.GetData(DataFormats.Text));
            }
        }

        private void listBoxLeft_MouseDown(object sender, MouseEventArgs e)
        {
            listBox2.DoDragDrop(listBox1.SelectedItem.ToString(), DragDropEffects.Move);
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
            if (!listBox2.Items.Contains(e.Data.GetData(DataFormats.Text)))
            {
                listBox2.Items.Add(e.Data.GetData(DataFormats.Text));
                listBox1.Items.Remove(e.Data.GetData(DataFormats.Text));
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
            listBox1.DoDragDrop(listBox2.SelectedItem.ToString(), DragDropEffects.Move);
        }
    }
}
