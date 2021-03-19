using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderTextureBlobMipMapInfo : CVariable
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

		public rendRenderTextureBlobMipMapInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
