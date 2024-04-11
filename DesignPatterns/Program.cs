 
using DesignPatterns.Creational.FactoryPattern;
using DesignPatterns.DesignPatterns.Structual.AbstractFactoryPattern;
using DesignPatterns.DesignPatterns.Structual.AdapterPattern;
using DesignPatterns.DesignPatterns.Structual.BridgePattern;
using DesignPatterns.DesignPatterns.Structual.BridgePattern2;
using DesignPatterns.DesignPatterns.Structual.BuilderPattern;
using DesignPatterns.DesignPatterns.Structual.CompositePattern;
using DesignPatterns.DesignPatterns.Structual.CompositePattern2;
using DesignPatterns.DesignPatterns.Structual.ProtoTypePattern;
using log4net;
using log4net.Config;
using System.Reflection;
log4net.Config.XmlConfigurator.Configure();

//Console.WriteLine("Hello, Lets Test our design pattern's code.!");
//Console.WriteLine("Test Creational design pattern started.!");
//Console.WriteLine();


//Console.WriteLine("Test Singleton design pattern ");
//string connectionString = "Server=AARUSH\\VARUNMEHTA;Database=ELM;User Id=sa;Password=Aarush@122015;";
//var GetObj = DesignPatterns.Creational.SingletonPattern.clsGetSQLConnection.Instance.GetSQLConnection(connectionString);
//Console.WriteLine();
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
//Console.WriteLine();
//Console.WriteLine("Abstract FActory design pattern started.!");
//Console.WriteLine();

//IDocumentFactory reportFactory = new ReportFactory();
//var header = reportFactory.SetHeader("This is the header");
//var footer = reportFactory.SetFooter("This is the footer");

//header.Show();  
//footer.Show();
Console.WriteLine();
Console.WriteLine("Bridge design pattern started.!");
Console.WriteLine();

//DesignPatterns.DesignPatterns.Structual.BridgePattern.License regularSoftwareLicense = new RegularLicense(new SoftwareLicenseImplementor());
//regularSoftwareLicense.ProcessLicense();

//DesignPatterns.DesignPatterns.Structual.BridgePattern.License temporaryHardwareLicense = new TemporaryLicense(new HardwareLicenseImplementor());
//temporaryHardwareLicense.ProcessLicense();

DocumentHandler wordDocHandler = new WordDocumentHandler(new LocalStorageImplementor());
wordDocHandler.SaveDocument("This is a Word document.");
wordDocHandler.LoadDocument();

DocumentHandler pdfDocHandler = new PdfDocumentHandler(new CloudStorageImplementor());
pdfDocHandler.SaveDocument("This is a PDF document.");
pdfDocHandler.LoadDocument();
/*
 In this example, DocumentHandler is the abstraction that defines how documents are processed, and IStorageImplementor is the implementor for storage mechanisms. 
WordDocumentHandler and PdfDocumentHandler are concrete implementations for handling different document types, and they can use either LocalStorageImplementor or CloudStorageImplementor
to save and load documents. This structure allows changing how documents are processed and where they are stored independently, demonstrating the Bridge pattern's effectiveness 
in the DMS architecture.
*/


ILicenseComponent hardwareLicense = new SingleLicense();
ILicenseComponent softwareLicense = new SingleLicense();
ILicenseComponent internetLicense = new SingleLicense();

// Create a bundle of licenses
LicenseBundle licenseBundle = new LicenseBundle();
licenseBundle.Add(hardwareLicense);
licenseBundle.Add(softwareLicense);
licenseBundle.Add(internetLicense);

// Process individual license
hardwareLicense.Process();

// Process bundle of licenses
licenseBundle.Process();

IDocumentComponent wordFile = new DesignPatterns.DesignPatterns.Structual.CompositePattern2.File();
IDocumentComponent pdfFile = new DesignPatterns.DesignPatterns.Structual.CompositePattern2.File();
IDocumentComponent excelFile = new DesignPatterns.DesignPatterns.Structual.CompositePattern2.File();

// Create a folder and add files to it
Folder projectFolder = new Folder();
projectFolder.Add(wordFile);
projectFolder.Add(pdfFile);
projectFolder.Add(excelFile);

// Perform operation on individual file
wordFile.PerformOperation();

// Perform operation on the folder, affecting all contained files
projectFolder.PerformOperation();
