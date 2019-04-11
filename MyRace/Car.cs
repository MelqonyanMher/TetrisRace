using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using static System.Console;
using static System.Math;

namespace MyRace
{
    public class Car
    {
        static int miavor = 0;
        static int rekord = 0;

        static int Y1 = 0;
        static int Y2 = 0;
        static int Y3 = 0;
        Point c1 = null;
        Point c3 = null;
        Point c2 = null;


        string[,] carer1 = null;
        string[,] carer2 = null;
        string[,] carer3 = null;

        private static int time = 130;
        private int x;
        private int y;




        Point[] myCar = new Point[7];
        private void MyCar()
        {

            Point p1 = new Point(Console.WindowWidth / 2 - 1, Console.WindowHeight - 1);
            Point p2 = new Point(Console.WindowWidth / 2 + 1, Console.WindowHeight - 1);
            Point p3 = new Point(Console.WindowWidth / 2, Console.WindowHeight - 2);
            Point p4 = new Point(Console.WindowWidth / 2 - 1, Console.WindowHeight - 3);
            Point p5 = new Point(Console.WindowWidth / 2, Console.WindowHeight - 3);
            Point p6 = new Point(Console.WindowWidth / 2 + 1, Console.WindowHeight - 3);
            Point p7 = new Point(Console.WindowWidth / 2, Console.WindowHeight - 4);
            myCar[0] = p1;
            myCar[1] = p2;
            myCar[2] = p3;
            myCar[3] = p4;
            myCar[4] = p5;
            myCar[5] = p6;
            myCar[6] = p7;
            Console.ForegroundColor = ConsoleColor.Blue;
            Drow(myCar);
        }
        private void MyCar(int koxm)
        {
            if (koxm < 0 && myCar[0].X > WindowWidth / 2 - 2)
            {
                Console.ForegroundColor = BackgroundColor;
                Drow(myCar);
                myCar[0].X -= 4;
                myCar[1].X -= 4;
                myCar[2].X -= 4;
                myCar[3].X -= 4;
                myCar[4].X -= 4;
                myCar[5].X -= 4;
                myCar[6].X -= 4;
                Console.ForegroundColor = ConsoleColor.Blue;
                Drow(myCar);
            }
            else if (koxm > 0 && myCar[0].X < WindowWidth / 2 + 3)
            {
                Console.ForegroundColor = BackgroundColor;
                Drow(myCar);
                myCar[0].X += 4;
                myCar[1].X += 4;
                myCar[2].X += 4;
                myCar[3].X += 4;
                myCar[4].X += 4;
                myCar[5].X += 4;
                myCar[6].X += 4;
                Console.ForegroundColor = ConsoleColor.Blue;
                Drow(myCar);

            }
        }
        public Char Icon { get; set; }
        public void Play()
        {
            Console.Clear();
            MyCar();
            Move();
        }
        private string[,] Carer()
        {

            string[,] carer1 = new string[3, 4];

            carer1[0, 0] = " ";
            carer1[1, 0] = "#";
            carer1[2, 0] = " ";
            carer1[0, 1] = "#";
            carer1[1, 1] = "#";
            carer1[2, 1] = "#";
            carer1[0, 2] = " ";
            carer1[1, 2] = "#";
            carer1[2, 2] = " ";
            carer1[0, 3] = "#";
            carer1[1, 3] = " ";
            carer1[2, 3] = "#";
            return carer1;


        }





        private void Move()
        {
            Random rd = new Random();
            string[,] yard = new string[1, Console.WindowHeight];
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                if (i % 2 == 0)
                {
                    yard[0, i] = "#";


                }
            }
            string[,] yard2 = new string[1, Console.WindowHeight];
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                if (i % 2 == 0)
                {
                    yard2[0, i] = "#";


                }
                else
                {
                    yard2[0, i] = " ";

                }
            }
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                if (i % 2 == 0)
                {

                    yard[0, i] = "#";

                }
                else
                {
                    yard[0, i] = " ";

                }
            }

            Console.ForegroundColor = ConsoleColor.Red;




            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                for (int i = Console.WindowHeight - 1; i > 0; i--)
                {

                    yard[0, i] = yard[0, i - 1];
                    yard2[0, i] = yard2[0, i - 1];


                }
                if (yard[0, 0].Equals("#"))
                {
                    yard[0, 0] = " ";
                    yard2[0, 0] = " ";
                }
                else
                {
                    yard[0, 0] = "#";
                    yard2[0, 0] = "#";
                }
                for (int i = 0; i < Console.WindowHeight; i++)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 9, i);
                    Console.Write(yard[0, i]);

                }
                for (int i = 0; i < Console.WindowHeight; i++)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2 + 8, i);
                    Console.Write(yard2[0, i]);

                }
                if (Console.KeyAvailable)
                {
                    ConsoleKey key = Console.ReadKey().Key;
                    if (key == ConsoleKey.LeftArrow)
                    {
                        MyCar(-1);
                    }
                    if (key == ConsoleKey.RightArrow)
                    {
                        MyCar(1);
                    }
                }
                if (carer1 == null || carer2 == null || carer3 == null)
                {
                    int patahakan = rd.Next(15);
                    if (patahakan == 8 && carer1 == null)
                    {
                        carer1 = Carer();
                    }
                    else if (patahakan == 14 && carer2 == null)
                    {
                        carer2 = Carer();
                    }
                    else if (patahakan == 0 && carer3 == null)
                    {
                        carer3 = Carer();
                    }
                }
                if (carer1 != null)
                {

                    for (int i = 0; i < carer1.GetLength(1); i++)
                    {
                        if (Y1 > 3)
                        {

                            Console.SetCursorPosition(WindowWidth / 2 - 4, Y1 + i - 4);
                            ForegroundColor = BackgroundColor;
                            Write(" ");

                        }
                        Console.SetCursorPosition(WindowWidth / 2 - 5, Y1 + i);

                        for (int j = 0; j < carer1.GetLength(0); j++)
                        {
                            ForegroundColor = ConsoleColor.Yellow;
                            Write(carer1[j, i]);
                        }

                    }
                    if (Y1 > WindowHeight - 8)
                    {
                        c1 = new Point(WindowWidth / 2 - 5, WindowHeight - 3);
                        foreach (Point p in myCar)
                        {
                            if (p.Equals(c1))
                            {
                                SetCursorPosition(WindowWidth - 10, 0);
                                ForegroundColor = ConsoleColor.White;
                                Write("Ачок :   ");
                                miavor = 0;
                                carer1 = null;
                                carer2 = null;
                                carer3 = null;
                                Y1 = 0;
                                Y2 = 0;
                                Y3 = 0;
                                time = 130;

                                Console.Clear();
                                SetCursorPosition(WindowWidth / 2 - 7, WindowHeight / 2);
                                Write("Your record is :" + rekord);
                                SetCursorPosition(WindowWidth / 2 - 7, WindowHeight / 2 + 1);
                                Write("If you want to play agein press Enter!");
                                return;
                            }
                        }
                    }
                    if (Y1 == WindowHeight - 4)
                    {
                        for (int i = 0; i < carer1.GetLength(1); i++)
                        {

                            Console.SetCursorPosition(WindowWidth / 2 - 5, Y1 + i);

                            for (int j = 0; j < carer1.GetLength(0); j++)
                            {


                                Write(" ");
                            }

                        }
                        Y1 = 0;
                        carer1 = null;
                        if (time > 15)
                        {
                            time -= 3;
                        }
                    }
                    else
                    {
                        Y1++;
                    }
                }
                if (carer2 != null)
                {

                    for (int i = 0; i < carer2.GetLength(1); i++)
                    {
                        if (Y2 > 3)
                        {

                            Console.SetCursorPosition(WindowWidth / 2, Y2 + i - 4);
                            ForegroundColor = BackgroundColor;
                            Write(" ");

                        }
                        Console.SetCursorPosition(WindowWidth / 2 - 1, Y2 + i);

                        for (int j = 0; j < carer2.GetLength(0); j++)
                        {
                            ForegroundColor = ConsoleColor.Yellow;

                            Write(carer2[j, i]);
                        }

                    }
                    if (Y2 > WindowHeight - 8)
                    {
                        c2 = new Point(WindowWidth / 2 - 1, WindowHeight - 3);
                        foreach (Point p in myCar)
                        {
                            if (p.Equals(c2))
                            {
                                SetCursorPosition(WindowWidth - 10, 0);
                                ForegroundColor = ConsoleColor.White;
                                Write("Ачок :   ");
                                miavor = 0;
                                carer1 = null;
                                carer2 = null;
                                carer3 = null;
                                Y1 = 0;
                                Y2 = 0;
                                Y3 = 0;
                                time = 130;

                                Console.Clear();
                                SetCursorPosition(WindowWidth / 2 - 7, WindowHeight / 2);
                                Write("Your record is :" + rekord);
                                SetCursorPosition(WindowWidth / 2 - 7, WindowHeight / 2 + 1);
                                Write("If you want to play agein press Enter!");
                                return;
                            }
                        }
                    }
                    if (Y2 == WindowHeight - 4)
                    {



                        for (int i = 0; i < carer2.GetLength(1); i++)
                        {

                            Console.SetCursorPosition(WindowWidth / 2 - 1, Y2 + i);

                            for (int j = 0; j < carer2.GetLength(0); j++)
                            {


                                Write(" ");
                            }

                        }
                        Y2 = 0;
                        carer2 = null;
                        if (time > 15)
                        {
                            time -= 3;
                        }
                    }
                    else
                    {
                        Y2++;
                    }
                }
                if (carer3 != null)
                {



                    for (int i = 0; i < carer3.GetLength(1); i++)
                    {
                        if (Y3 > 3)
                        {

                            Console.SetCursorPosition(WindowWidth / 2 + 4, Y3 + i - 4);
                            ForegroundColor = BackgroundColor;
                            Write(" ");

                        }
                        Console.SetCursorPosition(WindowWidth / 2 + 3, Y3 + i);

                        for (int j = 0; j < carer3.GetLength(0); j++)
                        {
                            ForegroundColor = ConsoleColor.Yellow;

                            Write(carer3[j, i]);
                        }

                    }
                    if (Y3 > WindowHeight - 8)
                    {
                        c3 = new Point(WindowWidth / 2 + 3, WindowHeight - 3);
                        foreach (Point p in myCar)
                        {
                            if (p.Equals(c3))
                            {
                                SetCursorPosition(WindowWidth - 10, 0);
                                ForegroundColor = ConsoleColor.White;
                                Write("Ачок :   ");
                                miavor = 0;
                                carer1 = null;
                                carer2 = null;
                                carer3 = null;
                                Y1 = 0;
                                Y2 = 0;
                                Y3 = 0;
                                time = 130;
                                Console.Clear();
                                SetCursorPosition(WindowWidth / 2 - 7, WindowHeight / 2);
                                Write("Your record is :" + rekord);
                                SetCursorPosition(WindowWidth / 2 - 7, WindowHeight / 2 + 1);
                                Write("If you want to play agein press Enter!");
                                return;
                            }
                        }
                    }
                    if (Y3 == WindowHeight - 4)
                    {
                        for (int i = 0; i < carer3.GetLength(1); i++)
                        {

                            Console.SetCursorPosition(WindowWidth / 2 + 3, Y3 + i);

                            for (int j = 0; j < carer3.GetLength(0); j++)
                            {


                                Write(" ");
                            }

                        }
                        Y3 = 0;
                        carer3 = null;
                        if (time > 15)
                        {
                            time -= 3;
                        }
                    }
                    else
                    {
                        Y3++;
                    }
                }
                SetCursorPosition(WindowWidth - 10, 0);
                ForegroundColor = ConsoleColor.White;
                Write("Ачок :" + miavor);
                if (miavor >= rekord)
                {
                    rekord = miavor;
                }
                SetCursorPosition(WindowWidth - 10, 1);
                Write("Рекорд:" + rekord);
                miavor++;
                //SetCursorPosition(WindowWidth - 10, 2);
                //Write("Time:" + time);

                Thread.Sleep(time);
            }


        }
        public int X
        {
            get;
            set
            ;
        }
        public int Y
        {
            get;
            set
            ;
        }
        public Car(Char ic = 'O')
        {

            Icon = ic;


        }
        private void Drow(Point[] carByPoint)
        {

            if (carByPoint[0].Y > 0 && carByPoint[0].Y < Console.WindowHeight)
            {
                Console.SetCursorPosition(carByPoint[0].X, carByPoint[0].Y);
                Console.Write($"{Icon}");
                Console.SetCursorPosition(carByPoint[1].X, carByPoint[1].Y);
                Console.Write($"{Icon}");
            }
            if (carByPoint[0].Y > 1 && carByPoint[0].Y < Console.WindowHeight + 1)
            {
                Console.SetCursorPosition(carByPoint[2].X, carByPoint[2].Y);
                Console.Write($"{Icon}");
            }
            if (carByPoint[0].Y > 2 && carByPoint[0].Y < Console.WindowHeight + 2)
            {
                Console.SetCursorPosition(carByPoint[3].X, carByPoint[3].Y);
                Console.Write($"{Icon}");
                Console.SetCursorPosition(carByPoint[4].X, carByPoint[4].Y);
                Console.Write($"{Icon}");
                Console.SetCursorPosition(carByPoint[5].X, carByPoint[5].Y);
                Console.Write($"{Icon}");
            }
            if (carByPoint[0].Y > 3 && carByPoint[0].Y < Console.WindowHeight + 3)
            {
                Console.SetCursorPosition(carByPoint[6].X, carByPoint[6].Y);
                Console.Write($"{Icon}");
            }


        }
    }
}
