using System;

namespace Enhance.Tools
{
    public class DigestAlgorithm
    {
        /// <summary>
        /// 计算MD5值（大写字母）
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string MD5(string data)
        {
            var md5 = System.Security.Cryptography.MD5.Create();
            var hashBytes = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(data));
            return BitConverter.ToString(hashBytes).Replace("-", "");
        }
    }
}
