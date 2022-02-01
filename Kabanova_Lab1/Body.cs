using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kabanova_Lab1
{
    public class Body
    {
        public double Min { get; set; } = 0;
        public double Sec { get; set; } = 0;
        
        public double Total()
        {
            return Min * 60 + Sec;
        } 
        public string Print()
        {
            return $"Минуты: {Min}, Секунды: {Sec},\n" +
                   $"Общее количество секунд: {Total()}";
        }
    }
}
