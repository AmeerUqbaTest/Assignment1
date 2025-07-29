// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

class task
{

    static void Main(string[] args)
    {
        int x;
        int y;
        int z;
        Console.WriteLine("Task 1. Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());
        task t = new task();
        t1(x);

        Console.WriteLine("Task 2. Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());
        t2(x);

        Console.WriteLine("Task 3. Enter x: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Task 3. Enter y: ");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Task 3. Enter z: ");
        z = Convert.ToInt32(Console.ReadLine());

        t3(x, y, z);

        Console.WriteLine("Task 4. Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());
        t4(x);

        Console.WriteLine("Task 5. Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());
        t5(x);

        Console.WriteLine("Task 6. Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());
        t6(x);

        Console.WriteLine("Task 7. Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());
        t7(x);

        Console.WriteLine("Task 8. Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());
        t8(x);

        Console.WriteLine("Task 9. Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());
        t9(x);

        Console.WriteLine("Task 10. Enter x number: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Task 10. Enter y number: ");
        y = Convert.ToInt32(Console.ReadLine());
        t10(x, y);

        Console.WriteLine("Task 11. Enter x number: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Task 11. Enter y number: ");
        y = Convert.ToInt32(Console.ReadLine());
        //for addition
        t11(x, y, '+');

        Console.WriteLine("Task 12. Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());
        t12(x);

        Console.WriteLine("Task 13. Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());
        t13(x);

        Console.WriteLine("Task 14. Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());
        t14(x);

        Console.WriteLine("Task 15. Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());
        t15(x);

        Console.WriteLine("Task 16. Find Max & Min in Array");
        int[] arr16 = { 5, 3, 8, 1, 9, 4 };
        t16(arr16);

        Console.WriteLine("Task 17. Linear Search");
        int[] arr17 = { 10, 20, 30, 40, 50 };
        Console.Write("Enter a number to search: ");
        int key17 = Convert.ToInt32(Console.ReadLine());
        t17(arr17, key17);

        Console.WriteLine("Task 18. Array Sort (Ascending)");
        int[] arr18 = { 5, 2, 8, 1, 9 };
        t18(arr18);

        Console.WriteLine("Task 19. Even/Odd Counter in Array");
        int[] arr19 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        t19(arr19);

        Console.WriteLine("Task 20. Sort List of Names Alphabetically");
        List<string> names20 = new List<string> { "John", "Doe", "Jane", "Smith" };
        t20(names20);

        Console.WriteLine("Task 21. Frequency Counter (Array)");
        int[] arr21 = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };
        t21(arr21);

        Console.WriteLine("Task 22. Matrix Addition");
        int[,] matrixA = { { 1, 2 }, { 3, 4 } };
        int[,] matrixB = { { 5, 6 }, { 7, 8 } };
        t22(matrixA, matrixB);

        Console.WriteLine("Task 23. Vowel Counter in String");
        Console.Write("Enter a sentence: ");
        string sentence23 = Console.ReadLine();
        t23(sentence23);

        Console.WriteLine("Task 24. String Palindrome");
        Console.Write("Enter a string: ");
        string str24 = Console.ReadLine();
        t24(str24);

        Console.WriteLine("Task 25. Reverse Words in a Sentence");
        Console.Write("Enter a sentence: ");
        string sentence25 = Console.ReadLine();
        t25(sentence25);

        Console.WriteLine("Task 26. Remove Duplicates from Array");
        int[] arr26 = { 1, 2, 2, 3, 4, 4, 5 };
        t26(arr26);

        Console.WriteLine("Task 27. Student Marks Manager");
        t27();

        Console.WriteLine("Task 28. Patient Visit Console App");
        t28();

        Console.WriteLine("Task 29. Word Frequency Counter");
        Console.Write("Enter a paragraph: ");
        string paragraph29 = Console.ReadLine();
        t29(paragraph29);

        Console.WriteLine("Task 30. Random Password Generator");
        Console.Write("Enter password length: ");
        int length30 = Convert.ToInt32(Console.ReadLine());
        t30(length30);

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

        for (int i = 0; i < x - 1; i++)
        {
            if (i == 0) Console.Write(prev + " ");
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

    static void t9(int x)
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
            if (y % t == 0 && x % t == 0)
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
        int original = x;
        while (y > 0)
        {
            int remainder = y % 10;
            j = (j * 10) + remainder;
            y /= 10;
        }
        if (original == j)
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
        int y = x;
        while (y > 0)
        {
            j += y % 10;
            y /= 10;
        }
        Console.WriteLine("Sum of digits: " + j);
    }

    static void t15(int x)
    {
        int j = 0;
        int y = x;
        int original = x;
        int count = 0;

        int temp = x;
        while (temp > 0)
        {
            temp /= 10;
            count++;
        }

        while (y > 0)
        {
            int remainder = y % 10;
            j += (int)Math.Pow(remainder, count);
            y /= 10;
        }

        if (original == j)
        {
            Console.WriteLine("Armstrong");
        }
        else
        {
            Console.WriteLine("Not Armstrong");
        }
    }

    static void t16(int[] a)
    {
        if (a == null || a.Length == 0)
        {
            Console.WriteLine("Array is empty.");
            return;
        }
        int x = a[0];
        int y = a[0];
        foreach (int z in a)
        {
            if (z < x)
            {
                x = z;
            }
            if (z > y)
            {
                y = z;
            }
        }
        Console.WriteLine("Minimum value: " + x);
        Console.WriteLine("Maximum value: " + y);
    }

    static void t17(int[] a, int x)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == x)
            {
                Console.WriteLine($"Element {x} found at index {i}");
                return;
            }
        }
        Console.WriteLine($"Element {x} not found in the array.");
    }

    static void t18(int[] a)
    {
        Array.Sort(a);
        Console.WriteLine("Sorted array (Ascending):");
        foreach (int x in a)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
    }

    static void t19(int[] a)
    {
        int x = 0;
        int y = 0;
        foreach (int z in a)
        {
            if (z % 2 == 0)
            {
                x++;
            }
            else
            {
                y++;
            }
        }
        Console.WriteLine("Even numbers count: " + x);
        Console.WriteLine("Odd numbers count: " + y);
    }

    static void t20(List<string> a)
    {
        a.Sort();
        Console.WriteLine("Sorted names:");
        foreach (string b in a)
        {
            Console.WriteLine(b);
        }
    }

    static void t21(int[] a)
    {
        Dictionary<int, int> b = new Dictionary<int, int>();
        foreach (int x in a)
        {
            if (b.ContainsKey(x))
            {
                b[x]++;
            }
            else
            {
                b[x] = 1;
            }
        }
        Console.WriteLine("Frequency of each number:");
        foreach (var y in b)
        {
            Console.WriteLine($"{y.Key} appears {y.Value} time(s).");
        }
    }

    static void t22(int[,] a, int[,] b)
    {
        int x = a.GetLength(0);
        int y = a.GetLength(1);
        int[,] c = new int[x, y];

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                c[i, j] = a[i, j] + b[i, j];
            }
        }

        Console.WriteLine("Sum of matrices:");
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                Console.Write(c[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void t23(string a)
    {
        int x = 0;
        string b = "aeiouAEIOU";
        foreach (char y in a)
        {
            if (b.Contains(y))
            {
                x++;
            }
        }
        Console.WriteLine("Number of vowels: " + x);
    }

    static void t24(string a)
    {
        char[] b = a.ToCharArray();
        Array.Reverse(b);
        string c = new string(b);
        if (a.Equals(c, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("The string is a palindrome.");
        }
        else
        {
            Console.WriteLine("The string is not a palindrome.");
        }
    }

    static void t25(string a)
    {
        string[] b = a.Split(' ');
        Array.Reverse(b);
        string c = string.Join(" ", b);
        Console.WriteLine("Reversed sentence: " + c);
    }

    static void t26(int[] a)
    {
        HashSet<int> b = new HashSet<int>(a);
        Console.WriteLine("Array with duplicates removed:");
        foreach (int x in b)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
    }

    static Dictionary<string, int> studentMarks = new Dictionary<string, int>();
    static void t27()
    {
        Console.WriteLine("Student Marks Manager");
        Console.WriteLine("1. Add/Update marks");
        Console.WriteLine("2. Search marks");
        Console.WriteLine("3. Exit");
        Console.Write("Choose an option: ");
        int x = Convert.ToInt32(Console.ReadLine());

        switch (x)
        {
            case 1:
                Console.Write("Enter student name: ");
                string a = Console.ReadLine();
                Console.Write("Enter marks: ");
                int y = Convert.ToInt32(Console.ReadLine());
                if (studentMarks.ContainsKey(a))
                {
                    studentMarks[a] = y;
                    Console.WriteLine("Marks updated.");
                }
                else
                {
                    studentMarks.Add(a, y);
                    Console.WriteLine("Marks added.");
                }
                break;
            case 2:
                Console.Write("Enter student name to search: ");
                string b = Console.ReadLine();
                if (studentMarks.ContainsKey(b))
                {
                    Console.WriteLine($"Marks for {b}: {studentMarks[b]}");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
                break;
            case 3:
                return;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
        t27();
    }

    class Patient
    {
        public int x { get; set; }
        public string a { get; set; }
        public string b { get; set; }
    }
    static List<Patient> patientVisits = new List<Patient>();
    static int nextPatientId = 1;
    static void t28()
    {
        Console.WriteLine("\nPatient Visit Console App");
        Console.WriteLine("1. Add Patient Visit");
        Console.WriteLine("2. Search Patient Visit");
        Console.WriteLine("3. Update Patient Visit");
        Console.WriteLine("4. Delete Patient Visit");
        Console.WriteLine("5. Exit");
        Console.Write("Choose an option: ");
        int x = Convert.ToInt32(Console.ReadLine());

        switch (x)
        {
            case 1:
                Console.Write("Enter patient name: ");
                string a = Console.ReadLine();
                Console.Write("Enter visit reason: ");
                string b = Console.ReadLine();
                patientVisits.Add(new Patient { x = nextPatientId++, a = a, b = b });
                Console.WriteLine("Patient visit added.");
                break;
            case 2:
                Console.Write("Enter patient ID to search: ");
                int y = Convert.ToInt32(Console.ReadLine());
                Patient temp = patientVisits.Find(p => p.x == y);
                if (temp != null)
                {
                    Console.WriteLine($"Patient ID: {temp.x}, Name: {temp.a}, Reason: {temp.b}");
                }
                else
                {
                    Console.WriteLine("Patient not found.");
                }
                break;
            case 3:
                Console.Write("Enter patient ID to update: ");
                int z = Convert.ToInt32(Console.ReadLine());
                Patient temp2 = patientVisits.Find(p => p.x == z);
                if (temp2 != null)
                {
                    Console.Write("Enter new name: ");
                    temp2.a = Console.ReadLine();
                    Console.Write("Enter new reason: ");
                    temp2.b = Console.ReadLine();
                    Console.WriteLine("Patient visit updated.");
                }
                else
                {
                    Console.WriteLine("Patient not found.");
                }
                break;
            case 4:
                Console.Write("Enter patient ID to delete: ");
                int y2 = Convert.ToInt32(Console.ReadLine());
                Patient temp3 = patientVisits.Find(p => p.x == y2);
                if (temp3 != null)
                {
                    patientVisits.Remove(temp3);
                    Console.WriteLine("Patient visit deleted.");
                }
                else
                {
                    Console.WriteLine("Patient not found.");
                }
                break;
            case 5:
                return;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
        t28();
    }

    static void t29(string a)
    {
        Dictionary<string, int> b = new Dictionary<string, int>();
        string[] c = a.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string temp in c)
        {
            string d = temp.ToLower();
            if (b.ContainsKey(d))
            {
                b[d]++;
            }
            else
            {
                b[d] = 1;
            }
        }

        Console.WriteLine("Word frequency:");
        foreach (var temp2 in b)
        {
            Console.WriteLine($"{temp2.Key}: {temp2.Value}");
        }
    }

    static void t30(int x)
    {
        const string a = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        Random temp = new Random();
        string b = new string(Enumerable.Repeat(a, x)
          .Select(c => c[temp.Next(c.Length)]).ToArray());
        Console.WriteLine("Generated password: " + b);
    }

}


