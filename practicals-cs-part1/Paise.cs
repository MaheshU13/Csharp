class Paise
{
	public static void Main(string[] args)
        {
            double rupees = System.Convert.ToDouble(args[0]);

            int paise = (int)(rupees * 100);

            System.Console.WriteLine(paise+" paise");
        }
}