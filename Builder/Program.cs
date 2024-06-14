
    class Program
    {
        static void Main(string[] args)
        {
            IRobotBuilder robotBuilderOld = new RobotBulderOld();
            
            RobotBuilder robotBuilder = new RobotBuilder(robotBuilderOld);
            robotBuilder.makeRobot();

            Robot robot = robotBuilder.getRobot();

            Console.WriteLine("  Robot Head " + robot.getRobotHead());
            Console.ReadKey(true);
        }
    }

