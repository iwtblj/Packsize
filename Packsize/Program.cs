using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Packsize
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            List<Instruction> instructions = JsonConvert.DeserializeObject<List<Instruction>>(sr.ReadToEnd());
            sr.Close();
        }
    }

    public class Instruction
    {
        public int instructionNumber { get; set; }
        public string type { get; set; }
        public Dictionary<string, string> startingCoordinate { get; set; }
        public string travelDirection { get; set; }
        public int length { get; set; }
    }
}
