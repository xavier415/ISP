using System;

class Program
{
    static void Main(string[] args)
    {
        IPrinter simplePrinter = new SimplePrinter();
        simplePrinter.Print("Documento de prueba para SimplePrinter");

        IPrinter multiFunctionPrinter = new MultiFunctionPrinter();
        multiFunctionPrinter.Print("Documento de prueba para MultiFunctionPrinter");

        IScanner scanner = new MultiFunctionPrinter();
        scanner.Scan("Documento de prueba para escanear");
    }
}

public interface IPrinter
{
    void Print(string document);
}

public interface IScanner
{
    void Scan(string document);
}

public class SimplePrinter : IPrinter
{
    public void Print(string document)
    {
        
        Console.WriteLine($"Imprimiendo: {document}");
    }
}

public class MultiFunctionPrinter : IPrinter, IScanner
{
    public void Print(string document)
    {
       
        Console.WriteLine($"Imprimiendo: {document}");
    }

    public void Scan(string document)
    {
        
        Console.WriteLine($"Escaneando: {document}");
    }
}
