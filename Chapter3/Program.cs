using System;

namespace Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {         
            //1
            Console.WriteLine(int.Parse(Console.ReadLine()) % 2 == 0 ? "EVEN" : "ODD");
            //2
            Console.WriteLine(int.Parse(Console.ReadLine()) % 35 == 0 ? "DIVISIBLE BY BOTH 5 AND 7" : "INDIVISIBLE BY BOTH 5 AND 7");
            //3
            Console.WriteLine((int.Parse(Console.ReadLine()) / 100) % 10 == 7 ? "Third digit from right to left is 7" : "Third digit from right to left is not 7");
            //4
            Console.WriteLine((int.Parse(Console.ReadLine()) & 8) == 0 ? "Third bit is 0" : "Third bit is 1");
            //5
            Console.Write("Trapezoid A: "); int aTrapezoid = int.Parse(Console.ReadLine());
            Console.Write("Trapezoid B: "); int bTrapezoid = int.Parse(Console.ReadLine());
            Console.Write("Trapezoid H: "); int hTrapezoid = int.Parse(Console.ReadLine());
            Console.WriteLine((aTrapezoid + bTrapezoid) * hTrapezoid / 2);
            //6
            Console.Write("Rectangle A: "); int aRectangle = int.Parse(Console.ReadLine());
            Console.Write("Rectangle H: "); int hRectangle = int.Parse(Console.ReadLine());
            Console.WriteLine("Perimeter: {0}\tArea: {1}", (aRectangle + hRectangle) * 2, aRectangle * hRectangle);
            //7
            Console.WriteLine(int.Parse(Console.ReadLine()) * 0.17);
            //9         
            float xPoint = float.Parse(Console.ReadLine());
            float yPoint = float.Parse(Console.ReadLine());
            Console.WriteLine((Math.Sqrt(xPoint * xPoint + yPoint * yPoint)) <= 5 && (xPoint <-1 || xPoint > 5 || yPoint < 1 || yPoint>5) ?
                 "Point is within the circle and out of the rectangle" : "Point is not within the circle and out of the rectangle");
            //10            
            int fourDigitNumber = int.Parse(Console.ReadLine());
            int firstDigit = fourDigitNumber % 10;
            int secondDigit = (fourDigitNumber / 10) % 10;
            int thirdDigit = (fourDigitNumber / 100) % 10;
            int fourthDigit = (fourDigitNumber / 1000) % 10;
            Console.WriteLine(firstDigit + secondDigit + thirdDigit + fourthDigit);
            Console.WriteLine("{0}{1}{2}{3}",firstDigit, secondDigit, thirdDigit, fourthDigit);
            Console.WriteLine("{0}{3}{2}{1}", firstDigit, secondDigit, thirdDigit, fourthDigit);
            Console.WriteLine("{3}{1}{2}{0}", firstDigit, secondDigit, thirdDigit, fourthDigit);
            //11
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine((number >> position) & 1);
            //12      
            number = int.Parse(Console.ReadLine());
            position = int.Parse(Console.ReadLine());
            bool isItOne= ((number >> position) & 1)== 1;
            Console.WriteLine(isItOne);
            //13            
            number = int.Parse(Console.ReadLine());
            position = int.Parse(Console.ReadLine());
            int value = int.Parse(Console.ReadLine());
            number ^= (-value ^ number) & (1 << position);
            Console.WriteLine(number);            
            //14
            number = int.Parse(Console.ReadLine());
            int sqrtNumber = (int)Math.Sqrt(number);
            bool isItPrimeNumber = false;
            while (sqrtNumber > 1)
            {
                isItPrimeNumber = number % sqrtNumber-- == 0;
                if (isItPrimeNumber == true)
                {
                    Console.WriteLine("It is not prime number");
                    break;
                }
            }
            if (isItPrimeNumber == false)
            {
                Console.WriteLine("It is prime number");
            }
            //15            
            number = int.Parse(Console.ReadLine());
            int position3 = (number >> 3) & 1;
            int position4 = (number >> 4) & 1;
            int position5 = (number >> 5) & 1;
            int position24 = (number >> 24) & 1;
            int position25 = (number >> 25) & 1;
            int position26 = (number >> 26) & 1;
            number ^= (-position24 ^ number) & (1 << 3);
            number ^= (-position25 ^ number) & (1 << 4);
            number ^= (-position26 ^ number) & (1 << 5);
            number ^= (-position3 ^ number) & (1 << 24);
            number ^= (-position4 ^ number) & (1 << 25);
            number ^= (-position5 ^ number) & (1 << 26);
            Console.WriteLine(number);
            //16            
            long num = long.Parse(Console.ReadLine());
            long[] pos = new long[32];
            for (int i = 0; i < 32; i++)
            {
                pos[i]= (number >> i) & 1;
            }
            for (int i = 0; i < 32; i++)
            {
                num ^= (-pos[i] ^ number) & (1 << 31-i);
            }
            Console.WriteLine(number);
        }
    }
}
/*
1.    Write an expression that checks whether an integer is odd or even.

2.    Write a Boolean expression that checks whether a given integer is divisible by both 5 and 7, without a remainder.

3.    Write an expression that checks for a given integer if its third digit(right to left) is 7.

4.    Write an expression that checks whether the third bit in a given integer is 1 or 0.

5.    Write an expression that calculates the area of a trapezoid by given sides a, b and height h.

6.    Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.

7.    The gravitational field of the Moon is approximately 17% of that on the Earth.Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

8.    Write an expression that checks for a given point { x, y} if it is within the circle K[{0, 0}, R=5]. Explanation: the point {0, 0} is the center of the circle and 5 is the radius.

9.    Write an expression that checks for given point { x, y} if it is within the circle K[{0, 0}, R=5] and out of the rectangle[{-1, 1}, {5, 5}]. Clarification: for the rectangle the lower left and the upper right corners are given.

10.   Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:

-     Calculates the sum of the digits(in our example 2+0+1+1 = 4).

-     Prints on the console the number in reversed order: dcba(in our example 1102).

-     Puts the last digit in the first position: dabc(in our example 1201).

-     Exchanges the second and the third digits: acbd(in our example 2101).

11.   We are given number n and position p.Write a sequence of operations that prints the value of the bit on the position p in the number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, p=6 -> 0.

12.   Write a Boolean expression that checks if the bit on position p in the integer v has the value 1. Example v = 5, p = 1-> false.

13.   We are given the number n, the value v(v = 0 or 1) and the position p.write a sequence of operations that changes the value of n, so the bit on the position p has the value of v. Example: n= 35, p= 5, v= 0->n = 3.Another example: n= 35, p= 2, v= 1->n = 39.

14.   Write a program that checks if a given number n (1 < n< 100) is a prime number(i.e.it is divisible without remainder only to itself and 1).

15.   * Write a program that exchanges the values of the bits on positions 3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32-bit unsigned integer.

16.   * Write a program that exchanges bits {p, p+1, …, p+k-1} with bits { q, q+1, …, q+k-1}
of a given 32-bit unsigned integer.*/
