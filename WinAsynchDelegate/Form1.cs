using System;
using System.Threading;
using System.Windows.Forms;

namespace WinBackgroundWorker
{
    public partial class WinAsynchDelegate : Form
    {
        private bool Cancel = false; 

        public WinAsynchDelegate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(textBox1.Text, out int seconds))
            {
                Cancel = false; 
                TimeConsulmingMethodDelegate del = new TimeConsulmingMethodDelegate(TimeConsulmingMethod);
                del.BeginInvoke(seconds, null, null); 
            }
            else
            {
                MessageBox.Show("Please enter a valid number!");
            }
        }

        private void TimeConsulmingMethod(int seconds)
        {
            for (int j = 1; j <= seconds; j++)
            {
                if (Cancel)
                {
                    break;
                }

                Thread.Sleep(1000); 
                SetProgress((int)(j * 100 / seconds)); 
            }

            
            if (Cancel)
            {
                MessageBox.Show("Canceled");
                Cancel = false; 
            }
            else
            {
                MessageBox.Show("Complete");
            }
        }

        public void SetProgress(int val)
        {
            if (progressBar1.InvokeRequired)
            {
                
                SetProgressDelegate del = new SetProgressDelegate(SetProgress);
                this.Invoke(del, new object[] { val });
            }
            else
            {
                progressBar1.Value = val;
            }
        }

        
        private delegate void TimeConsulmingMethodDelegate(int seconds);
        private delegate void SetProgressDelegate(int val);

        private void button2_Click(object sender, EventArgs e)
        {
            Cancel = true; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
