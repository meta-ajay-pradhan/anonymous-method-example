namespace example;
public delegate void anonymous();
public class Program {
    public static void Main(string[] args) {
        anonymous f1 = delegate() {
            Console.WriteLine("This is an anonymous method!");
        };
        f1();
    }
}
