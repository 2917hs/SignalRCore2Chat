using System;
using System.Linq;

namespace SignalRSimpleChat
{
    public static class Functional
    {
        private static Random random = new Random();

        public static string RandomUser()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, 5).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
