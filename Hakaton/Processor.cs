using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcTaskOwn
{
    class Processor
    {
        public int type;
        public int index;
        public int load;
        public List<Task> indexTask = new List<Task>();

        public Processor(int newType, int newIndex)
        {
            type = newType;
            index = newIndex;
        }
        public Processor(Processor newProc)
        {
            type = newProc.type;
            index = newProc.index;
            load = newProc.load;
    }

        public void AddTask(Task task)
        {
            switch (type)
            {
                case 0:
                    load += task.value;
                    indexTask.Add(task);
                    break;
                case 1:
                    if (task.value % 13 == 0) load += task.value / 13;
                    else load += task.value * 3 + 1;             
                    indexTask.Add(task);
                    break;
                case 2:
                    if (task.value % 2 == 0) load += task.value / 2;
                    else load += task.value * 3 + 1;
                    indexTask.Add(task);
                    break;
            }
        }

        public void ClearTask(Task task)
        {
            switch (type)
            {
                case 0:
                    load -= task.value;
                    indexTask.Remove(task);
                    break;
                case 1:
                    if (task.value % 13 == 0) load -= task.value / 13;
                    else load -= task.value * 3 + 1;
                    indexTask.Remove(task);
                    break;
                case 2:
                    if (task.value % 2 == 0) load -= task.value / 2;
                    else load -= task.value * 3 + 1;
                    indexTask.Remove(task);
                    break;
            }
        }
    }
}
