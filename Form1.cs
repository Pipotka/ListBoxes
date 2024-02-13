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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox2.Items.Add(listBox1.Items[listBox1.SelectedIndex]);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                listBox1.Items.Add(listBox2.Items[listBox2.SelectedIndex]);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (!listBox1.Items.Contains(e.Data.GetData(DataFormats.Text)))
            {
                listBox1.Items.Add(e.Data.GetData(DataFormats.Text));
                listBox2.Items.Remove(e.Data.GetData(DataFormats.Text));
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            listBox2.DoDragDrop(listBox1.SelectedItem.ToString(), DragDropEffects.Move);
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
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

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            if (!listBox2.Items.Contains(e.Data.GetData(DataFormats.Text)))
            {
                listBox2.Items.Add(e.Data.GetData(DataFormats.Text));
                listBox1.Items.Remove(e.Data.GetData(DataFormats.Text));
            }
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
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

        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            listBox1.DoDragDrop(listBox2.SelectedItem.ToString(), DragDropEffects.Move);
        }
    }
}
