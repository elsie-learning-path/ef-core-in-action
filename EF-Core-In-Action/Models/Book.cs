namespace EF_Core_In_Action.Models
{
    public class Book
    {
        public int BookId {  get; set; }
        
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedOn { get; set; }
        
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
