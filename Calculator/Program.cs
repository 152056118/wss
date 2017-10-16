using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
namespace Test5
{
    class Program
    {

        public static void Main(String[] arg0)
        {
            Calculator cal = new Calculator();
            Console.WriteLine("请输入要提取的字符串：");
            Tchar t = new Tchar();
            t.tchar();
            double r = 0;
            while (true)
            {

                Console.WriteLine("请输入两个数：");
                String result = Console.ReadLine();
                String[] shu = result.Split(' ');
                double one = double.Parse(shu[0]);
                double two = double.Parse(shu[1]);
                cal.Equals(one, two);
                Console.WriteLine("输入运算符选择计算方式：加（+），减（-），乘（*），除（/）");

                String i = Console.ReadLine();
                switch (i)
                {
                    case "+": { r = cal.jia(one, two); break; }
                    case "-": { r = cal.jian(one, two); break; }
                    case "*": { r = cal.cheng(one, two); break; }
                    case "/": { r = cal.chu(one, two); break; }
                }
                Console.WriteLine("结果：" + r);

                Console.WriteLine("继续（yes） or 退出（no）");
                String q = Console.ReadLine();

                if (q.Equals("no")) { break; }


            }

        }
    }
    /// <summary>
    /// 计算器类
    /// </summary>
    class Calculator
    {
        /// <summary>
        /// 数组比较是否相等
        /// </summary>
        /// <param name="bt1">数组1</param>
        /// <param name="bt2">数组2</param>
        /// <returns>true:相等，false:不相等</returns>
        public void Equals(double one, double two)
        {


            if (one != two)
            {
                Console.WriteLine("两个数不相等");
            }
            if (one == two)
            {
                Console.WriteLine("两个数相等");
            }

        }
        /// <summary>
        /// 加法
        /// </summary>
        /// <param name="one">加数</param>
        /// <param name="two">加数</param>
        /// <returns>和</returns>
        public double jia(double one, double two)
        {
            return one + two;
        }
        /// <summary>
        /// 减法
        /// </summary>
        /// <param name="one">被减数</param>
        /// <param name="two">减数</param>
        /// <returns>差</returns>
        public double jian(double one, double two)
        {
            return one - two;
        }
        public double cheng(double one, double two)
        {
            return one * two;
        }
        /// <summary>
        /// 除法
        /// </summary>
        /// <param name="one">被除数</param>
        /// <param name="two">除数</param>
        /// <returns>商</returns>
        public double chu(double one, double two)
        {
            while (true)
            {
                if (two > 0)
                {
                    return one / two;
                }
                else
                {
                    Console.WriteLine("除数不能为0，请重新输入：");
                    two = double.Parse(Console.ReadLine());
                }
            }
        }
    }
    public class Tchar
    {
        public void tchar()
        {
            string str = Console.ReadLine();
            int number = 0;
            string num = null;
            foreach (char item in str)
            {
                if (item >= 48 && item <= 58)
                {
                    num += item;
                }
            }
            number = int.Parse(num);
            Console.WriteLine(number);
        }
    }
}
