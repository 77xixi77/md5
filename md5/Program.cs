using System;
using System.Text;
using System.Security.Cryptography;

namespace md5
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "吾爱破解论坛";
            Console.WriteLine(getMd5(a));
        }
        /// <summary>
        /// 实现思路：
        ///         1.将要加密的字符串转换成byte数组
        ///         2.将byte数组进行md5加密成byte数组
        ///         3.将加密后的byte数组转化成字符串(将字节每个元素转化为string)
        /// </summary>
        /// <param name="a">要加密的字符串</param>
        /// <returns></returns>
        private static string getMd5(string a)
        {

            byte[] bytes = Encoding.Default.GetBytes(a);
            MD5 md5 = MD5.Create();
            byte[] outbytes = md5.ComputeHash(bytes);
            string outstr = "";
            foreach (var item in outbytes)
            {
                outstr += item.ToString("x2");
            }
            return outstr;
        }
    }
}
