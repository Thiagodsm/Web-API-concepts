namespace BuberBreakfast.Models
{
    public class Breakfast
    {
        public Guid Id { get; }
        public string Name { get; }
        public string Description { get; }
        public DateTime StartDateTime { get; }
        public DateTime EndDateTime { get; }
        public DateTime LastModifiedDateTime { get; }
        public List<string> Savory { get; }
        public List<string> Sweet { get; }

        public Breakfast(Guid Id, string Name, string Description, DateTime StartDateTime, DateTime EndDateTime, DateTime LastModifiedDateTime, List<string> Savory, List<string> Sweet)
        {
            // enforce invariants
            Id = Id;
            Name = Name;
            Description = Description;
            StartDateTime = StartDateTime;
            EndDateTime = EndDateTime;
            LastModifiedDateTime = LastModifiedDateTime;
            Savory = Savory;
            Sweet = Sweet;
        }
    }
}
