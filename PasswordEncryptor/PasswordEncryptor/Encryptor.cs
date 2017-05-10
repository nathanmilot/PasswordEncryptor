using System;
using System.Security.Cryptography;
using System.Text;

namespace PassGen {
    class Encryptor {
        internal string custom(string input, int minLength) {
            if (minLength < input.Length)
                minLength = input.Length * 3;
            string result = input;
            int charSum = 0;
            for (int i = 0; i < input.Length; i++)
                charSum += (int)input.ToCharArray()[i];
            int maxIter = ((charSum + 1) * 10) % 1000 + 1;
            for (int iter = 0; iter < maxIter; iter++) {
                long buffer = 0;
                while (result.Length < minLength) {
                    buffer = 0;
                    for (int i = 0; i < result.Length; i++) {
                        if ((i % 2) == 0)
                            buffer += (int)result.ToCharArray()[i];
                        else
                            buffer = ((buffer % 1000) * (int)(result.ToCharArray()[i]));
                    }
                    for (int i = 0; i < result.Length; i++) {
                        if ((i % 2) == 0)
                            buffer = ((buffer % 1000) * (int)(result.ToCharArray()[i]));
                        else
                            buffer += (int)(result.ToCharArray()[i]);
                    }
                    buffer = (Math.Abs(buffer) % 94) + 33;
                    result += (char)buffer;
                }
                if (iter < maxIter - 1)
                    result = result.Substring(input.Length);
            }
            return result;
        }

        internal string customHex(string input, int length) {
            string result = custom(input, length / 2);
            byte[] b = Encoding.ASCII.GetBytes(result);
            result = "";
            foreach (byte myB in b)
                result += string.Format("{0:x2}", myB);
            if (result.Length > length) {
                if (length == 0 || length < input.Length) {
                    while (result.Length > input.Length * 3) {
                        result = result.Substring(0, result.Length - 1);
                    }
                } else {
                    while (result.Length > length) {
                        result = result.Substring(0, result.Length - 1);
                    }
                }
            }
            return result;
        }

        internal string customHex2(string input, int minLength) {
            if (minLength < input.Length)
                minLength = input.Length * 3;
            string result = input;
            int charSum = 0;
            for (int i = 0; i < input.Length; i++)
                charSum += (int)input.ToCharArray()[i];
            int maxIter = ((charSum + 1) * 10) % 1000 + 1;
            for (int iter = 0; iter < maxIter; iter++) {
                long buffer = 0;
                while (result.Length < minLength) {
                    buffer = 0;
                    for (int i = 0; i < result.Length; i++) {
                        if ((i % 2) == 0)
                            buffer += (int)result.ToCharArray()[i];
                        else
                            buffer = ((buffer % 1000) * (int)(result.ToCharArray()[i]));
                    }
                    for (int i = 0; i < result.Length; i++) {
                        if ((i % 2) == 0)
                            buffer = ((buffer % 1000) * (int)(result.ToCharArray()[i]));
                        else
                            buffer += (int)(result.ToCharArray()[i]);
                    }
                    buffer = (Math.Abs(buffer) % 94) + 33;
                    result += string.Format("{0:x2}", Encoding.ASCII.GetBytes(((char)buffer) + "")[0]);
                }
                if (iter < maxIter - 1)
                    result = result.Substring(input.Length);
            }

            return result;
        }

        internal string sha1(string input) {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            StringBuilder sb = new StringBuilder();
            foreach (byte b in sha1.ComputeHash(Encoding.ASCII.GetBytes(input)))
                sb.Append(string.Format("{0:x2}", b));
            return sb.ToString();
        }

        internal string sha256(string input) {
            SHA256 sha256 = new SHA256CryptoServiceProvider();
            StringBuilder sb = new StringBuilder();
            foreach (byte b in sha256.ComputeHash(Encoding.ASCII.GetBytes(input)))
                sb.Append(string.Format("{0:x2}", b));
            return sb.ToString();
        }

        internal string sha512(string input) {
            SHA512 sha512 = new SHA512CryptoServiceProvider();
            StringBuilder sb = new StringBuilder();
            foreach (byte b in sha512.ComputeHash(Encoding.ASCII.GetBytes(input)))
                sb.Append(string.Format("{0:x2}", b));
            return sb.ToString();
        }
    }
}
