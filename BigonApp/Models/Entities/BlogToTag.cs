﻿namespace BigonApp.Models.Entities
{
    public class BlogToTag:BaseEntity<int>
    {
        public int BlogId { get; set; }
        public Blog? Blog { get; set; }
        public int TagId { get; set; }
        public Tag? Tag { get; set; }
    }
}
