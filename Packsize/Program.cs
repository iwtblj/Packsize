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
            List<string> instructionList = new List<string>();
            StreamReader sr = new StreamReader("input.txt");
            List<Instruction> instructions = JsonConvert.DeserializeObject<List<Instruction>>(sr.ReadToEnd());
            sr.Close();

            instructionList = ExecuteInstruction(instructions[0]);

        }

        static List<string> ExecuteInstruction (Instruction instruction)
        {
            List<string> returnVal = new List<string>();
            returnVal.Add(string.Format("Move cross-head to {0}", instruction.startingCoordinate["X"]));
            returnVal.Add("Lower cross-head knife");
            returnVal.Add(string.Format("Move cross-head to {0}", instruction.length.ToString()));
            returnVal.Add("Raise cross-head knife");
            return returnVal;

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
