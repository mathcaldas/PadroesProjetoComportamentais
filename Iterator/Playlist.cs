public class Playlist
{
    private List <string> songs = new List<string>();

    public void Add(string song)
    {
        songs.Add(song);
    }

    public IEnumerator<string> GetEnumerator()
    {
        foreach (var song in songs)
        {
            yield return song;
        }
    }
}
