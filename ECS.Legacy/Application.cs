namespace ECSLegacy
{
    public class Application
    {
        public static void Main(string[] args)
        {
            ITempSensor _tempSensor = new TempSensor();
            IHeater _heater = new Heater();

            var ecs = new ECS(28,_heater,_tempSensor);

            ecs.Regulate();

            ecs.SetThreshold(20);

            ecs.Regulate();

        }
    }
}
