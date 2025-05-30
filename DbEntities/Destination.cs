namespace DB.DbEntities
{
    public class Destination : BaseEntity
    {

        public List<string> Participants { get; set; } = new List<string>();
        public DateTime CreationDate { get; set; }
    }
}
