using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Overlap : RedBaseClass
	{
		private CInt32 _instructionNumber;
		private CInt32 _otherInstruction;
		private CBool _atStart;
		private CInt32 _rarity;

		[Ordinal(0)] 
		[RED("instructionNumber")] 
		public CInt32 InstructionNumber
		{
			get => GetProperty(ref _instructionNumber);
			set => SetProperty(ref _instructionNumber, value);
		}

		[Ordinal(1)] 
		[RED("otherInstruction")] 
		public CInt32 OtherInstruction
		{
			get => GetProperty(ref _otherInstruction);
			set => SetProperty(ref _otherInstruction, value);
		}

		[Ordinal(2)] 
		[RED("atStart")] 
		public CBool AtStart
		{
			get => GetProperty(ref _atStart);
			set => SetProperty(ref _atStart, value);
		}

		[Ordinal(3)] 
		[RED("rarity")] 
		public CInt32 Rarity
		{
			get => GetProperty(ref _rarity);
			set => SetProperty(ref _rarity, value);
		}
	}
}
