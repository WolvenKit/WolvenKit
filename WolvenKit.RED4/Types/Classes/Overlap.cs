using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Overlap : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("instructionNumber")] 
		public CInt32 InstructionNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("otherInstruction")] 
		public CInt32 OtherInstruction
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("atStart")] 
		public CBool AtStart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("rarity")] 
		public CInt32 Rarity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public Overlap()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
