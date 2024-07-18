class Celsius
{
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      	public static void Main(string[] args)
    {
        int Fahrenheit = System.Convert.ToInt32(args[0]);
            double c = (Fahrenheit - 32) / 1.8;
            System.Console.WriteLine(c+" Celsius");
    }
}
