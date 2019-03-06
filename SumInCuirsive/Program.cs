using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumInCuirsive
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = 567123456999, order, div = 0, mod = 1000;
            Console.WriteLine((order = (int)Math.Ceiling(Math.Log10(N))));
            div = (long)Math.Pow(10, order);

            for (int i = 0; i <= order / 3; i++)
            {
                Console.WriteLine(N / div % mod + ":   " + NumToCursive((N / div % mod)));
                div /= 1000;
            }
        }

        private static string NumToCursive(long N)
        {
            long ones = N % 10;
            long tens = N / 10 % 10;
            long hunderds = N / 100;


            string cursive = "";
            if (N == 0)
                cursive = "zero";
            else
            {
                switch (hunderds)
                {
                    case 1:
                        cursive += " one hundred";
                        break;
                    case 2:
                        cursive += " two hundreds";
                        break;
                    case 3:
                        cursive += " three hundreds";
                        break;
                    case 4:
                        cursive += " four hundreds";
                        break;
                    case 5:
                        cursive += " five hundreds";
                        break;
                    case 6:
                        cursive += " six hundreds";
                        break;
                    case 7:
                        cursive += " seven hundreds";
                        break;
                    case 8:
                        cursive += " eight hundreds";
                        break;
                    case 9:
                        cursive += " nine hundreds";
                        break;
                    default:
                        cursive += "";
                        break;
                }

                switch (tens)
                {
                    case 1:
                        switch (ones)
                        {
                            case 1:
                                cursive += " eleven ";
                                break;
                            case 2:
                                cursive += " twelve ";
                                break;
                            case 3:
                                cursive += " thirteen ";
                                break;
                            case 4:
                                cursive += " fourteen ";
                                break;
                            case 5:
                                cursive += " fifteen ";
                                break;
                            case 6:
                                cursive += " sixteen ";
                                break;
                            case 7:
                                cursive += " seventeen ";
                                break;
                            case 8:
                                cursive += " eighteen ";
                                break;
                            case 9:
                                cursive += " nineteen ";
                                break;
                            case 0:
                                cursive += " ten ";
                                break;
                            default:
                                cursive += "";
                                break;
                        }
                        break;
                    case 2:
                        cursive += " twenty ";
                        break;
                    case 3:
                        cursive += " thirty ";
                        break;
                    case 4:
                        cursive += " fourty ";
                        break;
                    case 5:
                        cursive += " fifty ";
                        break;
                    case 6:
                        cursive += " sixty ";
                        break;
                    case 7:
                        cursive += " seventy ";
                        break;
                    case 8:
                        cursive += " eighty ";
                        break;
                    case 9:
                        cursive += " ninety ";
                        break;
                    default:
                        cursive += "";
                        break;
                }

                // ones
                if (tens != 1)
                {
                    switch (ones)
                    {
                        case 1:
                            cursive += " one ";
                            break;
                        case 2:
                            cursive += " two ";
                            break;
                        case 3:
                            cursive += " three ";
                            break;
                        case 4:
                            cursive += " four ";
                            break;
                        case 5:
                            cursive += " five ";
                            break;
                        case 6:
                            cursive += " six ";
                            break;
                        case 7:
                            cursive += " seven ";
                            break;
                        case 8:
                            cursive += " eight ";
                            break;
                        case 9:
                            cursive += " nine ";
                            break;
                        default:
                            cursive += "";
                            break;
                    }
                }
            }
            return cursive;

        }
    }
}
