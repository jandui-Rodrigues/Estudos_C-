using DTO;

List<Author> authors = new List<Author>
{
    new Author { Id = 1, Name = "Clarice Lispector"},
    new Author { Id = 2, Name = "Jorge Amado" }
};

List <Book> books = new List<Book>
{
    new Book { Name = "Capitães da Areia", AuthorId = 2},
    new Book { Name = "Água Viva", AuthorId = 1},
    new Book { Name = "A hora da Estrela", AuthorId = 1},
    new Book { Name = "Cacau", AuthorId = 2},
};

var booksList = from book in books
                from author in authors
                    where author.Id == book.AuthorId
                select new BookDTO { BookName = book.Name, AuthorName = author.Name };
foreach(BookDTO book in booksList)
{
    Console.WriteLine(book.BookName + " - Author: " +book.AuthorName);
}

// ---------==== Order By

 List<string> names = new List<string>
{
    "Roberta", "Laura", "Maria", "Ana", "Pedro", "Ricardo"
};

var orderedNames = from name in names
                    orderby name
                    select name;

foreach(string orderedName in orderedNames) {
    Console.WriteLine(orderedName);
}

var orderedNamesDesc = from name in names
                    orderby name descending
                    select name;
// ---------==== Group By

var groupedNames = from name in names
                    group name by name.Length;

// ---------==== Join

var booksWithAuthors = from book in books
                        join author in authors on book.AuthorId equals author.Id
                        select new { BookName = book.Name, AuthorName = author.Name };

foreach(var book in booksWithAuthors)
{
    Console.WriteLine(book.BookName + " - Author: " + book.AuthorName);
}
