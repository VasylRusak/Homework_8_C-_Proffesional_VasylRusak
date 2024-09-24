using System.Text.Json;

namespace Task_5
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main()
        {
            User user = new User { Username = "JohnDoe", Email = "email@gmail.com", Age = 35 };
            string json = JsonSerializer.Serialize(user, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine("JSON:\n" + json);

            File.WriteAllText("user.json", json); 
        }
    }
}
