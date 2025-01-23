using Vehicles;

namespace Vehicle.Application
{
    class program
    {
        static void Main()
        {
            // Create gasEngine
            GasEngine gasEngine = new GasEngine(100);
            // Create motorbike with gas engine
            MotorBike gasBike = new MotorBike(gasEngine);

            // Test gas engine bike
            Console.Write($"Motorbike with gas engine:\n");
            Console.Write($"  Currrent speed: {gasEngine.GetThrottle()}\n");
            gasBike.RunAtHalfSpeed();
            Console.Write($"  Currrent speed: {gasEngine.GetThrottle()}\n");
            gasEngine.SetThrottle(20);
            Console.Write($"  Currrent speed: {gasEngine.GetThrottle()}\n");


            // Create diesel engine
            DieselEngine dieselEngine = new DieselEngine(50);
            // Create motorbike with diesel engine
            MotorBike dieselBike = new MotorBike(dieselEngine);

            // Test diesel engine bike
            Console.Write($"Motorbike with diesel engine:\n");
            Console.Write($"  Currrent speed: {dieselEngine.GetThrottle()}\n");
            dieselBike.RunAtHalfSpeed();
            Console.Write($"  Currrent speed: {dieselEngine.GetThrottle()}\n");
            dieselEngine.SetThrottle(51);
            Console.Write($"  Currrent speed: {dieselEngine.GetThrottle()}\n");
        }
    }
}