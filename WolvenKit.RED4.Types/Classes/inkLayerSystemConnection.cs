using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkLayerSystemConnection : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("layerName")] 
		public CName LayerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("system")] 
		public CHandle<inkILayerSystemData> System
		{
			get => GetPropertyValue<CHandle<inkILayerSystemData>>();
			set => SetPropertyValue<CHandle<inkILayerSystemData>>(value);
		}

		public inkLayerSystemConnection()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
