
namespace Album
{
    /// <summary>
    /// This class will ask the user for the name of their favorite album, the artist or band, and the number of tracks.
    /// </summary>
    public class Album
    {
        private string albumName;
        private string artistName;
        private int numOfTracks;

        /// <summary>
        /// This method starts the collection of data from the user. It will change the console title and display a greeting.
        /// Then it will collect all the necessary data and display it back to the user.
        /// </summary>
        public void Start()
        {
            Console.WriteLine("\nGreetings from the Album class!\n");
            Console.Title = "My Favorite Album";

            ReadAbumName();
            ReadArtistName();
            ReadNumOfTracks();
            DisplayAlbumInfo();
        }

        /// <summary>
        /// Reads the name of the album from the user and saves it in the albumName field.
        /// </summary>
        private void ReadAbumName()
        {
            albumName = Cli.Ask("What is the name of your favorite music album? ");
        }

        /// <summary>
        /// Reads the name of the artist or band from the user and saves it in the artistName field.
        /// It uses the albumName field to ask the user for the name of the artist or band for that album.
        /// </summary>
        private void ReadArtistName()
        {
            artistName = Cli.Ask($"What is the name of the artist or band for {albumName} ? ");
        }

        /// <summary>
        /// Reads the number of tracks from the user and saves it in the numOfTracks field.
        /// It uses the albumName field to ask the user for the number of tracks for that album.
        /// </summary>
        private void ReadNumOfTracks()
        {
            numOfTracks = Cli.AskInt($"How many tracks does {albumName} have? ");
        }

        /// <summary>
        /// Displays the album information to the user.
        /// </summary>
        private void DisplayAlbumInfo()
        {
            Console.WriteLine($"Album Name: {albumName}");
            Console.WriteLine($"Artist/Band: {artistName}");
            Console.WriteLine($"Number of tracks: {numOfTracks}");
            Console.WriteLine($"Enjoy listening to {albumName} by {artistName}!");
        }
    }
}