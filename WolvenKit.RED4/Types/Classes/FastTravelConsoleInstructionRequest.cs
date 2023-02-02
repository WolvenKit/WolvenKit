using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FastTravelConsoleInstructionRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("instruction")] 
		public CEnum<EFastTravelSystemInstruction> Instruction
		{
			get => GetPropertyValue<CEnum<EFastTravelSystemInstruction>>();
			set => SetPropertyValue<CEnum<EFastTravelSystemInstruction>>(value);
		}

		[Ordinal(1)] 
		[RED("magicFloat")] 
		public CFloat MagicFloat
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public FastTravelConsoleInstructionRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
