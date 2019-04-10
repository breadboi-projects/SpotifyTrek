using SpotifyTrek.Model;
using SpotifyTrek.Service;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpotifyTrek
{
    // TODO: Make UI prettier
    // TODO: Add start interface with customization options ( choose genre, starting artist, etc)
    public partial class Form1 : Form
    {
        private Service.Service serv;

        public Form1(Service.Service serv)
        {
            this.serv = serv;
            InitializeComponent();
            RefreshAll();
            RefreshFinal();
        }

        private void RefreshAll()
        {
            RefreshCurrent();
            RefreshRelated();
        }

        private void RefreshCurrent()
        {
            var cA = serv.CurrentArtist;
            currentArtistLabel.Text = cA.Name;
        }

        private void RefreshFinal()
        {
            var fA = serv.FinalArtist;
            finalArtistLabel.Text = fA.Name;
        }

        private void RefreshRelated()
        {
            relatedView.Rows.Clear();
            var l = serv.Related;
            foreach (Artist a in l)
            {
                
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(relatedView);
                
                row.Cells[0].Value = a.Name;
                relatedView.Rows.Add(row);
            }
        }

        private async void currentPlayButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                await serv.PlayPreview(serv.CurrentArtist);
            }
            catch(System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void finalPlayButton_ClickAsync(object sender, System.EventArgs e)
        {
            try
            {
                await serv.PlayPreview(serv.FinalArtist);
            }
            catch(System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task linkCell_Clicked(DataGridViewCellEventArgs e)
        {
            string url = "https://open.spotify.com/artist/" + serv.Related[e.RowIndex].Id;
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (System.Exception) { }
        }

        private async Task sampleCell_Clicked(DataGridViewCellEventArgs e)
        {
            await serv.PlayPreview(serv.Related[e.RowIndex]);
        }

        private async void relatedView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (relatedView.Columns[e.ColumnIndex].Name == "Link")
                    await linkCell_Clicked(e);

                if (relatedView.Columns[e.ColumnIndex].Name == "Sample")
                    await sampleCell_Clicked(e);
            }
            catch(System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void relatedView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                await serv.PickArtist(e.RowIndex);
                RefreshAll();
                if (serv.CheckWin())
                    MessageBox.Show("Congratulations, you've won!");
            }
            catch(System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                serv.StartGame();
                RefreshAll();
                RefreshFinal();
            }
            catch (System.Net.WebException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
