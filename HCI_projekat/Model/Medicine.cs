namespace HCI_projekat.Model
{
    public class Medicine
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public bool Approved { get; set; }
        public string ReasonForNotAccepting { get; set; }

        public Medicine(string id, string name, string category, bool approved, string reason)
        {
            Id = id;
            Name = name;
            Category = category;
            Approved = approved;
            ReasonForNotAccepting = reason;
        }
    }
}
