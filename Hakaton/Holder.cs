using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcTaskOwn
{
    class Holder
    {
        public List<Processor> Type0 = new List<Processor>();
        public List<Processor> Type1 = new List<Processor>();
        public List<Processor> Type2 = new List<Processor>();

        public List<Processor> ProcList = new List<Processor>();
        public List<Task> TaskList = new List<Task>();


        public Holder(Sourse json)
        {
            int lenght = json.processors.Length;
            for(int i = 0; i < lenght; i++)
            {
                switch (json.processors[i])
                {
                    case 0:
                        {
                            Processor a = new Processor(0, i);
                            ProcList.Add(a);
                            Type0.Add(a);

                        }
                        break;
                    case 1:
                        {
                            Processor a = new Processor(1, i);
                            ProcList.Add(a);
                            Type1.Add(a);
                        }
                        break;
                    case 2:
                        {
                            Processor a = new Processor(2, i);
                            ProcList.Add(a);
                            Type2.Add(a);
                        }
                        break;
                }

               
                
            }
            lenght = json.tasks.Length;
            for (int i = 0; i < lenght; i++)
            {
                TaskList.Add(new Task(json.tasks[i], i));
            }
        }



        public void distrib_Priorities()
        {
            int length =TaskList.Count();
            for(int i = 0; i < length; i++)
            {
                if(TaskList[i].value % 13 == 0)
                {
                    if (Type1.LongCount() > 0) Type1[0].AddTask(TaskList[i]);
                    else
                    {
                        if (TaskList[i].value % 2 == 0)
                        {
                            if (Type2.LongCount() > 0) Type2[0].AddTask(TaskList[i]);
                            else Type0[0].AddTask(TaskList[i]);
                        }
                        else
                        {
                            if (Type0.LongCount() > 0) Type0[0].AddTask(TaskList[i]);
                            else Type2[0].AddTask(TaskList[i]);
                        }
                        
                    }
                }
                else if (TaskList[i].value % 2 == 0)
                {
                    if (Type2.LongCount() > 0) Type2[0].AddTask(TaskList[i]);
                    else
                    {
                        if (Type0.LongCount() > 0) Type0[0].AddTask(TaskList[i]);
                        else Type1[0].AddTask(TaskList[i]);
                    }
                }
                else
                {
                    if(Type0.LongCount() > 0) Type0[0].AddTask(TaskList[i]);
                    else
                    {
                        if (Type2.LongCount() > 0) Type2[0].AddTask(TaskList[i]);
                        else Type1[0].AddTask(TaskList[i]);
                    }
                }

            }
        }    
    }
}
