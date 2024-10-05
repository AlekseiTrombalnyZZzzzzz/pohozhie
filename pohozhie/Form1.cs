namespace pohozhie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = new int[100];
            int x = new Random().Next(100,1000);
            string arrx = "";

            for (int i = 0; i < 100; i++)
            {
                arr[i] = new Random().Next(1, 100);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    if (arr[i] * arr[j] == x)
                    { 
                        arrx += arr[i].ToString() + " " + arr[j].ToString() + " ";
                    }
                }
            }

            MessageBox.Show(arrx);
        }
    }
}
