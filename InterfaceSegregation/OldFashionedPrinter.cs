namespace InterfaceSegregation
{
    internal class OldFashionedPrinter
    {
    }

    internal interface IMultiFUnctionDevice : IScanner, IPrinter
    {

    }
    public class MultiFUctionMachine : IMultiFUnctionDevice
    {
        private IPrinter print;
        private IScanner scan;

        public MultiFUctionMachine(IPrinter print, IScanner scanner)
        {
            this.print = print;
            scan = scanner;
        }

        public void Print(Document d)
        {
            print.Print(d);
        }

        public void Scan(Document d)
        {
            scan.Scan(d);
        }
    }
}
