using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Security;
using System.Numerics;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace RSA
{
    class RSA
    {
        private const int p = 1031; //69991;
        private const int q = 2549; //104729;

        private long phi;
        public long n { get; set; }
        public int e { get; set; }
        public long d { get; set; }
        
        

        public long nwd(long a, long b)
        {
            return 0 == b ?  a : nwd(b, a % b);
        }

        public RSA()
        {
            n = (long)p*q;
            phi = (long)(p - 1)*(q - 1);
            GenerateE();
            GenerateD();
            //d = 349043463;

            Console.WriteLine(e);
            Console.WriteLine(phi);
            Console.WriteLine(d);

            


        }

        private void GenerateE()
        {


            for (int i = 2; i < phi; i++)
            {
                if (nwd(i, phi) != 1) continue; 
                e = i;
                break;
            }
        }


        private void GenerateD()
        {
            for (var i = phi; i > 0; i--)
            {
                if (phi % (e * i - 1) == 0) //349043463
                {
                    d = i;
                    break;
                }
            }
        }


        public BigInteger[] encrypt(byte[] data)
        {
            var dataEncrypted = new BigInteger[data.Length];

            var bigE = new BigInteger(e);
            var bigN = new BigInteger(n);
            

            for (int i = 0; i < data.Length; i++)
            {
                Console.Write(data[i]);
                Console.Write(" " + (char) data[i] + Environment.NewLine);
                var bigM = new BigInteger(data[i]);
                dataEncrypted[i] = BigInteger.ModPow(bigM, bigE, bigN);
                Console.WriteLine(dataEncrypted[i]);
            }



            return dataEncrypted;
        }


        public byte[] decrypt(BigInteger[] dataEncrypted)
        {
            var data = new BigInteger[dataEncrypted.Length];
            var dataByte = new byte[dataEncrypted.Length];

            var bigD = new BigInteger(d);
            var bigN = new BigInteger(n);

            BigInteger bigC;
            for (int i = 0; i < data.Length; i++)
            {
                bigC = dataEncrypted[i];

                data[i] = BigInteger.ModPow(bigC, bigD, bigN);
                dataByte[i] = (byte)data[i];
                Console.WriteLine(data[i]);
            }

            return dataByte;
        }
    }
}
