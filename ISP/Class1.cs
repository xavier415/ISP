namespace ISP
{
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

}
