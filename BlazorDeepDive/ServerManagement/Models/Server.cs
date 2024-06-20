namespace ServerManagement.Models
{
    public class Server
    {
        public int ServerId { get; set; }
        public bool IsOnline { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }

        public Server()
        {
            Random random = new();
            int randomNmber = random.Next(0 ,2);
            IsOnline = randomNmber != 0;
        }
    }
}
