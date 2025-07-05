using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsActiveLayerData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("activator")] 
		public CWeakHandle<gameObject> Activator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("linkedLayersName")] 
		public CName LinkedLayersName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("layerName")] 
		public CName LayerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameinteractionsActiveLayerData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
