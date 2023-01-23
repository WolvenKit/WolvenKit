using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entAnimInputSetter : redEvent
	{
		[Ordinal(0)] 
		[RED("key")] 
		public CName Key
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public entAnimInputSetter()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
