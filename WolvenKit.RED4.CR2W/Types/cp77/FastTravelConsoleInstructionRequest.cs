using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FastTravelConsoleInstructionRequest : gameScriptableSystemRequest
	{
		private CEnum<EFastTravelSystemInstruction> _instruction;
		private CFloat _magicFloat;

		[Ordinal(0)] 
		[RED("instruction")] 
		public CEnum<EFastTravelSystemInstruction> Instruction
		{
			get => GetProperty(ref _instruction);
			set => SetProperty(ref _instruction, value);
		}

		[Ordinal(1)] 
		[RED("magicFloat")] 
		public CFloat MagicFloat
		{
			get => GetProperty(ref _magicFloat);
			set => SetProperty(ref _magicFloat, value);
		}

		public FastTravelConsoleInstructionRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
