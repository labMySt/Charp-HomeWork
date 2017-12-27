using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcTaskOwn
{
    class Sort
    {
        public void  SortFunc( List<Processor> List)
        {
            if(List.Count() > 1)
            {
                bool flag = true;
                List.Sort((Processor x, Processor y) => y.load.CompareTo(x.load));
                List[0].indexTask.Sort((Task x, Task y) => x.value.CompareTo(y.value));
              

                while (flag){
                    flag = false;
                    Processor Big = FindBiggestLoad(List);
                    Processor Small = FindLowestLoad(List);
                    int lengthOfTask = Big.indexTask.Count();

                    for (int i = lengthOfTask-1; i >= 0; i--)
                    {
                        Processor BigProc = new Processor(Big);
                        Processor SmallProc = new Processor(Small);
                        
                        SmallProc.AddTask(Big.indexTask[i]);
                        BigProc.ClearTask(Big.indexTask[i]);

                        if (Big.load >= WhatIsBiggets(BigProc.load, SmallProc.load))
                        {
                            flag = true;
                            Small.AddTask(Big.indexTask[i]);
                            Big.ClearTask(Big.indexTask[i]);
                           
                            break;
                        }
                    }
                }
            }
        }
        private Processor FindBiggestLoad(List<Processor> List)
        {
            List.Sort((Processor x, Processor y) => y.load.CompareTo(x.load));
            return List[0];

        }

        private Processor FindLowestLoad(List<Processor> List)
        {
            List.Sort((Processor x, Processor y) => x.load.CompareTo(y.load));
            return List[0];
          
        }
        private int WhatIsBiggets(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }

        public void FinishSort(List<Processor> List, List<Processor> List2)
        {
            if (List.Count() > 1)
            {
                bool flag = true;
               
                while (flag)
                {
                    flag = false;
                    Processor Big = FindBiggestLoad(List);
                    Big.indexTask.Sort((Task x, Task y) => x.value.CompareTo(y.value));
                    
                    Processor Small;
                    if (Big.type == 1)
                    {
                        Small = FindLowestLoad(List2);
                        TryToShare(Big, Small, flag);
                        if (!flag)
                        {
                            Small = FindLowestLoad(List);
                            TryToShare(Big, Small, flag);
                        }
                    }

                    Small = FindLowestLoad(List);
                    TryToShare(Big, Small, flag);

                }
            }
        }

        private void TryToShare(Processor Big, Processor Small, bool flag)
        {
            for (int i = Big.indexTask.Count() - 1; i >= 0; i--)
            {
                Processor BigProc = new Processor(Big);
                Processor SmallProc = new Processor(Small);

                SmallProc.AddTask(Big.indexTask[i]);
                BigProc.ClearTask(Big.indexTask[i]);

                if (Big.load >= WhatIsBiggets(BigProc.load, SmallProc.load))
                {
                    flag = true;
                    Small.AddTask(Big.indexTask[i]);
                    Big.ClearTask(Big.indexTask[i]);

                    break;
                }
            }
        }

        public void GetAnswer(List<Processor> List, Sourse json, Answer answer)
        {
            
            int length = List.Count();
            for (int i  = 0; i < length; i++)
            {
                int lengthOftasks = List[i].indexTask.Count();
                for(int j = 0;j < lengthOftasks; j++)
                {
                    answer.answerMass[List[i].indexTask[j].index] = List[i].index;
                }
            }
        }
    }
}
