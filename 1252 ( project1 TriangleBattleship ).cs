using System;

namespace triangle_battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            int user;
            while (true)
            {

                Console.WriteLine("                   - MENU -         ");
                Console.WriteLine("    PLEASE SELECT FROM THE OPTIONS BELOW:     ");
                Console.WriteLine("1 – Enter ship location \n2 – Ship info\n3 – Shoot at the ship\n4 – Show high score table\n5 – Exit");




                int x1, x2, x3, y1, y2, y3;

                Console.WriteLine("\nPlease enter the location of the ship ");

                //A NOKTASI İÇİN
                x1 = Convert.ToInt16(Console.ReadLine());
                while (x1 <= 0)
                {
                    Console.WriteLine("ERROR");
                    Console.Write("x1:");
                    x1 = Convert.ToInt16(Console.ReadLine());

                } while (x1 > 30)
                {
                    Console.WriteLine("ERROR");
                    Console.Write("x1:");
                    x1 = Convert.ToInt16(Console.ReadLine());

                }
                y1 = Convert.ToInt16(Console.ReadLine());
                while (y1 <= 0)
                {
                    Console.WriteLine("ERROR");
                    Console.Write("y1:");
                    y1 = Convert.ToInt16(Console.ReadLine());

                } while (y1 > 12)
                {
                    Console.WriteLine("ERROR");
                    Console.Write("y1:");
                    y1 = Convert.ToInt16(Console.ReadLine());

                }

                Console.Write("A:");
                Console.WriteLine((x1, y1));

                //B NOKTASI İÇİN
                x2 = Convert.ToInt16(Console.ReadLine());
                while (x2 <= 0)
                {
                    Console.WriteLine("ERROR");
                    Console.Write("x2:");
                    x2 = Convert.ToInt16(Console.ReadLine());

                } while (x2 > 30)
                {
                    Console.WriteLine("ERROR");
                    Console.Write("x2:");
                    x2 = Convert.ToInt16(Console.ReadLine());

                }
                y2 = Convert.ToInt16(Console.ReadLine());
                while (y2 <= 0)
                {
                    Console.WriteLine("ERROR");
                    Console.Write("y2:");
                    y2 = Convert.ToInt16(Console.ReadLine());

                } while (y2 > 12)
                {
                    Console.WriteLine("ERROR");
                    Console.Write("y2:");
                    y2 = Convert.ToInt16(Console.ReadLine());

                }

                Console.Write("B:");
                Console.WriteLine((x2, y2));


                //C NOKTASI İÇİN
                x3 = Convert.ToInt16(Console.ReadLine());
                while (x3 <= 0)
                {
                    Console.WriteLine("ERROR");
                    Console.Write("x3:");
                    x3 = Convert.ToInt16(Console.ReadLine());

                } while (x3 > 30)
                {
                    Console.WriteLine("ERROR");
                    Console.Write("x3:");
                    x3 = Convert.ToInt16(Console.ReadLine());

                }
                y3 = Convert.ToInt16(Console.ReadLine());
                while (y3 <= 0)
                {
                    Console.WriteLine("ERROR");
                    Console.Write("y3:");
                    y3 = Convert.ToInt16(Console.ReadLine());

                } while (y3 > 12)
                {
                    Console.WriteLine("ERROR");
                    Console.Write("y3:");
                    y3 = Convert.ToInt16(Console.ReadLine());

                }


                Console.Write("C:");
                Console.WriteLine((x3, y3));

                double sizea, sizeb, sizec;
                sizec = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
                sizea = Math.Sqrt(((x3 - x2) * (x3 - x2)) + ((y3 - y2) * (y3 - y2)));
                sizeb = Math.Sqrt(((x1 - x3) * (x1 - x3)) + ((y1 - y3) * (y1 - y3)));
                double p = (sizea + sizeb + sizec) / 2;
                double area = Math.Sqrt(p * (p - sizea) * (p - sizeb) * (p - sizec));



                while (area <= 0)
                {
                    Console.WriteLine("ERROR");
                    Console.WriteLine("The points you entered did not form triangles. Please try again.");
                    Console.WriteLine("Please enter the location of the ship");

                    //A NOKTASI İÇİN
                    x1 = Convert.ToInt16(Console.ReadLine());
                    while (x1 <= 0)
                    {
                        Console.WriteLine("ERROR");
                        Console.Write("x1:");
                        x1 = Convert.ToInt16(Console.ReadLine());

                    } while (x1 > 30)
                    {
                        Console.WriteLine("ERROR");
                        Console.Write("x1:");
                        x1 = Convert.ToInt16(Console.ReadLine());

                    }
                    y1 = Convert.ToInt16(Console.ReadLine());
                    while (y1 <= 0)
                    {
                        Console.WriteLine("ERROR");
                        Console.Write("y1:");
                        y1 = Convert.ToInt16(Console.ReadLine());

                    } while (y1 > 12)
                    {
                        Console.WriteLine("ERROR");
                        Console.Write("y1:");
                        y1 = Convert.ToInt16(Console.ReadLine());

                    }

                    Console.Write("A:");
                    Console.WriteLine((x1, y1));

                    //B NOKTASI İÇİN
                    x2 = Convert.ToInt16(Console.ReadLine());
                    while (x2 <= 0)
                    {
                        Console.WriteLine("ERROR");
                        Console.Write("x2:");
                        x2 = Convert.ToInt16(Console.ReadLine());

                    } while (x2 > 30)
                    {
                        Console.WriteLine("ERROR");
                        Console.Write("x2:");
                        x2 = Convert.ToInt16(Console.ReadLine());

                    }
                    y2 = Convert.ToInt16(Console.ReadLine());
                    while (y2 <= 0)
                    {
                        Console.WriteLine("ERROR");
                        Console.Write("y2:");
                        y2 = Convert.ToInt16(Console.ReadLine());

                    } while (y2 > 12)
                    {
                        Console.WriteLine("ERROR");
                        Console.Write("y2:");
                        y2 = Convert.ToInt16(Console.ReadLine());

                    }

                    Console.Write("B:");
                    Console.WriteLine((x2, y2));


                    //C NOKTASI İÇİN
                    x3 = Convert.ToInt16(Console.ReadLine());
                    while (x3 <= 0)
                    {
                        Console.WriteLine("ERROR");
                        Console.Write("x3:");
                        x3 = Convert.ToInt16(Console.ReadLine());

                    } while (x3 > 30)
                    {
                        Console.WriteLine("ERROR");
                        Console.Write("x3:");
                        x3 = Convert.ToInt16(Console.ReadLine());

                    }
                    y3 = Convert.ToInt16(Console.ReadLine());
                    while (y3 <= 0)
                    {
                        Console.WriteLine("ERROR");
                        Console.Write("y3:");
                        y3 = Convert.ToInt16(Console.ReadLine());

                    } while (y3 > 12)
                    {
                        Console.WriteLine("ERROR");
                        Console.Write("y3:");
                        y3 = Convert.ToInt16(Console.ReadLine());

                    }


                    Console.Write("C:");
                    Console.WriteLine((x3, y3));



                }


                Random random = new Random();
                int shootx, shooty;
                shootx = random.Next(1, 31);//1 dahil 31 dahil değil
                shooty = random.Next(1, 13);// 1 dahil 13 dahil değil

                Console.WriteLine("Enter1,2,3,4 or 5");
                user = Convert.ToInt16(Console.ReadLine());
                while (user > 5)
                {
                    Console.WriteLine("ERROR");
                    Console.WriteLine("The value you entered is incorrect. Please try again.");
                    user = Convert.ToInt16(Console.ReadLine());
                }
                while (user <= 0)
                {
                    Console.WriteLine("ERROR");
                    Console.WriteLine("The value you entered is incorrect. Please try again.");
                    user = Convert.ToInt16(Console.ReadLine());
                    while (user > 5)
                    {
                        Console.WriteLine("ERROR");
                        Console.WriteLine("The value you entered is incorrect. Please try again.");
                        user = Convert.ToInt16(Console.ReadLine());
                    }
                }

                //menüde konuma götürür.
                while (user == 1)
                {
                    Console.SetCursorPosition(0, 24);
                    Console.WriteLine("\nSHIP LOCATION");


                    Console.SetCursorPosition(0, 26);
                    Console.WriteLine("12|\n11|\n10|\n 9|\n 8|\n 7|\n 6|\n 5|\n 4|\n 3|\n 2|\n 1|\n  +------------------------------");
                    Console.WriteLine("   123456789012345678901234567890");
                    // bitmiş halinde y kısmını düzenle
                    Console.SetCursorPosition(x1 + 2, 38 - y1);
                    Console.Write("A");
                    Console.SetCursorPosition(x2 + 2, 38 - y2);
                    Console.WriteLine("B");
                    Console.SetCursorPosition(x3 + 2, 38 - y3);
                    Console.WriteLine("C");
                    Console.SetCursorPosition(2, 40);

                    Console.WriteLine("\nEnter1,2,3,4 or 5 from the menu options");

                    user = Convert.ToInt16(Console.ReadLine()); while (user > 5)
                    {
                        Console.WriteLine("ERROR");
                        Console.WriteLine("The value you entered is incorrect. Please try again.");
                        user = Convert.ToInt16(Console.ReadLine());
                    }
                    while (user <= 0)
                    {
                        Console.WriteLine("ERROR");
                        Console.WriteLine("The value you entered is incorrect. Please try again.");
                        user = Convert.ToInt16(Console.ReadLine());
                        while (user > 5)
                        {
                            Console.WriteLine("ERROR");
                            Console.WriteLine("The value you entered is incorrect. Please try again.");
                            user = Convert.ToInt16(Console.ReadLine());
                        }
                    }
                }

                //menüde gemi bilgilerine götüür.
                while (user == 2)
                {

                    Console.WriteLine("SHIP INFO");
                    //alan ve çevre hesplamalarında da kullandım.
                    sizec = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
                    sizea = Math.Sqrt(((x3 - x2) * (x3 - x2)) + ((y3 - y2) * (y3 - y2)));
                    sizeb = Math.Sqrt(((x1 - x3) * (x1 - x3)) + ((y1 - y3) * (y1 - y3)));

                    Console.Write("The size of the ship: ");
                    Console.Write("a=" + Math.Round(sizea, 2));
                    Console.Write(", b=" + Math.Round(sizeb, 2));
                    Console.WriteLine(", c=" + Math.Round(sizec, 2));

                    double perimeter;
                    perimeter = (sizea + sizeb + sizec);
                    Console.WriteLine("The perimeter of the ship: " + Math.Round(perimeter, 2));

                    //işlem koordinat düzlemi kodunun üstünde

                    sizec = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
                    sizea = Math.Sqrt(((x3 - x2) * (x3 - x2)) + ((y3 - y2) * (y3 - y2)));
                    sizeb = Math.Sqrt(((x1 - x3) * (x1 - x3)) + ((y1 - y3) * (y1 - y3)));

                    p = (sizea + sizeb + sizec) / 2;
                    area = Math.Sqrt(p * (p - sizea) * (p - sizeb) * (p - sizec));
                    Console.WriteLine("The area of the ship: " + Math.Round(area, 2));



                    double angleA, angleB, angleC;

                    //double p ve s yi kaldırdım
                    angleC = (Math.Asin(2 * area / (sizea * sizeb)) * ((180 / (Math.PI))));
                    angleA = (Math.Asin(2 * area / (sizeb * sizec)) * ((180 / (Math.PI))));
                    angleB = 180 - angleC - angleA;
                    Console.WriteLine("The angles of the ship: {0}, {1}, {2}", Math.Round(angleA, 2), Math.Round(angleB, 2), Math.Round(angleC, 2));



                    //medyan değerlerine götürür.
                    float medianxa, medianya, medianxb, medianyb, medianxc, medianyc;
                    medianxa = (x2 + x3) / 2;
                    medianya = (y2 + y3) / 2;
                    medianxb = (x1 + x3) / 2;
                    medianyb = (y1 + y3) / 2;
                    medianxc = (x1 + x2) / 2;
                    medianyc = (y1 + y2) / 2;

                    Console.Write("The median points:  ");
                    Console.Write((medianxa, medianya));
                    Console.Write((medianxb, medianyb));
                    Console.WriteLine((medianxc, medianyc));

                    //centroidi hesaplamak için // virgülden sonrası sorununu 
                    double centroidx, centroidy;
                    centroidx = (x1 + x2 + x3) / 3;
                    centroidy = (y1 + y2 + y3) / 3;
                    Console.Write("The centroid of the ship: ");
                    Console.WriteLine((Math.Round(centroidx, 2), Math.Round(centroidy, 2)));


                    double bisector, radian;
                    radian = (Math.PI / 180) * angleA;//açıyı radyana çevirdik
                    bisector = Math.Cos(radian / 2) * 2 * sizeb * sizec / (sizeb + sizec);
                    Math.Round(bisector, 2);
                    Console.WriteLine("The length of the bisector:  " + Math.Round(bisector, 2));

                    //u.r formüllü üçgen alanıyla iç teğet çemberin alanını hesaplamak için
                    double u, smallradius, i_circle_area;
                    u = perimeter / 2;
                    smallradius = area / u;
                    i_circle_area = Math.PI * Math.Pow(smallradius, 2);
                    Console.WriteLine("The area of the inscribed circle:" + Math.Round(i_circle_area, 2));

                    //a.b.c/4R=area formülünden dış teğet çemberin alanını hesaplamak için
                    double Radius, c_circle_area;
                    Radius = sizea * sizeb * sizec / (4 * area);
                    c_circle_area = Math.PI * Math.Pow(Radius, 2);
                    Console.WriteLine("The area of the circumscribed circle:" + Math.Round(c_circle_area, 2));

                    //üçgenin türünü belirlemek için
                    if ((sizea == sizeb) && (sizeb == sizec))
                        Console.Write("The type of the ship: Equilateral");
                    else if ((sizea == sizeb) | (sizea == sizec) | (sizeb == sizec))
                        Console.Write("The type of the ship: Isosceles");
                    else
                        Console.Write("The type of the ship: Scalene");
                    if ((angleA == 90) | (angleB == 90) | (angleC == 90))
                        Console.WriteLine(" (Right-angled)");
                    else if ((angleA > 90) | (angleB > 90) | (angleC > 90))
                        Console.WriteLine(" (Obtuse-angled)");
                    else
                        Console.WriteLine(" (Acute-angled)");


                    Console.WriteLine("\nEnter1,2,3,4 or 5 from the menu options");
                    user = Convert.ToInt16(Console.ReadLine()); while (user > 5)
                    {
                        Console.WriteLine("ERROR");
                        Console.WriteLine("The value you entered is incorrect. Please try again.");
                        user = Convert.ToInt16(Console.ReadLine());
                    }
                    while (user <= 0)
                    {
                        Console.WriteLine("ERROR");
                        Console.WriteLine("The value you entered is incorrect. Please try again.");
                        user = Convert.ToInt16(Console.ReadLine());
                        while (user > 5)
                        {
                            Console.WriteLine("ERROR");
                            Console.WriteLine("The value you entered is incorrect. Please try again.");
                            user = Convert.ToInt16(Console.ReadLine());
                        }
                    }
                }



                //menüde rastgele atışa götürür.
                while (user == 3)
                {

                    shootx = random.Next(1, 31);//1 dahil 31 dahil değil
                    shooty = random.Next(1, 13);// 1 dahil 13 dahil değil
                    Console.SetCursorPosition(0, 56);
                    Console.Write("\nShoot:");
                    Console.WriteLine((shootx, shooty));





                    Console.SetCursorPosition(0, 58);
                    Console.WriteLine("12|\n11|\n10|\n 9|\n 8|\n 7|\n 6|\n 5|\n 4|\n 3|\n 2|\n 1|\n  +------------------------------");
                    Console.WriteLine("   123456789012345678901234567890");
                    Console.SetCursorPosition(x1 + 2, 70 - y1);
                    Console.WriteLine("A");
                    Console.SetCursorPosition(x2 + 2, 70 - y2);
                    Console.WriteLine("B");
                    Console.SetCursorPosition(x3 + 2, 70 - y3);
                    Console.WriteLine("C");
                    Console.SetCursorPosition(shootx + 2, 70 - shooty);
                    Console.WriteLine("X");
                    Console.SetCursorPosition(0, 73);




                    double areashoot1, areashoot2, areashoot3;
                    areashoot1 = Math.Abs((x1 * y2) + (x2 * shooty) + (shootx * y1) - ((y1 * x2) + (y2 * shootx) + (shooty * x1))) / 2;
                    areashoot2 = Math.Abs((x1 * shooty) + (shootx * y3) + (x3 * y1) - ((y1 * shootx) + (shooty * x3) + (y3 * x1))) / 2;
                    areashoot3 = Math.Abs((shootx * y2) + (x2 * y3) + (x3 * shooty) - ((shooty * x2) + (y2 * x3) + (y3 * shootx))) / 2;
                    if ((areashoot1 + areashoot2 + areashoot3) > area)

                        Console.WriteLine("Your ship survived");

                    else
                        Console.WriteLine("your ship sank. Total score 0");

                    Console.WriteLine("\nEnter1,2,3,4 or 5 from the menu options");
                    user = Convert.ToInt16(Console.ReadLine()); while (user > 5)
                    {
                        Console.WriteLine("ERROR");
                        Console.WriteLine("The value you entered is incorrect. Please try again.");
                        user = Convert.ToInt16(Console.ReadLine());
                    }
                    while (user <= 0)
                    {
                        Console.WriteLine("ERROR");
                        Console.WriteLine("The value you entered is incorrect. Please try again.");
                        user = Convert.ToInt16(Console.ReadLine());
                        while (user > 5)
                        {
                            Console.WriteLine("ERROR");
                            Console.WriteLine("The value you entered is incorrect. Please try again.");
                            user = Convert.ToInt16(Console.ReadLine());
                        }
                    }
                }


                //menüde skor tablosuna götürür.
                while (user == 4)
                {

                    string name;
                    double areashoot1, areashoot2, areashoot3;
                    areashoot1 = Math.Abs((x1 * y2) + (x2 * shooty) + (shootx * y1) - ((y1 * x2) + (y2 * shootx) + (shooty * x1))) / 2;
                    areashoot2 = Math.Abs((x1 * shooty) + (shootx * y3) + (x3 * y1) - ((y1 * shootx) + (shooty * x3) + (y3 * x1))) / 2;
                    areashoot3 = Math.Abs((shootx * y2) + (x2 * y3) + (x3 * shooty) - ((shooty * x2) + (y2 * x3) + (y3 * shootx))) / 2;
                    if ((areashoot1 + areashoot2 + areashoot3) > area)
                    {

                        Console.WriteLine("Total score:" + Math.Round(area, 2));



                        double nazan, ali, sibel;
                        nazan = 60;
                        ali = 30;
                        sibel = 10;


                        Console.Write("Please enter your name:");
                        name = Console.ReadLine();
                        Console.WriteLine(name);


                        if (area > nazan)

                        {
                            Console.WriteLine("HIGH SCORE TABLE");
                            Console.WriteLine("Name                   Score ");
                            Console.WriteLine(name + "             " + area);
                            Console.WriteLine("Nazan Kaya             " + nazan);
                            Console.WriteLine("Ali Kurt               " + ali);

                        }
                        else if ((area <= nazan) && (area > ali))
                        {
                            Console.WriteLine("HIGH SCORE TABLE");
                            Console.WriteLine("Name                   Score ");
                            Console.WriteLine("Nazan Kaya             " + nazan);
                            Console.WriteLine(name + "             " + area);
                            Console.WriteLine("Ali Kurt               " + ali);
                        }
                        else if ((area <= ali) && (area > sibel))
                        {
                            Console.WriteLine("HIGH SCORE TABLE");
                            Console.WriteLine("Name                   Score ");
                            Console.WriteLine("Nazan Kaya             " + nazan);
                            Console.WriteLine("Ali Kurt               " + ali);
                            Console.WriteLine(name + "             " + area);
                        }
                        else
                        {
                            Console.WriteLine("HIGH SCORE TABLE");
                            Console.WriteLine("Name                   Score ");
                            Console.WriteLine("Nazan Kaya             " + nazan);
                            Console.WriteLine("Ali Kurt               " + ali);
                            Console.WriteLine("Sibel Arslan           " + sibel);
                        }
                    }
                    else
                    {
                        Console.WriteLine("your ship sank. Total score 0");
                        double nazan, ali, sibel;
                        nazan = 60;
                        ali = 30;
                        sibel = 10;

                        Console.WriteLine("HIGH SCORE TABLE");
                        Console.WriteLine("Name                Score ");
                        Console.WriteLine("Nazan Kaya	       " + nazan);
                        Console.WriteLine("Ali Kurt            " + ali);
                        Console.WriteLine("Sibel Arslan	       " + sibel);
                    }

                    Console.WriteLine("\nEnter1,2,3,4 or 5 from the menu options");
                    user = Convert.ToInt16(Console.ReadLine());
                    while (user > 5)
                    {
                        Console.WriteLine("ERROR");
                        Console.WriteLine("The value you entered is incorrect. Please try again.");
                        user = Convert.ToInt16(Console.ReadLine());
                    }
                    while (user <= 0)
                    {
                        Console.WriteLine("ERROR");
                        Console.WriteLine("The value you entered is incorrect. Please try again.");
                        user = Convert.ToInt16(Console.ReadLine());
                        while (user > 5)
                        {
                            Console.WriteLine("ERROR");
                            Console.WriteLine("The value you entered is incorrect. Please try again.");
                            user = Convert.ToInt16(Console.ReadLine());
                        }
                    }
                }

                //menüde çıkışa götürür.
                Console.Clear();
                Console.WriteLine("Press  E to exit. You can press any key to play again");
                if (((Console.ReadLine() == "E"))) break;
            }
        }
    }
}
