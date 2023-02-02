using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class appearanceCensorshipEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Original")] 
		public CName Original
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("Censored")] 
		public CName Censored
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("CensorFlags")] 
		public CUInt32 CensorFlags
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public appearanceCensorshipEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
