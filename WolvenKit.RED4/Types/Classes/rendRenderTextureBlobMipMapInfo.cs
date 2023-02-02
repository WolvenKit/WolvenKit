using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendRenderTextureBlobMipMapInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("layout")] 
		public rendRenderTextureBlobMemoryLayout Layout
		{
			get => GetPropertyValue<rendRenderTextureBlobMemoryLayout>();
			set => SetPropertyValue<rendRenderTextureBlobMemoryLayout>(value);
		}

		[Ordinal(1)] 
		[RED("placement")] 
		public rendRenderTextureBlobPlacement Placement
		{
			get => GetPropertyValue<rendRenderTextureBlobPlacement>();
			set => SetPropertyValue<rendRenderTextureBlobPlacement>(value);
		}

		public rendRenderTextureBlobMipMapInfo()
		{
			Layout = new();
			Placement = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
