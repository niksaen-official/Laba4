using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба4 {
    internal class Program {
        static void Main(string[] args) {
            List<int> sms = new List<int>();
            for(int i = 0; i < 10; i++) {
                sms.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Итоги:");
            for(int i = 1; i < 17; i++) {
                int filter = i;
                int count = 0;
                for(int k = 0;k < sms.Count; k++) {
                    if (sms[k] == filter) {
                        count++;
                    }
                }
                Console.WriteLine(i + " " + count);
            }
            Console.ReadKey();
        }
    }
}
