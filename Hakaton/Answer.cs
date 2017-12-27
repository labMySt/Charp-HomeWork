using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcTaskOwn
{
    class Answer
    {
       public int[] answerMass;

        public Answer(Sourse json)
        {
            answerMass = new int[json.tasks.Length];
        }

        public void Print()
        {
            int length = answerMass.Length;
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{answerMass[i]}, ");
            }
        }
        

    }
}
