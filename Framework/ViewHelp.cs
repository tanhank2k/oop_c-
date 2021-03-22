using System;
namespace BookMan.Framework
{
    using Framework;
    public static class ViewHelp
    {
        /// <summary>
        /// Xuat thong tin ra console voi mau sac  (WriteLine)
        /// </summary>
        /// <param name="mess">Thong tin can xuat</param>
        /// <param name="color">Mau chu</param>
        /// <param name="resetColor">Tra lai mau mac dinh hay khong</param>
        public static void WriteLine(string mess, ConsoleColor color = ConsoleColor.White, bool resetColor = true)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(mess);
            if (resetColor)
                Console.ResetColor();

        }
        /// <summary>
        /// Xuat thong tin ra console voi mau sac (Write)
        /// </summary>
        /// <param name="mess">Thong tin can xuat</param>
        /// <param name="color">Mau sac</param>
        /// <param name="resetColor">Co reset thanh mau mac dinh hay khong?</param>
        public static void Write(string mess, ConsoleColor color = ConsoleColor.White, bool resetColor = true)
        {
            Console.ForegroundColor = color;
            Console.Write(mess);
            if (resetColor)
                Console.ResetColor();
        }

        /// <summary>
        /// In ra thong bao va tiep nhan chuoi nhap cua nguoi dung, sau do chuyen ve gia tri bool
        /// </summary>
        /// <param name="label">Dong thong bao</param>
        /// <param name="labelColor">Mau chu thong bao</param>
        /// <param name="valueColor">Mau chu nguoi dung nhap</param>
        /// <returns></returns>
        public static bool InputBool(string label, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.White)
        {
            Console.ForegroundColor = labelColor;
            Write($"{label} [Y/N]:  ", labelColor);
            ConsoleKeyInfo key = Console.ReadKey();
            bool @char = key.KeyChar == 'y' || key.KeyChar == 'Y' ? true : false;
            return @char;

        }

        /// <summary>
        /// Ham hien thong bao va nhap chuoi sau do chuyen ve dang so nguyen
        /// </summary>
        /// <param name="label">Dong thong bao</param>
        /// <param name="labelColor">Mau thong bao</param>
        /// <param name="valueColor">Mau nhap</param>
        /// <returns></returns>
        public static int InputInt(string label, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.White)
        {
            while (true)
            {
                var str = InputString(label, labelColor, valueColor);
                var result = int.TryParse(str, out int i);
                if (result)
                {
                    return i;
                }
            }
        }

        public static int InputInt(string label, int oldValue, ConsoleColor labelColor = ConsoleColor.Magenta,
                                     ConsoleColor valueColor = ConsoleColor.White)
        {
            Write($"{label}: ", labelColor);
            WriteLine($"{oldValue}", ConsoleColor.Yellow);
            Write("New value >>", ConsoleColor.Green);
            Console.ForegroundColor = valueColor;
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
            {
                return oldValue;
            }

            if (str.ToInt(out int i))
                return i;
            return oldValue;
        }

        public static bool InputBool(string label, bool oldValue, ConsoleColor labelColor = ConsoleColor.Magenta,
                                        ConsoleColor valueColor = ConsoleColor.White)
        {
            Write($"{label}: ", labelColor);
            WriteLine($"{oldValue}", ConsoleColor.Yellow);
            Write("New value >> ", ConsoleColor.Green);
            Console.ForegroundColor = valueColor;
            string str = Console.ReadLine();
            if(string.IsNullOrEmpty(str))
                return oldValue;
            
            return Extension.ToBool(str);
        }

        /// <summary>
        /// Ham hien thong bao va nhap chuoi
        /// </summary>
        /// <param name="label">Dong thong bao</param>
        /// <param name="labelColor">Mau cua thong bao</param>
        /// <param name="valueColor">Mau nhap</param>
        /// <returns></returns>
        public static string InputString(string label, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.White)
        {
            Write($"{label} : ", labelColor);
            Console.ForegroundColor = valueColor;
            string str = Console.ReadLine();
            Console.ResetColor();
            return str;
        }

          public static string InputString(string label,string oldValue, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.White)
        {
            Write($"{label} : ", labelColor);
            Console.ForegroundColor = valueColor;
            string str = Console.ReadLine();
            if(string.IsNullOrEmpty(str))
                return oldValue;
 
            return str;
        }
    }
}