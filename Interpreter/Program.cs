

    class Program
    {

        static void Main(string[] args)
        {
            Context context = new Context("Dot Net context");
            NonterminalExpression root = new NonterminalExpression();
            root.Expression1 = new TerminalExpression();
            root.Expression2 = new TerminalExpression();
            root.Interpret(context);

            Console.ReadKey(true);
        }
    }

