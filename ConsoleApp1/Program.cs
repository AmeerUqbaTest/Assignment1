// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

class task {

    static void Main(string[] args)
    {
        //Console.WriteLine("Task 1. Enter a number: ");
        //int x = Convert.ToInt32(Console.ReadLine());
        //task t = new task();
        //t1(x);

        //Console.WriteLine("Task 2. Enter a number: ");
        //x = Convert.ToInt32(Console.ReadLine());
        //t2(x);

        //Console.WriteLine("Task 3. Enter x: ");
        //x = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Task 3. Enter y: ");
        //int y = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Task 3. Enter z: ");
        //int z = Convert.ToInt32(Console.ReadLine());

        //t3(x, y, z);

        //Console.WriteLine("Task 4. Enter a number: ");
        //x = Convert.ToInt32(Console.ReadLine());
        //t4(x);

        //Console.WriteLine("Task 5. Enter a number: ");
        //x = Convert.ToInt32(Console.ReadLine());
        //t5(x);

        //Console.WriteLine("Task 6. Enter a number: ");
        //x = Convert.ToInt32(Console.ReadLine());
        //t6(x);

        //Console.WriteLine("Task 7. Enter a number: ");
        //x = Convert.ToInt32(Console.ReadLine());
        //t7(x);

        //Console.WriteLine("Task 8. Enter a number: ");
        //x = Convert.ToInt32(Console.ReadLine());
        //t8(x);

        //Console.WriteLine("Task 9. Enter a number: ");
        //int x = Convert.ToInt32(Console.ReadLine());
        //t9(x);

        Console.WriteLine("Task 10. Enter x number: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Task 10. Enter y number: ");
        int y = Convert.ToInt32(Console.ReadLine());
        t10(x,y);


    }
    static void t1(int x)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(x * i);
        }
    }

    static void t2(int x)
    {
        if (x % 2 == 0)
        {
            Console.WriteLine("Number is Even");
        }
        else
        {
            Console.WriteLine("Number is Odd");
        }
    }

    static void t3(int x, int y, int z)
    {
        if (x > y)
        {
            if (x > z)
            {
                Console.WriteLine("Largest number is " + x);
            }
            else
            {
                Console.WriteLine("Largest number is " + z);
            }
        }
        else
        {
            if (y > z)
            {
                Console.WriteLine("Largest number is " + y);
            }
            else
            {
                Console.WriteLine("Largest number is " + z);
            }
        }
    }

    static void t4(int x)
    {
        int j = 0;
        for (int i = 1; i <= x; i++)
        {
            j += i;
        }
        Console.WriteLine("Total is " + j);
    }

    static void t5(int x)
    {
        int j = 0;
        while (x >= 10)
        {
            j += x % 10;

            x /= 10;
            j *= 10;
        }
        j += x;
        Console.WriteLine("Reverse: " + j);
    }

    static void t6(int x)
    {
        int j;
        if (x == 0)
        { j = 1; }
        else
        {
            j = x;
            for (int i = x - 1; i > 0; i--)
            {
                j *= i;
            }
        }
        Console.WriteLine("Fractorial: " + j);
    }

    static void t7(int x)
    {
        if ((x % 4 == 0 && x % 100 != 0) || (x % 400 == 0))
        {
            Console.WriteLine("Leap year");
        }
        else
        {
            Console.WriteLine("Not leap year");
        }
    }

    static void t8(int x)
    {
        int prev = 0;
        int curr = 1;
        int temp = curr;

        for (int i=0; i<x-1; i++)
        {
            if (i == 0)Console.Write(prev + " ");
            if (i == 1) Console.Write(curr + " ");
            else
            {
                Console.Write(prev + curr + " ");
                temp = curr;
                curr = curr + prev;
                prev = temp;
            }
        }
    }

    static void t9 (int x)
    {
        if ((x == 2) || (x == 3) || (x == 5) || (x == 7)) Console.WriteLine("Prime");
        if ((x != 0) && (x != 1) && (x % 2 != 0) && (x % 3 != 0) && (x % 5 != 0) && (x % 7 != 0)) Console.WriteLine("Prime");
        else Console.WriteLine("Not Prime");
    }

    static void t10(int x, int y)
    {
        int t;
        if (x < y) t = x;
        else t = y;
        while (t != 1)
        {
            if (y%t==0 && x % t == 0)
            {
                Console.WriteLine("GCD: " + t);
                return;
            }
            t -= 1;
        }
        Console.WriteLine("GCD: " + t);
    }

    static void t11(int x, int y, char j)
    {
        switch (j)
        {
            case '+':
                Console.WriteLine(x + y);
                break;
            case '-':
                Console.WriteLine(x - y);
                break;
            case '*':
                Console.WriteLine(x * y);
                break;
            case '/':
                Console.WriteLine(x / y);
                break;
            case '%':
                Console.WriteLine(x % y);
                break;

        }
    }
    
    static void t12(int x)
    {
        int count = 0;
        while (x > 10) count++;
        count++;
        Console.WriteLine("Total Digits: " + count);
    }

    static void t13(int x)
    {

        int j = 0;
        int y = x;
        while (y >= 10)
        {
            j += y % 10;

            y /= 10;
            j *= 10;
        }
        j += y;
        if (x == y)
        {
            Console.WriteLine("Palindrome");

        }
        else
        {
            Console.WriteLine("Not Palindrome");
        }

    }

    static void t14(int x)
    {
        int j = 0;
        while (x >= 10)
        {
            j += x % 10;

            x /= 10;
        }
        j += x;
    }

    static void t15(int x)
    {
        int j = 0;
        int y = x;
        int z = x;
        int count = 0;
        while (z >= 10)
            z = z / 10;
            count++;
        count++;
        while (y >= 10)
        {
            j += (y % 10)^count;

            y /= 10;
        }
        j += y^count;
        if (x == j)
        {
            Console.WriteLine("Armstrong");

        }
        else
        {
            Console.WriteLine("Not Armstrong");
        }
    }

}


