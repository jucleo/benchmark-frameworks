
namespace api.Models
{
    public class ContactMessage
    {
      public int Id { get; set; }
        public string Body { get; set; } = string.Empty;

        public int ContactId { get; set; }
        public Contact? Contact { get; set; }

    }
}