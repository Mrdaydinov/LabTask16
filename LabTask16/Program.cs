namespace LabTask16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bird bird = new Bird("deff", 0, 0);
            Chicken chicken = new Chicken("chicken", 5, 6);
            Duck duck = new Duck("duck", 5, 3);
            Eagle eagle = new Eagle("eagle", 7, 8);

            chicken.Run();
            duck.Swim();
            eagle.Fly();
        }
    }
}
