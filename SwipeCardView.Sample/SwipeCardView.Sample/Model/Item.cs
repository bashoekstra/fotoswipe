using System;

namespace mobile_test.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int age { get; set; }
        public string adress { get; set; }
        public string city { get; set; }
        public int useridentivier { get; set; }

        public static implicit operator Item(string v)
        {
            throw new NotImplementedException();
        }

        // public string Text { get; set; }
        //public string Description { get; set; }
    }
}