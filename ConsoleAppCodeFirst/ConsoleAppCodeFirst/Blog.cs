using System.Collections.Generic;

namespace ConsoleAppCodeFirst
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public virtual List<Post> Posts { get; set; }
    }
}
