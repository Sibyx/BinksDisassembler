using System.Collections;
using System.Collections.Generic;

namespace BinksDisassembler.Disassembler.Instructions.Orbis
{
    public class LMacUFactory : IInstructionFactory
    {
        public List<Rule> GetRules()
        {
            return new List<Rule>()
            {
                new Rule(0x31, 6),
                new Rule(0x3, 4, 28),
            };
        }

        public Instruction CreateFromBitArray(BitArray data)
        {
            return new LMacU(data);
        }
    }

    public class LMacU : Instruction
    {
        public LMacU(BitArray data) : base(data)
        {
        }

        public LMacU(byte[] data) : base(data)
        {
        }

        public override string ToString()
        {
            return $"l.macu rA, rB";
        }
    }
}