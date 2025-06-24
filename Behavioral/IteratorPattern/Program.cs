// See https://aka.ms/new-console-template for more information

using IteratorPattern.Service;

public static class Program {

    public static void Main() {
        var shelf = new BookShelf();

        shelf.Add(new IteratorPattern.Model.Book() {
            Name = "Spider man"
        });
        shelf.Add(new IteratorPattern.Model.Book()
        {
            Name = "Iron Man"
        });
        shelf.Add(new IteratorPattern.Model.Book()
        {
            Name = "Dron Man"
        });

        var iterator = shelf.CreateIterator();

        while (iterator.HasNext()) {
            var current = iterator.Current();
            Console.WriteLine("Book Name - " + current.Name);
            iterator.Next();
        }
    }
}
