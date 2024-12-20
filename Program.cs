// Chain of Responsibility

var handler = new InvoiceHandler();
handler.SetNext(new ReceiptHandler()).SetNext(new BillHandler());

handler.Handle("Invoice");
handler.Handle("Receipt");
handler.Handle("Bill");
handler.Handle("Unknown");

// Command

var editor = new TextEditor();
var commandManager = new CommandManager();

commandManager.ExecuteCommand(new WriteTextCommand(editor, "Hello, "));
commandManager.ExecuteCommand(new WriteTextCommand(editor, "world!"));

commandManager.Undo();
commandManager.Undo();
commandManager.Redo();

// Interpreter
var expression = new AddExpression(
    new NumberExpression(5),
    new SubtractExpression(
        new NumberExpression(10),
        new NumberExpression(3)
    )
);

Console.WriteLine(expression.Interpret());

// Iterator

var playlist = new Playlist();
playlist.Add("Song 1");
playlist.Add("Song 2");
playlist.Add("Song 3");

foreach (var song in playlist) {
    Console.WriteLine(song);
}

// Mediator

var mediator = new ChatMediator();

var user1 = new User("Alice", mediator);
var user2 = new User("Bob", mediator);

user1.SendMessage("Hello, Bob!");
user2.SendMessage("Hi, Alice!");

// Memento
var player = new Player();
player.Position = 5;
player.Health = 100;

var caretaker = new Caretaker();
caretaker.Save(player.SaveState());

player.Position = 10;
caretaker.Restore(player);
Console.WriteLine(player.Position);

// Observer
var order = new Order();
order.Attach(new EmailNotifier());
order.Attach(new SmsNotifier());

order.UpdateStatus("Shipped");

// State
var vendingMachine = new VendingMachine();

vendingMachine.InsertCoin();
vendingMachine.SelectProduct();
vendingMachine.DispenseProduct();

// Strategy
var calculator = new ShippingCalculator(new EconomyShipping());
Console.WriteLine(calculator.Calculate(100));

calculator.SetStrategy(new ExpressShipping());
Console.WriteLine(calculator.Calculate(100));

// Template Method
var pdfReport = new PdfReportGenerator();
pdfReport.GenerateReport();

Console.WriteLine();

var excelReport = new ExcelReportGenerator();
excelReport.GenerateReport();

// Visitor
var elements = new List<IElement>
{
    new ElementA(),
    new ElementB()
};

var validationVisitor = new ValidationVisitor();
var exportVisitor = new ExportVisitor();

foreach (var element in elements)
{
    element.Accept(validationVisitor);
    element.Accept(exportVisitor);
}