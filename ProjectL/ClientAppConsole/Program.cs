
using ProjectL;

Book book = new Book();
book.Title = " To kill a mocking bird";
book.Author = "Karper Lee";
book.Genere = " social ";
book.BookPrice = 250;
book.DateOfPublish = new DateTime(1995, 6, 1);
book.BookMarkPage(125);

Console.WriteLine(book.GetCurrentPage());
Calculator calculator = new Calculator();
int addResult = calculator.Add(100, 40);
Console.WriteLine(addResult);
int multiplyResult = calculator.Multiply(100, 40);
Console.WriteLine(multiplyResult);
int divideResult = calculator.Divide(100, 40);
Console.WriteLine(divideResult);

