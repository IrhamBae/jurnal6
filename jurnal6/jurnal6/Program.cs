using System;

public class SayaTubeVideo
{
    internal string getTitle;
    internal int getPlayCount;
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (title == null || title.Length > 100)
        {
            throw new ArgumentNullException("Judul video harus memiliki panjang maksimal 100 karakter dan tidak boleh null");
        }

        Random random = new Random();
        id = random.Next(10000, 99999);

        this.title = title;
        playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException ex)
        {
           Console.WriteLine($"ERROR: {ex.Message}");
        }
    }

    public void PrinVideoDetails()
    {
        Console.WriteLine($"Video ID        : {id}");
        Console.WriteLine($"Judul           : {title}");
        Console.WriteLine($"Jumlah Tayangan : {playCount}");
    }
}

public class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadVideos;
    private string username;

    public SayaTubeUser(string username)
    {
        this.username = username;
        uploadVideos = new List<SayaTubeVideo>();
    }

    public int getTotalVideosPlayCount()
    {
        int total = 0;
        foreach (var item in uploadVideos)
        {
            total = total + item.getPlayCount;
        }
        return total;
    }

    public void AddVideo(SayaTubeVideo video)
    {
        uploadVideos.Add(video);
    }

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine("User : " + this.username);
        for (int i = 1; i < uploadVideos.Count; i++)
        {
            SayaTubeVideo item = uploadVideos[i];
            Console.WriteLine("Video " + i + " " + item.getTitle);

        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Irham");
        SayaTubeVideo vid = new SayaTubeVideo("video Memanggang");
        SayaTubeVideo vid1 = new SayaTubeVideo("video Memanggang");
        SayaTubeVideo vid2= new SayaTubeVideo("video Memanggang");
        SayaTubeVideo vid3 = new SayaTubeVideo("video Memanggang");
        SayaTubeVideo vid4 = new SayaTubeVideo("video Memanggang");
        SayaTubeVideo vid5 = new SayaTubeVideo("video Memanggang");
        SayaTubeVideo vid6 = new SayaTubeVideo("video Memanggang");
        SayaTubeVideo vid7 = new SayaTubeVideo("video Memanggang");
        SayaTubeVideo vid8 = new SayaTubeVideo("video Memanggang");
        SayaTubeVideo vid9= new SayaTubeVideo("video Memanggang");
        user.AddVideo(vid);
        user.AddVideo(vid1);
        user.AddVideo(vid2);
        user.AddVideo(vid3);
        user.AddVideo(vid4);
        user.AddVideo(vid5);
        user.AddVideo(vid6);
        user.AddVideo(vid7);
        user.AddVideo(vid8);
        user.AddVideo(vid9);

        user.PrintAllVideoPlayCount();
    }
}