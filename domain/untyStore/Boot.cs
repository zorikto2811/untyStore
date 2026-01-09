
namespace untyStore
{
    public class Boot
    {
        public int Id { get; }

        public string Title { get; }

        public Boot(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
