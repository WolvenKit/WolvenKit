using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entVoicesetInputToBlock : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("input")] 
		public CName Input
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("blockSpecificVariation")] 
		public CBool BlockSpecificVariation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("variationNumber")] 
		public CUInt32 VariationNumber
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public entVoicesetInputToBlock()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
