using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MinimapLayerHighlightRequest : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("layer")] 
		public CEnum<minimapuiELayerType> Layer
		{
			get => GetPropertyValue<CEnum<minimapuiELayerType>>();
			set => SetPropertyValue<CEnum<minimapuiELayerType>>(value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public minimapLayerHighlightRequestData Data
		{
			get => GetPropertyValue<minimapLayerHighlightRequestData>();
			set => SetPropertyValue<minimapLayerHighlightRequestData>(value);
		}

		public MinimapLayerHighlightRequest()
		{
			Data = new minimapLayerHighlightRequestData { HighlightColor = new HDRColor() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
