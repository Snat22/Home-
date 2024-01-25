using task1;
int _year = Convert.ToInt32(Console.ReadLine());
string authorName = Convert.ToString(Console.ReadLine());
string bookName = Convert.ToString(Console.ReadLine());
System.Console.WriteLine("Write Your book name :");
Book book1 = new Book(bookName ,authorName, _year);
book1.GetInfo();
System.Console.WriteLine(book1.IsPublishedRecently());