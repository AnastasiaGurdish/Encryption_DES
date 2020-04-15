using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Diagnostics;
using System.Windows.Forms;

namespace Encryption_RSA
{
    static class RSA
    {
        private const int MAX_ITERATION_COUNTER = 10000;
        private const int SHIFT = 2;
        private static string Alphabet;
        private static BigInteger p_ = 0;
        private static BigInteger q_ = 0;
        private static BigInteger n_ = 0;
        private static BigInteger Fn_ = 0;
        private static BigInteger privateKey_ = 0;
        private static BigInteger publicKey_ = 0;


        public static BigInteger GetP() { return p_; }
        public static BigInteger GetQ() { return q_; }
        public static BigInteger GetN() { return n_; }
        public static BigInteger GetFn() { return Fn_; }
        public static BigInteger GetPrivateKey() { return privateKey_; }
        public static BigInteger GetPublicKey() { return publicKey_; }


        public static bool GetKeysAndN(out BigInteger publicKey, out BigInteger privateKey)
        {
            publicKey = -1;
            privateKey = -1;
            BigInteger n = -1;

            if (!GetPrimeNumbers(out BigInteger p, out BigInteger q))
                return false;

            p_ = p;
            q_ = q;

            BigInteger Fn = (p - 1) * (q - 1);
            Fn_ = Fn;

            publicKey = Exp(Fn);
            privateKey = ModInverse(publicKey, Fn);

            publicKey_ = publicKey;
            privateKey_ = privateKey;

            n = p * q;
            n_ = n;
            return true;
        }

        private static void SetAlphabet(string fromText)
        {
            Alphabet = string.Empty;

            foreach (var item in fromText.Distinct())
                Alphabet += item;
        }

        public static bool GetPrimeNumbers(out BigInteger p, out BigInteger q)
        {
            p = -1;
            q = -1;

            int iterationCount = 0;

            BigInteger min = new BigInteger(100000);
            BigInteger max = new BigInteger(999999);

            BigInteger pResult = Environment.TickCount;
            BigInteger qResult = DateTime.Now.Ticks;

            var watch = Stopwatch.StartNew();

            do
            {
                pResult = GenerateRandomBigInteger(qResult, min, max, true);
                qResult = GenerateRandomBigInteger(pResult, min, max, true);
            }
            while (++iterationCount < MAX_ITERATION_COUNTER && !(pResult != qResult && IsPrimeNumber(pResult) && IsPrimeNumber(qResult)));

            watch.Stop();

            if (iterationCount == MAX_ITERATION_COUNTER)
                return false;

            p = pResult;
            q = qResult;

            return true;
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

        public static List<BigInteger> EncriptionRSAMethod(string text, BigInteger e, BigInteger n)
        {
            SetAlphabet(text);

            List<BigInteger> result = new List<BigInteger>();

            BigInteger index = 0;

            foreach (var letter in text)
            {
                index = (Alphabet.IndexOf(letter) + index + SHIFT) % n;

                result.Add(BigInteger.ModPow(index, e, n));
            }

            return result;
        }

        public static string DecriptionRSAMethod(List<BigInteger> input, BigInteger d, BigInteger n)
        {
            string result = string.Empty;

            BigInteger currentValue = 0;

            int[] intRes = new int[input.Count];

            BigInteger previouslyValue = 0;

            foreach (var item in input)
            {
                currentValue = BigInteger.ModPow(item, d, n);

                result += Alphabet[(int)(currentValue - previouslyValue) - SHIFT];

                previouslyValue = currentValue;
            }
            return result;
        }

        private static BigInteger Exp(BigInteger Fn)
        {
            BigInteger result;

            do
                result = GenerateRandomBigInteger(DateTime.Now.Millisecond, 10, Fn, true);
            while (BigInteger.GreatestCommonDivisor(result, Fn) != 1);

            return result;
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

    }

}

