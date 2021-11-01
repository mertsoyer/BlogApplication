using BlogApplication.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApplication.Entities.Concrete
{
    public class Article:EntityBase,IEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public DateTime Date { get; set; }
        public int ViewsCount { get; set; }
        public int CommentCount { get; set; }
        public string SeoAuthor { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTags { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } //navigation property->bir article'ın bir tane kategorisi olabilir
        public int UserId { get; set; }
        public User User { get; set; } //navigation property->bir article'in bir tane user'ı olabilir navigation property
        public ICollection<Comment> Comments { get; set; }

    }
}
