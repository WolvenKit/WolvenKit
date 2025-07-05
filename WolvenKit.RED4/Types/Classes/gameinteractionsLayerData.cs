using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsLayerData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameinteractionsLayerData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
