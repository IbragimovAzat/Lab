namespace WinFormsApp1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void create_pub_Click(object sender, EventArgs e)
        {
            AddPub newForm = new AddPub();
            newForm.Show();
        }

        private void ������������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Authors newForm = new Authors();
            newForm.Show();
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlacesOfWork newForm = new PlacesOfWork();
            newForm.Show();
        }

        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PubHouses newForm = new PubHouses();
            newForm.Show();
        }

        private void delete_pub_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdatePub newForm = new UpdatePub();
            newForm.Show();
        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeOfPub newForm = new TypeOfPub();
            newForm.Show();
        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Degree newForm = new Degree();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}