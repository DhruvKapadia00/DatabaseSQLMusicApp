using System.Windows.Forms;

namespace DatabaseSQLMusicApp
{
    public partial class Form1 : Form


    {
        BindingSource albumBindingSource = new BindingSource();
        BindingSource trackBindingSource = new BindingSource();

        List<Album> albums = new List<Album>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();


            albums = albumsDAO.getAllAlbums();


            albumBindingSource.DataSource = albums;

            dataGridView1.DataSource = albumBindingSource.DataSource;

            pictureBox1.Load("https://upload.wikimedia.org/wikipedia/en/4/42/Beatles_-_Abbey_Road.jpg");



        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    AlbumsDAO albumsDAO = new AlbumsDAO();


        //    albumBindingSource.DataSource = albumsDAO.searchTitles(textBox1.Text);


        //    dataGridView1.DataSource = albumBindingSource.DataSource;

        //}

        private void button3_Click_1(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();


            albumBindingSource.DataSource = albumsDAO.searchTitles(textBox1.Text);


            dataGridView1.DataSource = albumBindingSource.DataSource;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            int rowClicked = dataGridView.CurrentRow.Index;

            String imageURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();

            //  MessageBox.Show("URL=" + imageURL);
            pictureBox1.Load(imageURL);



            trackBindingSource.DataSource = albums[rowClicked].Tracks;
                
            //    albumsDAO.getTrackUsingJoin((int)dataGridView.Rows[rowClicked].Cells[0].Value);

            dataGridView2.DataSource = trackBindingSource.DataSource;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_ImageURL_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Album album = new Album()
            {
                AlbumName = txt_album.Text,
                ArtistName = txt_artist.Text,
                year = Int32.Parse(txt_year.Text),
                ImageURL = txt_ImageURL.Text,
                Description = txt_description.Text
            };
            AlbumsDAO albumDAO = new AlbumsDAO();
            int result = albumDAO.addOneAlbum(album);

            MessageBox.Show(result + " new row(s) inserted");

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
