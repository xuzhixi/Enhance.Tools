using System;

namespace Enhance.Tools
{
    public static class StringExtension
    {
        public static string MD5Lower(this string data)
        {
            return DigestAlgorithm.MD5(data).ToLower();
        }

        public static string MD5Upper(this string data)
        {
            return DigestAlgorithm.MD5(data);
        }
    }
}
