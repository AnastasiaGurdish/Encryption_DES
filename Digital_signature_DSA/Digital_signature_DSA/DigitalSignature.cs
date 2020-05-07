using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Digital_signature_DSA
{
    static class DigitalSignature
    {
        private const int MAX_ITERATION_COUNTER = 10000;
        private static char[] characters = new char[] { '#', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-' };
        private static BigInteger p_ = 0;
        private static BigInteger q_ = 0;
        private static BigInteger n_ = 0;
        private static BigInteger Fn_ = 0;
        private static BigInteger d_ = 0;
        private static BigInteger e_ = 0;
        private static BigInteger privateKey_ = 0;
        private static BigInteger publicKey_ = 0;

        public static BigInteger GetP() { return p_; }
        public static BigInteger GetQ() { return q_; }
        public static BigInteger GetN() { return n_; }
        public static BigInteger GetFn() { return Fn_; }
        public static BigInteger GetD() { return d_; }
        public static BigInteger GetE() { return e_; }

        public static bool GetKeysAndN()
        {
            BigInteger n = -1;

            if (!GetPrimeNumbers(out BigInteger p, out BigInteger q))
                return false;

            p_ = p;
            q_ = q;

            n = p * q;
            n_ = n;

            BigInteger Fn = (p - 1) * (q - 1);
            Fn_ = Fn;

            BigInteger d = Calculate_d(Fn);
            BigInteger e = Calculate_e(d, Fn);

            d_ = d;
            e_ = e;
            return true;
        }

        public static List<string> DigitalSignatureFunction (string hash, BigInteger e, BigInteger n)
        {
            List<string> result = new List<string>();

            BigInteger bi;

            for (int i = 0; i < hash.Length; i++)
            {
                int index = Array.IndexOf(characters, hash[i]) % (int)n;

                bi = new BigInteger(index);
                bi = BigInteger.ModPow(bi, e, n);
                result.Add(bi.ToString());
            }

            return result;
        }

        public static string CheckAuthenticity (List<string> text, BigInteger d, BigInteger n)
        {
            string result = "";

            BigInteger bi;

            foreach (string item in text)
            {
                bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.ModPow(bi,d, n) % n;

                int index = Convert.ToInt32(bi.ToString());

                result += characters[index].ToString();
            }

            return result;
        }

        private static BigInteger ModInverse(BigInteger a, BigInteger n)
        {
            BigInteger i = n, v = 0, d = 1;

            while (a > 0)
            {
                BigInteger t = i / a, x = a;

                a = i % x;
                i = x;
                x = d;
                d = v - t * x;
                v = x;
            }

            v %= n;

            if (v < 0)
                v = (v + n) % n;

            return v;
        }

        private static BigInteger Exp(BigInteger Fn)
        {
            BigInteger result;

            do
                result = GenerateRandomBigInteger(DateTime.Now.Millisecond, 10, Fn, true);
            while (BigInteger.GreatestCommonDivisor(result, Fn) != 1);

            return result;
        }

        public static bool GetPrimeNumbers(out BigInteger p, out BigInteger q)
        {
            p = -1;
            q = -1;

            int iterationCount = 0;

            BigInteger min = new BigInteger(100);
            BigInteger max = new BigInteger(1000);

            BigInteger pResult = Environment.TickCount;
            BigInteger qResult = DateTime.Now.Ticks;

            do
            {
                pResult = GenerateRandomBigInteger(qResult, min, max, true);
                qResult = GenerateRandomBigInteger(pResult, min, max, true);
            }
            while (++iterationCount < MAX_ITERATION_COUNTER && !(pResult != qResult && IsPrimeNumber(pResult) && IsPrimeNumber(qResult)));


            if (iterationCount == MAX_ITERATION_COUNTER)
                return false;

            p = pResult;
            q = qResult;

            return true;
        }

        private static BigInteger GenerateRandomBigInteger(BigInteger value, BigInteger minValue, BigInteger maxValue, bool checkThatNotIsEven = false)
        {
            if (maxValue < minValue || maxValue == 0)
                return -1;

            byte[] bytes = maxValue.ToByteArray();

            BigInteger result;

            var random = new Random(GetIntFromBigInteger(value));

            do
            {
                random.NextBytes(bytes);

                bytes[bytes.Length - 1] &= 0x7F; // принудительно делаем положительным числом

                result = new BigInteger(bytes);
            }
            while (
                (checkThatNotIsEven && result.IsEven)
                || result < minValue
                || result > maxValue
            );

            return result;
        }

        private static int GetIntFromBigInteger(BigInteger value)
        {
            var valueBytes = value.ToByteArray();

            int result = 0;
            int length = Math.Min(valueBytes.Length, 4);

            for (int i = 0; i < length; i++)
                result += valueBytes[i] << (i * 8);

            return result;
        }

        private static bool IsPrimeNumber(BigInteger number)
        {
            if (number.IsEven)
                return false;

            BigInteger d = 3;

            while (d * d <= number && number % d != 0)
                d += 2;

            return d * d > number;
        }

        //вычисление параметра d. d должно быть взаимно простым с m
        private static BigInteger Calculate_d(BigInteger m)
        {
            BigInteger d = m - 1;

            for (long i = 2; i <= m; i++)
                if ((m % i == 0) && (d % i == 0)) //если имеют общие делители
                {
                    d--;
                    i = 1;
                }

            return d;
        }

        //вычисление параметра e
        private static BigInteger Calculate_e(BigInteger d, BigInteger m)
        {
            BigInteger e = 10;

            while (true)
            {
                if ((e * d) % m == 1)
                    break;
                else
                    e++;
            }

            return e;
        }
    }
}
