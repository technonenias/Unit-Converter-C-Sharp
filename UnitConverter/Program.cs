public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome in unit converter.");
        for (int i = 0; i == 0;)
        {
            Console.WriteLine("Select first Unit: 1- Meter, 2-Centimeter, 3-Kilometer, 4-Inch, 5-Foot, 6-Land Mile, 7- Nautical Mile or 8 to EXIT converter: ");
            string choose1 = Console.ReadLine();
            if (choose1 == "8")
            {
                i++;
            }
            else
            {
                Console.WriteLine("Select second Unit: 1- Meter, 2-Centimeter, 3-Kilometer, 4-Inch, 5-Foot, 6-Land Mile, 7- Nautical Mile: ");
                string choose2 = Console.ReadLine();
                string choose = choose1 + choose2;


                switch (choose)
                {

                    case "12":
                        Console.WriteLine("Input value in meters (only number)");
                        double num1 = Convert.ToDouble(Console.ReadLine());
                        MeterCentimeter(num1);
                        break;

                    case "13":
                        Console.WriteLine("Input value in meters (only number)");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        MeterKilometer(num2);
                        break;

                    case "14":
                        Console.WriteLine("Input value in meters (only number)");
                        double num3 = Convert.ToDouble(Console.ReadLine());
                        MeterInch(num3);
                        break;

                    case "15":
                        Console.WriteLine("Input value in meters (only number)");
                        double num4 = Convert.ToDouble(Console.ReadLine());
                        MeterFoot(num4);
                        break;

                    case "16":
                        Console.WriteLine("Input value in meters (only number)");
                        double num5 = Convert.ToDouble(Console.ReadLine());
                        MeterLandMile(num5);
                        break;

                    case "17":
                        Console.WriteLine("Input value in meters (only number)");
                        double num6 = Convert.ToDouble(Console.ReadLine());
                        MeterNauticalMile(num6);
                        break;

                    case "21":
                        Console.WriteLine("Input value in centimeters (only number)");
                        double num7 = Convert.ToDouble(Console.ReadLine());
                        CentimeterMeter(num7);
                        break;

                    case "23":
                        Console.WriteLine("Input value in centimeters (only number)");
                        double num8 = Convert.ToDouble(Console.ReadLine());
                        CentimeterKilometer(num8);
                        break;

                    case "24":
                        Console.WriteLine("Input value in centimeters (only number)");
                        double num9 = Convert.ToDouble(Console.ReadLine());
                        CentimeterInch(num9);
                        break;

                    case "25":
                        Console.WriteLine("Input value in centimeters (only number)");
                        double num10 = Convert.ToDouble(Console.ReadLine());
                        CentimeterFoot(num10);
                        break;

                    case "26":
                        Console.WriteLine("Input value in centimeters (only number)");
                        double num11 = Convert.ToDouble(Console.ReadLine());
                        CentimeterLandMile(num11);
                        break;

                    case "27":
                        Console.WriteLine("Input value in centimeters (only number)");
                        double num12 = Convert.ToDouble(Console.ReadLine());
                        CentimeterNauticalMile(num12);
                        break;

                    case "31":
                        Console.WriteLine("Input value in kilometers (only number)");
                        double num13 = Convert.ToDouble(Console.ReadLine());
                        KilometerMeter(num13);
                        break;

                    case "32":
                        Console.WriteLine("Input value in kilometers (only number)");
                        double num14 = Convert.ToDouble(Console.ReadLine());
                        KilometerCentimeter(num14);
                        break;

                    case "34":
                        Console.WriteLine("Input value in kilometers (only number)");
                        double num15 = Convert.ToDouble(Console.ReadLine());
                        KilometerInch(num15);
                        break;

                    case "35":
                        Console.WriteLine("Input value in kilometers (only number)");
                        double num16 = Convert.ToDouble(Console.ReadLine());
                        KilometerFoot(num16);
                        break;

                    case "36":
                        Console.WriteLine("Input value in kilometers (only number)");
                        double num17 = Convert.ToDouble(Console.ReadLine());
                        KilometerLandMile(num17);
                        break;

                        
                    case "37":
                        Console.WriteLine("Input value in kilometers (only number)");
                        double num18 = Convert.ToDouble(Console.ReadLine());
                        KilometerNauticalMile(num18);
                        break;

                    case "41":
                        Console.WriteLine("Input value in inches (only number)");
                        double num19 = Convert.ToDouble(Console.ReadLine());
                        InchMeter(num19);
                        break;

                    case "42":
                        Console.WriteLine("Input value in inches (only number)");
                        double num20 = Convert.ToDouble(Console.ReadLine());
                        InchCentimeter(num20);
                        break;


                    case "43":
                        Console.WriteLine("Input value in inches (only number)");
                        double num21 = Convert.ToDouble(Console.ReadLine());
                        InchKilometer(num21);
                        break;

                    case "45":
                        Console.WriteLine("Input value in inches (only number)");
                        double num22 = Convert.ToDouble(Console.ReadLine());
                        InchFoot(num22);
                        break;

                    case "46":
                        Console.WriteLine("Input value in inches (only number)");
                        double num23 = Convert.ToDouble(Console.ReadLine());
                        InchLandMile(num23);
                        break;

                    case "47":
                        Console.WriteLine("Input value in inches (only number)");
                        double num24 = Convert.ToDouble(Console.ReadLine());
                        InchNauticalMile(num24);
                        break;

                    case "51":
                        Console.WriteLine("Input value in feet (only number)");
                        double num25 = Convert.ToDouble(Console.ReadLine());
                        FootMeter(num25);
                        break;

                    case "52":
                        Console.WriteLine("Input value in feet (only number)");
                        double num26 = Convert.ToDouble(Console.ReadLine());
                        FootCentimeter(num26);
                        break;

                    case "53":
                        Console.WriteLine("Input value in feet (only number)");
                        double num27 = Convert.ToDouble(Console.ReadLine());
                        FootKilometer(num27);
                        break;

                    case "54":
                        Console.WriteLine("Input value in feet (only number)");
                        double num28 = Convert.ToDouble(Console.ReadLine());
                        FootInch(num28);
                        break;

                    case "56":
                        Console.WriteLine("Input value in feet (only number)");
                        double num29 = Convert.ToDouble(Console.ReadLine());
                        FootLandMile(num29);
                        break;

                    case "57":
                        Console.WriteLine("Input value in feet (only number)");
                        double num30 = Convert.ToDouble(Console.ReadLine());
                        FootNauticalMile(num30);
                        break;

                    case "61":
                        Console.WriteLine("Input value in land miles (only number)");
                        double num31 = Convert.ToDouble(Console.ReadLine());
                        LandMileMeter(num31);
                        break;

                    case "62":
                        Console.WriteLine("Input value in land miles (only number)");
                        double num32 = Convert.ToDouble(Console.ReadLine());
                        LandMileCentimeter(num32);
                        break;

                    case "63":
                        Console.WriteLine("Input value in land miles (only number)");
                        double num33 = Convert.ToDouble(Console.ReadLine());
                        LandMileKilometer(num33);
                        break;

                    case "64":
                        Console.WriteLine("Input value in land miles (only number)");
                        double num34 = Convert.ToDouble(Console.ReadLine());
                        LandMileInch(num34);
                        break;

                    case "65":
                        Console.WriteLine("Input value in land miles (only number)");
                        double num35 = Convert.ToDouble(Console.ReadLine());
                        LandMileFoot(num35);
                        break;

                    case "67":
                        Console.WriteLine("Input value in land miles (only number)");
                        double num36 = Convert.ToDouble(Console.ReadLine());
                        LandMileNauticalMile(num36);
                        break;

                    case "71":
                        Console.WriteLine("Input value in nautical miles (only number)");
                        double num37 = Convert.ToDouble(Console.ReadLine());
                        NauticalMileMeter(num37);
                        break;

                    case "72":
                        Console.WriteLine("Input value in nautical miles (only number)");
                        double num38 = Convert.ToDouble(Console.ReadLine());
                        NauticalMileCentimeter(num38);
                        break;

                    case "73":
                        Console.WriteLine("Input value in nautical miles (only number)");
                        double num39 = Convert.ToDouble(Console.ReadLine());
                        NauticalMileKilometer(num39);
                        break;

                    case "74":
                        Console.WriteLine("Input value in nautical miles (only number)");
                        double num40 = Convert.ToDouble(Console.ReadLine());
                        NauticalMileInch(num40);
                        break;

                    case "75":
                        Console.WriteLine("Input value in nautical miles (only number)");
                        double num41 = Convert.ToDouble(Console.ReadLine());
                        NauticalMileFoot(num41);
                        break;

                    case "76":
                        Console.WriteLine("Input value in nautical miles (only number)");
                        double num42 = Convert.ToDouble(Console.ReadLine());
                        NauticalMileLandMile(num42);
                        break;
                }
            }
            static void MeterCentimeter(double x1)
            {
                double converted1 = x1 * 100;
                Console.WriteLine($"It is  {converted1} centimeters");
            }
            static void MeterKilometer(double x2)
            {
                double converted2 = x2 / 1000;
                Console.WriteLine($"It is  {converted2} kilometers");
            }
            static void MeterInch(double x3)
            {
                double converted3 = x3 * 39.37;
                Console.WriteLine($"It is  {converted3} inches");
            }
            static void MeterFoot(double x4)
            {
                double converted4 = x4 * 3.281;
                Console.WriteLine($"It is  {converted4} feets");
            }
            static void MeterLandMile(double x5)
            {
                double converted5 = x5 / 1609;
                Console.WriteLine($"It is  {converted5} land miles");
            }

            static void MeterNauticalMile(double x6)
            {
                double converted6 = x6 / 1852;
                Console.WriteLine($"It is  {converted6} nautical miles");
            }

            static void CentimeterMeter(double x7)
            {
                double converted7 = x7 / 100;
                Console.WriteLine($"It is  {converted7} meters");
            }

            static void CentimeterKilometer(double x8)
            {
                double converted8 = x8 / 100000;
                Console.WriteLine($"It is  {converted8} kilometers");
            }

            static void CentimeterInch(double x9)
            {
                double converted9 = x9 / 2.54;
                Console.WriteLine($"It is  {converted9} inches");
            }

            static void CentimeterFoot(double x10)
            {
                double converted10 = x10 / 30.48;
                Console.WriteLine($"It is  {converted10} feets");
            }

            static void CentimeterLandMile(double x11)
            {
                double converted11 = x11 / 160900;
                Console.WriteLine($"It is  {converted11} land miles");
            }

            static void CentimeterNauticalMile(double x12)
            {
                double converted12 = x12 / 185200;
                
                Console.WriteLine($"It is  {converted12} nautical miles");
            }

            static void KilometerMeter(double x13)
            {
                double converted13 = x13 * 1000;
                
                Console.WriteLine($"It is  {converted13} meters");
            }

            static void KilometerCentimeter(double x14)
            {
                double converted14 = x14 * 100000;
                
                Console.WriteLine($"It is  {converted14} centimeters");
            }

            static void KilometerInch(double x15)
            {
                double converted15 = x15 * 39370;
                
                Console.WriteLine($"It is  {converted15} inches");
            }

            static void KilometerFoot(double x16)
            {
                double converted16 = x16 * 3281;
                
                Console.WriteLine($"It is  {converted16} feets");
            }

            static void KilometerLandMile(double x17)
            {
                double converted17 = x17 / 1.609;
                
                Console.WriteLine($"It is  {converted17} land miles");
            }

            static void KilometerNauticalMile(double x18)
            {
                double converted18 = x18 / 1.852;
                
                Console.WriteLine($"It is  {converted18} nautical miles");
            }

            static void InchMeter(double x19)
            {
                double converted19 = x19 / 39.37;
                
                Console.WriteLine($"It is  {converted19} meters");
            }

            
            static void InchCentimeter(double x20)
            {
                double converted20 = x20 * 2.54;
                
                Console.WriteLine($"It is  {converted20} centimeters");
            }

            static void InchKilometer(double x21)
            {
                double converted21 = x21 / 39370;
                
                Console.WriteLine($"It is  {converted21} kilometers");
            }

            static void InchFoot(double x22)
            {
                double converted22 = x22 / 12;
                
                Console.WriteLine($"It is  {converted22} feets");
            }

            static void InchLandMile(double x23)
            {
                double converted23 = x23 * 0.000015783;
                
                Console.WriteLine($"It is  {converted23} land miles");
            }

            static void InchNauticalMile(double x24)
            {
                double converted24 = x24 / 72913.3858;
                Console.WriteLine($"It is  {converted24} nautical miles");
            }

            static void FootMeter(double x25)
            {
                double converted25 = x25 / 3.281;
                Console.WriteLine($"It is  {converted25} meters");
            }

            static void FootCentimeter(double x26)
            {
                double converted26 = x26 * 30.48;
                Console.WriteLine($"It is  {converted26} centimeters");
            }

            static void FootKilometer(double x27)
            {
                double converted27 = x27 / 3281;
                Console.WriteLine($"It is  {converted27} kilometers");
            }

            static void FootInch(double x28)
            {
                double converted28 = x28 * 12;
                Console.WriteLine($"It is  {converted28} inches");
            }

            static void FootLandMile(double x29)
            {
                double converted29 = x29 * 0.0001893939;
                Console.WriteLine($"It is  {converted29} land miles");
            }

            static void FootNauticalMile(double x30)
            {
                double converted30 = x30 / 6076;
                Console.WriteLine($"It is  {converted30} nautical miles");
            }

            static void LandMileMeter(double x31)
            {
                double converted31 = x31 * 1609.344;
                Console.WriteLine($"It is  {converted31} meters");
            }

            static void LandMileCentimeter(double x32)
            {
                double converted32 = x32 * 160934.4;
                Console.WriteLine($"It is  {converted32} centimeters");
            }

            static void LandMileKilometer(double x33)
            {
                double converted33 = x33 * 1.609344;
                Console.WriteLine($"It is  {converted33} kilometers");
            }

            static void LandMileInch(double x34)
            {
                double converted34 = x34 * 63360;
                Console.WriteLine($"It is  {converted34} inches");
            }

            static void LandMileFoot(double x35)
            {
                double converted35 = x35 * 5280;
                Console.WriteLine($"It is  {converted35} feet");
            }

            static void LandMileNauticalMile(double x36)
            {
                double converted36 = x36 / 1.151;
                Console.WriteLine($"It is  {converted36} nautical miles");
            }

            static void NauticalMileMeter(double x37)
            {
                double converted37 = x37 * 1852;
                Console.WriteLine($"It is  {converted37} meters");
            }

            static void NauticalMileCentimeter(double x38)
            {
                double converted38 = x38 * 185200;
                Console.WriteLine($"It is  {converted38} centimeters");
            }

            static void NauticalMileKilometer(double x39)
            {
                double converted39 = x39 * 1.852;
                Console.WriteLine($"It is  {converted39} kilometers");
            }

            static void NauticalMileInch(double x40)
            {
                double converted40 = x40 * 72910;
                Console.WriteLine($"It is  {converted40} inches");
            }

            static void NauticalMileFoot(double x41)
            {
                double converted41 = x41 * 6076;
                Console.WriteLine($"It is  {converted41} feet");
            }

            static void NauticalMileLandMile(double x42)
            {
                double converted42 = x42 * 1.1508;
                Console.WriteLine($"It is  {converted42} land miles");
            }
        }
    }
}

