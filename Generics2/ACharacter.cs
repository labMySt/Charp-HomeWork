using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
  abstract  class ACharacter
    {
        public string name { get; set; }
        public string race { get; set; }

        public abstract void Show();
    }
}
