using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FastTravelConsoleInstructionRequest : gameScriptableSystemRequest
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
	}
}
