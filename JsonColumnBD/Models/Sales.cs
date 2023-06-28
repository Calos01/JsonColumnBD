namespace JsonColumnBD.Models
{
    public class Sales
    {
        public int Id { get; set; } 
        public string? Name { get; set; }    
        public Customer? Customer { get; set; }
    }
}
