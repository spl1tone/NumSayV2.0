using System;

namespace NumSayV2._0
{
    internal class Program
    {
        static void Solve (long a)
        {
            LiblaryRU liblaryRU = new LiblaryRU();
            if (a == 0l) {
                Console.Write(liblaryRU.n1[0]);
            }

            #region 100 000 000 - 900 000 000
            if (a % 1000000000 < 1000000000l && a % 1000000000 >= 100000000l) {
                switch (Math.Abs((a % 1000000000) / 100000000l)) {
                    case 1l:
                        Console.Write(liblaryRU.n4[1]);
                        break;
                    case 2l:
                        Console.Write(liblaryRU.n4[2]);
                        break;
                    case 3l:
                        Console.Write(liblaryRU.n4[3]);
                        break;
                    case 4l:
                        Console.Write(liblaryRU.n4[4]);
                        break;
                    case 5l:
                        Console.Write(liblaryRU.n4[5]);
                        break;
                    case 6l:
                        Console.Write(liblaryRU.n4[6]);
                        break;
                    case 7l:
                        Console.Write(liblaryRU.n4[7]);
                        break;
                    case 8l:
                        Console.Write(liblaryRU.n4[8]);
                        break;
                    case 9l:
                        Console.Write(liblaryRU.n4[9]);
                        break;
                }
                if ((a % 100000000) / 10000000 == 0l && (a % 10000000) / 1000000 == 0l) {
                    Console.Write(liblaryRU.n6[3]);
                }
            }
            #endregion

            #region 20 000 000 - 90 000 000
            if (a % 100000000 < 100000000l && a % 100000000 >= 20000000l) {
                switch (Math.Abs((a % 100000000) / 10000000l)) {
                    case 2l:
                        Console.Write(liblaryRU.n3[2]);
                        break;
                    case 3l:
                        Console.Write(liblaryRU.n3[3]);
                        break;
                    case 4l:
                        Console.Write(liblaryRU.n3[4]);
                        break;
                    case 5l:
                        Console.Write(liblaryRU.n3[5]);
                        break;
                    case 6l:
                        Console.Write(liblaryRU.n3[6]);
                        break;
                    case 7l:
                        Console.Write(liblaryRU.n3[7]);
                        break;
                    case 8l:
                        Console.Write(liblaryRU.n3[8]);
                        break;
                    case 9l:
                        Console.Write(liblaryRU.n3[9]);
                        break;
                }
                if ((a % 10000000) / 1000000l == 0l) {
                    Console.Write(liblaryRU.n6[3]);
                }
            }

            #endregion

            #region 10 000 000 - 19 000 000
            if (a % 100000000 < 20000000l && a % 100000000 >= 10000000l) {
                switch (Math.Abs((a % 100000000) / 1000000l)) {
                    case 10l:
                        Console.Write(liblaryRU.n2[0] + liblaryRU.n6[3]);
                        break;
                    case 11l:
                        Console.Write(liblaryRU.n2[1] + liblaryRU.n6[3]);
                        break;
                    case 12l:
                        Console.Write(liblaryRU.n2[2] + liblaryRU.n6[3]);
                        break;
                    case 13l:
                        Console.Write(liblaryRU.n2[3] + liblaryRU.n6[3]);
                        break;
                    case 14l:
                        Console.Write(liblaryRU.n2[4] + liblaryRU.n6[3]);
                        break;
                    case 15l:
                        Console.Write(liblaryRU.n2[5] + liblaryRU.n6[3]);
                        break;
                    case 16l:
                        Console.Write(liblaryRU.n2[6] + liblaryRU.n6[3]);
                        break;
                    case 17l:
                        Console.Write(liblaryRU.n2[7] + liblaryRU.n6[3]);
                        break;
                    case 18l:
                        Console.Write(liblaryRU.n2[8] + liblaryRU.n6[3]);
                        break;
                    case 19l:
                        Console.Write(liblaryRU.n2[9] + liblaryRU.n6[3]);
                        break;
                }
            }
            #endregion

            #region 1 000 000 - 9 000 000
            else {
                switch (Math.Abs((a % 10000000) / 1000000l)) {
                    case 1l:
                        Console.Write(liblaryRU.n1[1] + liblaryRU.n6[1]);
                        break;
                    case 2l:
                        Console.Write(liblaryRU.n1[2] + liblaryRU.n6[2]);
                        break;
                    case 3l:
                        Console.Write(liblaryRU.n1[3] + liblaryRU.n6[2]);
                        break;
                    case 4l:
                        Console.Write(liblaryRU.n1[4] + liblaryRU.n6[2]);
                        break;
                    case 5l:
                        Console.Write(liblaryRU.n1[5] + liblaryRU.n6[3]);
                        break;
                    case 6l:
                        Console.Write(liblaryRU.n1[6] + liblaryRU.n6[3]);
                        break;
                    case 7l:
                        Console.Write(liblaryRU.n1[7] + liblaryRU.n6[3]);
                        break;
                    case 8l:
                        Console.Write(liblaryRU.n1[8] + liblaryRU.n6[3]);
                        break;
                    case 9l:
                        Console.Write(liblaryRU.n1[9] + liblaryRU.n6[3]);
                        break;
                }
            }

            #endregion

            #region 100 000 - 900 000
            if (a % 1000000 < 1000000l && a % 1000000 >= 100000l) {
                switch (Math.Abs((a % 1000000) / 100000l)) {
                    case 1l:
                        Console.Write(liblaryRU.n4[1]);
                        break;
                    case 2l:
                        Console.Write(liblaryRU.n4[2]);
                        break;
                    case 3l:
                        Console.Write(liblaryRU.n4[3]);
                        break;
                    case 4l:
                        Console.Write(liblaryRU.n4[4]);
                        break;
                    case 5l:
                        Console.Write(liblaryRU.n4[5]);
                        break;
                    case 6l:
                        Console.Write(liblaryRU.n4[6]);
                        break;
                    case 7l:
                        Console.Write(liblaryRU.n4[7]);
                        break;
                    case 8l:
                        Console.Write(liblaryRU.n4[8]);
                        break;
                    case 9l:
                        Console.Write(liblaryRU.n4[9]);
                        break;
                }
                if ((a % 100000) / 10000l == 0l && (a % 10000) / 1000l == 0l) {
                    Console.Write(liblaryRU.n5[5]);
                }
            }

            #endregion

            #region 20 000 - 90 000
            if (a % 100000 < 100000l && a % 100000 >= 20000l) {
                switch (Math.Abs((a % 100000) / 10000l)) {
                    case 2l:
                        Console.Write(liblaryRU.n3[2]);
                        break;
                    case 3l:
                        Console.Write(liblaryRU.n3[3]);
                        break;
                    case 4l:
                        Console.Write(liblaryRU.n3[4]);
                        break;
                    case 5l:
                        Console.Write(liblaryRU.n3[5]);
                        break;
                    case 6l:
                        Console.Write(liblaryRU.n3[6]);
                        break;
                    case 7l:
                        Console.Write(liblaryRU.n3[7]);
                        break;
                    case 8l:
                        Console.Write(liblaryRU.n3[8]);
                        break;
                    case 9l:
                        Console.Write(liblaryRU.n3[9]);
                        break;
                }
                if ((a % 10000) / 1000l == 0l) {
                    Console.Write(liblaryRU.n5[5]);
                }
            }

            #endregion

            #region 10 000 - 19 000
            if (a % 100000 < 20000l && a % 100000 >= 10000l) {
                switch (Math.Abs((a % 100000) / 1000l)) {
                    case 10l:
                        Console.Write(liblaryRU.n2[0] + liblaryRU.n5[5]);
                        break;
                    case 11l:
                        Console.Write(liblaryRU.n2[1] + liblaryRU.n5[5]);
                        break;
                    case 12l:
                        Console.Write(liblaryRU.n2[2] + liblaryRU.n5[5]);
                        break;
                    case 13l:
                        Console.Write(liblaryRU.n2[3] + liblaryRU.n5[5]);
                        break;
                    case 14l:
                        Console.Write(liblaryRU.n2[4] + liblaryRU.n5[5]);
                        break;
                    case 15l:
                        Console.Write(liblaryRU.n2[5] + liblaryRU.n5[5]);
                        break;
                    case 16l:
                        Console.Write(liblaryRU.n2[6] + liblaryRU.n5[5]);
                        break;
                    case 17l:
                        Console.Write(liblaryRU.n2[7] + liblaryRU.n5[5]);
                        break;
                    case 18l:
                        Console.Write(liblaryRU.n2[8] + liblaryRU.n5[5]);
                        break;
                    case 19l:
                        Console.Write(liblaryRU.n2[9] + liblaryRU.n5[5]);
                        break;
                }
            }
            #endregion

            #region 1 000 - 9 000
            else {
                switch (Math.Abs((a % 10000) / 1000l)) {
                    case 1l:
                        Console.Write(liblaryRU.n5[1] + liblaryRU.n5[3]);
                        break;
                    case 2l:
                        Console.Write(liblaryRU.n5[2] + liblaryRU.n5[4]);
                        break;
                    case 3l:
                        Console.Write(liblaryRU.n1[3] + liblaryRU.n5[4]);
                        break;
                    case 4l:
                        Console.Write(liblaryRU.n1[4] + liblaryRU.n5[4]);
                        break;
                    case 5l:
                        Console.Write(liblaryRU.n1[5] + liblaryRU.n5[5]);
                        break;
                    case 6l:
                        Console.Write(liblaryRU.n1[6] + liblaryRU.n5[5]);
                        break;
                    case 7l:
                        Console.Write(liblaryRU.n1[7] + liblaryRU.n5[5]);
                        break;
                    case 8l:
                        Console.Write(liblaryRU.n1[8] + liblaryRU.n5[5]);
                        break;
                    case 9l:
                        Console.Write(liblaryRU.n1[9] + liblaryRU.n5[5]);
                        break;
                }
            }
            #endregion

            #region 100 - 900
            switch (Math.Abs((a % 1000) / 100l)) {
                case 1l:
                    Console.Write(liblaryRU.n4[1]);
                    break;
                case 2l:
                    Console.Write(liblaryRU.n4[2]);
                    break;
                case 3l:
                    Console.Write(liblaryRU.n4[3]);
                    break;
                case 4l:
                    Console.Write(liblaryRU.n4[4]);
                    break;
                case 5l:
                    Console.Write(liblaryRU.n4[5]);
                    break;
                case 6l:
                    Console.Write(liblaryRU.n4[6]);
                    break;
                case 7l:
                    Console.Write(liblaryRU.n4[7]);
                    break;
                case 8l:
                    Console.Write(liblaryRU.n4[8]);
                    break;
                case 9l:
                    Console.Write(liblaryRU.n4[9]);
                    break;
            }
            #endregion

            #region 20 - 90
            switch (Math.Abs((a % 100) / 10l)) {
                case 2l:
                    Console.Write(liblaryRU.n3[2]);
                    break;
                case 3l:
                    Console.Write(liblaryRU.n3[3]);
                    break;
                case 4l:
                    Console.Write(liblaryRU.n3[4]);
                    break;
                case 5l:
                    Console.Write(liblaryRU.n3[5]);
                    break;
                case 6l:
                    Console.Write(liblaryRU.n3[6]);
                    break;
                case 7l:
                    Console.Write(liblaryRU.n3[7]);
                    break;
                case 8l:
                    Console.Write(liblaryRU.n3[8]);
                    break;
                case 9l:
                    Console.Write(liblaryRU.n3[9]);
                    break;
            }
            #endregion

            #region 10 - 19
            if (a % 100 < 20l && a % 100 >= 10l) {
                switch (a % 100) {
                    case 10l:
                        Console.Write(liblaryRU.n2[0]);
                        break;
                    case 11l:
                        Console.Write(liblaryRU.n2[1]);
                        break;
                    case 12l:
                        Console.Write(liblaryRU.n2[2]);
                        break;
                    case 13l:
                        Console.Write(liblaryRU.n2[3]);
                        break;
                    case 14l:
                        Console.Write(liblaryRU.n2[4]);
                        break;
                    case 15l:
                        Console.Write(liblaryRU.n2[5]);
                        break;
                    case 16l:
                        Console.Write(liblaryRU.n2[6]);
                        break;
                    case 17l:
                        Console.Write(liblaryRU.n2[7]);
                        break;
                    case 18l:
                        Console.Write(liblaryRU.n2[8]);
                        break;
                    case 19l:
                        Console.Write(liblaryRU.n2[9]);
                        break;
                }
            }
            #endregion

            #region 1 - 9
            else {
                switch (a % 10) {
                    case 1l:
                        Console.Write(liblaryRU.n1[1]);
                        break;
                    case 2l:
                        Console.Write(liblaryRU.n1[2]);
                        break;
                    case 3l:
                        Console.Write(liblaryRU.n1[3]);
                        break;
                    case 4l:
                        Console.Write(liblaryRU.n1[4]);
                        break;
                    case 5l:
                        Console.Write(liblaryRU.n1[5]);
                        break;
                    case 6l:
                        Console.Write(liblaryRU.n1[6]);
                        break;
                    case 7l:
                        Console.Write(liblaryRU.n1[7]);
                        break;
                    case 8l:
                        Console.Write(liblaryRU.n1[8]);
                        break;
                    case 9l:
                        Console.Write(liblaryRU.n1[9]);
                        break;
                }
            }
            #endregion


            Console.WriteLine();
        }


        static void Main (string[] args)
        {
            LiblaryRU liblaryRU = new LiblaryRU();

            long num;
            const long maxNum = 999999999l;

            Console.WriteLine("NumSayV2.0");
            Console.WriteLine("Max Num> +-999.999.999");
            Console.WriteLine("Example>  1024");
            Console.WriteLine("Example> -2048");
            Console.WriteLine();
            while (true) {

                Console.Write("Enter Num> ");
                num = Convert.ToInt64(Console.ReadLine());

                if (num > maxNum) {
                    Console.WriteLine("Num > 999.999.999");
                    break;
                }
                if (num < 0l) {
                    num = num * -1l;
                    Console.Write(liblaryRU.minus);
                    if (num > maxNum) {
                        Console.WriteLine("Num < -999.999.999");
                        break;
                    }
                    Solve(num);
                }
                else {
                    Solve(num);
                }


            }

            Console.ReadLine();
        }
    }
}
