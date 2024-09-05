namespace hw4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String str1 = new String(new char[] { 's', 'o', 'm', 'e', ' ', 't', 'e', 'x', 't' });
            str1.Trim(' ');
            str1.showString();
        }
    }
}
