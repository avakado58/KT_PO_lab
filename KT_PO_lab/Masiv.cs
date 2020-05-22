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
        private int[] A;
        private bool flagPerform = false;
        public void Generate()
        {
            Value = "";
            A = new int[r.Next(3, 10)];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = r.Next(-20, 20);
                Value += A[i] + " ";

            }
            K = r.Next(1, A.Length);
            Ak = A[K - 1];
            flagPerform = true;
        }
        public void Perform()
        {
            if(flagPerform)
            {
                Value = "";
                for (int i = 0; i < A.Length; i++)
                {
                    A[i] += Ak;
                    if (i == K - 1)
                    {
                        if (Ak + A.Length < 0)
                        {
                            Value += "Отрицательный элемент ";
                        }
                        else
                        {
                            Value += A[i] + " ";
                        }
                    }
                    else
                    {
                        Value += A[i] + " ";
                    }


                }
                flagPerform = false;
            }
           
            
        }
        public bool LoadFromFile()
        {
            throw new NotImplementedException();
        }
    }
}
