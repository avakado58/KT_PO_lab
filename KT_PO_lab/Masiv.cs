using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT_PO_lab
{
    class Masiv
    {
        Random r = new Random();
        public string Value { get; set; }
        public int K { get; set; }
        private int Ak = 0;
        public void Generate()
        {
            Value = "";
            int[] A = new int[r.Next(1, 10)];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = r.Next(-20, 20);
                Value += A[i] + " ";

            }
            K = r.Next(1, A.Length);
            Ak = A[K - 1];

        }
        public void Perform()
        {
            throw new NotImplementedException();
        }
        public bool LoadFromFile()
        {
            throw new NotImplementedException();
        }
    }
}
