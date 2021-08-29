using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendRenderTextureBlobMipMapInfo : RedBaseClass
	{
		private rendRenderTextureBlobMemoryLayout _layout;
		private rendRenderTextureBlobPlacement _placement;

		[Ordinal(0)] 
		[RED("layout")] 
		public rendRenderTextureBlobMemoryLayout Layout
		{
			get => GetProperty(ref _layout);
			set => SetProperty(ref _layout, value);
		}

		[Ordinal(1)] 
		[RED("placement")] 
		public rendRenderTextureBlobPlacement Placement
		{
			get => GetProperty(ref _placement);
			set => SetProperty(ref _placement, value);
		}
	}
}
