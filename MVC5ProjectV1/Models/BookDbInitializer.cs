using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC5ProjectV1.Models
{
    public class BookDbInitializer:DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Война и мир", Author = "Л.Н.Толстой", Price = 500 });
            db.Books.Add(new Book { Name = "Отцы и дети", Author = "И.Тургенев", Price = 550 });
            db.Books.Add(new Book { Name = "Чайка", Author = "А.П.Чехов", Price = 570 });
            base.Seed(db);
        }
    }
}