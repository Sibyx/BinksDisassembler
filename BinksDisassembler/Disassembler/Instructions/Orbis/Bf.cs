using System.Collections;
using System.Collections.Generic;
using BinksDisassembler.Disassembler.Instructions.ArgumentStrategies;

namespace BinksDisassembler.Disassembler.Instructions.Orbis
{
    public class BfFactory : IInstructionFactory
    {
        public IEnumerable<Opcode> GetOpcodes()
        {
            return new List<Opcode>()
            {
                new Opcode(0x4, 6)
            };
        }

        public Instruction Create()
        {
            var instruction = new Instruction("l.bf", "K");
            instruction.AddArgument("N", 26, 6, new NStrategy());
            return instruction;
        }
    }
}