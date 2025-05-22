namespace Zadanie_2.API.Models
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public bool IsAvailable { get; set; }
    }
}