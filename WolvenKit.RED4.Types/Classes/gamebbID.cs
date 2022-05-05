using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamebbID : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("g")] 
		public CName G
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gamebbID()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
