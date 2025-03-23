using System;

public class SayaTubeVideo
{
    private static Random rand = new Random(); // Menghindari masalah ID yang sama karena pembuatan instance Random di setiap objek
    private int id;
    private string judulVideo;
    private int playCount;

    public SayaTubeVideo(string judulVideo)
    {
        if (string.IsNullOrWhiteSpace(judulVideo))
        {
            throw new ArgumentException("Judul video tidak boleh kosong atau hanya berisi spasi.");
        }
        if (judulVideo.Length > 100)
        {
            throw new ArgumentException("Judul video tidak boleh lebih dari 100 karakter.");
        }

        this.id = rand.Next(10000, 99999); // ID tetap unik dalam range tertentu
        this.judulVideo = judulVideo;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0)
        {
            throw new ArgumentException("Penambahan playCount tidak boleh negatif.");
        }

        if (count > 10000000)
        {
            throw new ArgumentOutOfRangeException("count", "Penambahan playCount maksimal 10.000.000 per panggilan.");
        }

        try
        {
            checked
            {
                this.playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: Terjadi overflow pada playCount. Play count tetap pada nilai sebelumnya.");
        }
    }

    public void PrintVideoDetails()
    {

        Console.WriteLine($"ID: {this.id}");
        Console.WriteLine($"Judul Video: {this.judulVideo}");
        Console.WriteLine($"Play Count: {this.playCount}");


    }
}
