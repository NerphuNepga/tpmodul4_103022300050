using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300050
{
    enum State { Terkunci, Terbuka, Masuk };
    class DoorMachine
    {
        private State state;
        private string[] status = { "Terkunci", "Terbuka", "Masuk" };
        public DoorMachine()
        {
            state = State.Terkunci;
            
            Console.WriteLine("Pintu " + status[(int)state]);
        }
        public void Terbuka()
        {
            state = State.Terbuka;
            Console.WriteLine("Pintu " + status[(int)state]);
        }

        public void Terkunci()
        {
            state = State.Terkunci;
            Console.WriteLine("Pintu " + status[(int)state]);
        }

        public void Masuk()
        {
            state = State.Masuk;
            Console.WriteLine("Anda masuk");
        }

        public State GetState()
        {
            return this.state;
        }
    }
}
