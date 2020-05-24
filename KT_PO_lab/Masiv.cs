using System;
using System.IO;
using System.Windows.Forms;

namespace KT_PO_lab
{
    class Masiv
    {
        Random r = new Random();
        public string Value { get; set; }
        public int K { get; set; }
        private int Ak = 0;
        private int[] A;
        private bool flagGenerate = false;
        private bool flagPerform = false;
        public void FlagPerformChangeOnTrue()
        {
            if(Check(Value))
            {
                flagPerform = true;
                flagGenerate = false;
            }
            
        }
        private bool Check(string Value)
        {
            string leksem = "";
            for (int i = 0; i < Value.Length; i++)
            {
               if(char.IsDigit(Value[i]))
                {
                    leksem += '1';
                }
               else if(Value[i]==' ')
                {
                    leksem += '2';
                }
               else if(Value[i]=='-')
                {
                    leksem += '3';
                }
               else
                {
                    leksem += '0';
                    MessageBox.Show("Ошибка!!!1!11!\nНекорректные символы ");
                    return false;
                }

            }
            return true;
        }
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
            flagGenerate = true;
        }
        public void Perform()
        {
            if(flagPerform)
            {
               if(!flagGenerate)
                {
                    FillMasA();
                }
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
        private void FillMasA()
        {
            int count = 0;
            for (int i = 0; i < Value.Length; i++)
            {
                if (char.IsDigit(Value[i]))
                {
                    if (i == Value.Length - 1)
                    {
                        count++;
                    }
                    else
                    {
                        if (!char.IsDigit(Value[i + 1]))
                        {
                            count++;
                            i++;
                        }

                    }

                }
            }
            A = new int[count];
            string buf = "";
            for (int i = 0, j = 0; i < Value.Length; i++)
            {
                buf += Value[i];
                if (char.IsDigit(Value[i]))
                {
                    if (i == Value.Length - 1)
                    {
                        A[j] = Convert.ToInt32(buf);
                        buf = "";
                        j++;
                        i++;
                    }
                    else
                    {
                        if (!char.IsDigit(Value[i + 1]))
                        {
                            A[j] = Convert.ToInt32(buf);
                            buf = "";
                            j++;
                            i++;
                        }

                    }

                }
            }
            K = r.Next(1, A.Length);
            Ak = A[K - 1];
        }
        public bool LoadFromFile()
        {
                      
            string path = "";
            using (OpenFileDialog open = new OpenFileDialog())
            {

                if (open.ShowDialog() == DialogResult.OK)
                {
                    path = open.FileName;
                    if(Path.GetExtension(path)!=".txt")
                    {
                        MessageBox.Show("Выбран файл с неправильным расширением\nВы можете выбрать файлы с расширением: \".txt\" ", "Ошибка", MessageBoxButtons.OK);
                    }
                    else
                    {
                        using (StreamReader reader = new StreamReader(path))
                        {
                            Value = reader.ReadToEnd();
                            if(Check(Value))
                            {
                                flagGenerate = false;
                                flagPerform = true;
                                return true;
                            }
                            else
                            {
                                Value = "";
                            }
                            
                        }
                    }

                   
                    
                }
            }
            
            return false;
        }
    }
}
