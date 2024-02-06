namespace DTO;
public class Author {
    public int Id { get; set; }
    public string? Name { get; set; }
}

public class Book {
    public string? Name { get; set; }
    public int AuthorId { get; set;}
}

public class BookDTO {
    public string? BookName { get; set; }
    public string? AuthorName { get; set; }
}



