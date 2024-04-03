// See https://aka.ms/new-console-template for more information
using DesignPatterns.Creational.FactoryPattern;

Console.WriteLine("Hello, Lets Test our design pattern's code.!");
Console.WriteLine("Test Creational design pattern started.!");
Console.WriteLine();

Console.WriteLine("Test Singleton design pattern ");
string connectionString = "Server=AARUSH\\VARUNMEHTA;Database=ELM;User Id=sa;Password=Aarush@122015;";
var GetObj = DesignPatterns.Creational.SingletonPattern.clsGetSQLConnection.Instance.GetSQLConnection(connectionString);
Console.WriteLine();
Console.WriteLine("Test Factory design pattern started.!");
Console.WriteLine();
Console.WriteLine("Write the DocumentType pdf or word.!");
string type=Console.ReadLine().ToString();
IDocument wordDoc = DocumentFactory.GetDocument(type);
wordDoc.CreateDocument();
wordDoc.OpenDocument("path/to/word/document");

