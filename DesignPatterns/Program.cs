// See https://aka.ms/new-console-template for more information
using DesignPatterns.Creational.FactoryPattern;
using DesignPatterns.DesignPatterns.Creational.AbstractFactoryPattern;
using DesignPatterns.DesignPatterns.Creational.AdapterPattern;
using DesignPatterns.DesignPatterns.Creational.BuilderPattern;
using DesignPatterns.DesignPatterns.Creational.ProtoTypePattern;

Console.WriteLine("Hello, Lets Test our design pattern's code.!");
Console.WriteLine("Test Creational design pattern started.!");
Console.WriteLine();

Console.WriteLine("Test Singleton design pattern ");
string connectionString = "Server=AARUSH\\VARUNMEHTA;Database=ELM;User Id=sa;Password=Aarush@122015;";
var GetObj = DesignPatterns.Creational.SingletonPattern.clsGetSQLConnection.Instance.GetSQLConnection(connectionString);
Console.WriteLine();
//Console.WriteLine("Test Factory design pattern started.!");
//Console.WriteLine();
//Console.WriteLine("Write the DocumentType pdf or word.!");
//string type=Console.ReadLine().ToString();
//IDocument wordDoc = DocumentFactory.GetDocument(type);
//wordDoc.CreateDocument();
//wordDoc.OpenDocument("path/to/word/document");
//Console.WriteLine();
//Console.WriteLine("Adapter design pattern started.!");
//Console.WriteLine();
//IConnection connection = new ConnectionClass("connection-string-here");
//connection.Connect();
//connection.Execute("SELECT * FROM Users");
//connection.Disconnect();
//Console.WriteLine();
//Console.WriteLine("Bulder design pattern started.!");
//Console.WriteLine();
////var document = new DesignPatterns.DesignPatterns.Creational.BuilderPattern.Document.DocBuilder()
////    .WithTitle("Example")
////    .WithContent("This is an example.")
////    .Build();

//Document.DocBuilder builder = new Document.DocBuilder();

//// Chain methods to set properties of the document
//Document myDocument = builder
//                      .WithTitle("My Document Title")
//                      .WithContent("This is the content of the document.")
//                      .Build(); // Finalize and get the Document object

//// The document object is now constructed with the specified properties
//Console.WriteLine($"Document Title: {myDocument.Title}");
//Console.WriteLine($"Document Content: {myDocument.Content}");
//Console.WriteLine();
//Console.WriteLine("ProtoType design pattern started.!");
//Console.WriteLine();

//var originalLicense = new License { LicenseKey = "ABC-123", Owner = "Company Inc." };
//var clonedLicense = originalLicense.Clone();
//clonedLicense.Owner = "New Owner";
//Console.WriteLine("Owner - " + clonedLicense.Owner);
Console.WriteLine();
Console.WriteLine("Abstract FActory design pattern started.!");
Console.WriteLine();

IDocumentFactory reportFactory = new ReportFactory();
var header = reportFactory.SetHeader("This is the header");
var footer = reportFactory.SetFooter("This is the footer");

header.Show();  
footer.Show();  

public abstract class abc
{
    void add() { }

}
public class aa:abc
{

}