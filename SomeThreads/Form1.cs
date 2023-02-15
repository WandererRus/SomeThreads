namespace SomeThreads
{
    public partial class Form1 : Form
    {
        Thread[] threads = new Thread[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart start = new ThreadStart(WriteNumbers);
            threads[0] = new Thread(start);
            threads[0].Priority = ThreadPriority.
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ThreadStart start = new ThreadStart(WriteChars);
            threads[1] = new Thread(start);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ThreadStart start = new ThreadStart(WriteSymbols);
            threads[2] = new Thread(start);
        }
        void WriteSymbols()
        {
            
        }
        void WriteNumbers()
        {

        }
        void WriteChars()
        {

        }
    }
}