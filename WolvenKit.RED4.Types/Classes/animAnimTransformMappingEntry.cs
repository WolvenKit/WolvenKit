using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimTransformMappingEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("from")] 
		public CName From
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("to")] 
		public CName To
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animAnimTransformMappingEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
