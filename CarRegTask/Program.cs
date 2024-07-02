namespace CarRegTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int charge = 0;
            Console.Write("Enter your car registration: ");
            string carReg = Console.ReadLine();
            while (carReg.Length > 8)
            {
                string displayMessge = " is not valid";
                Console.Write(displayMessge);
                carReg = Console.ReadLine();
            }
            Console.Write("Enter your stay in hours: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            if (hours < 2)
            {
                charge = 0;
            }
            else
            {
                charge = hours * 2;
            }
            Console.WriteLine(charge);

            // rewrite line 12 to concatenate the car registration with the string is not valid
            // store the result in display message

            // the charge for parking for two or more hours is changed to include an additional £2 fee
            // rewrite line 24 to show this change

            // Test both changes with the following test data
            // A369 WNV1
            // BV03 NXD, 5 
            // CS73 CSP, 1
            // Show your test evidence in the Readme
        }
    }
}
