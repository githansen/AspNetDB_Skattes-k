namespace AspNetDB_Skattesøk.Models
{
    public class Person
    {
        public int Id { get; set; } 
        public string firstname { get; set; }    
        public string lastname { get; set; }
        public DateTime birthdate { get; set; }
        public int salary { get; set; }
        public int wealth { get; set; }
        public int taxes { get; set; }

    }
}
