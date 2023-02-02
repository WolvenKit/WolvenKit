using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimMultiBoolToFloatEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("group")] 
		public CName Group
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimMultiBoolToFloatEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
