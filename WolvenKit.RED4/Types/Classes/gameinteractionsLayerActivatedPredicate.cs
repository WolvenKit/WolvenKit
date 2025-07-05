using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsLayerActivatedPredicate : gameinteractionsIPredicateType
	{
		[Ordinal(0)] 
		[RED("linkedLayersName")] 
		public CName LinkedLayersName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("layerName")] 
		public CName LayerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameinteractionsLayerActivatedPredicate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
