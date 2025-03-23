public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - [Bagus Hardiyanto]");
            video.IncreasePlayCount(5000000);
            video.PrintVideoDetails();
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

}
