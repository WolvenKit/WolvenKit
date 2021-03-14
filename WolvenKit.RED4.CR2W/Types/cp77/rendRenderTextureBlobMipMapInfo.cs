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
			get
			{
				if (_layout == null)
				{
					_layout = (rendRenderTextureBlobMemoryLayout) CR2WTypeManager.Create("rendRenderTextureBlobMemoryLayout", "layout", cr2w, this);
				}
				return _layout;
			}
			set
			{
				if (_layout == value)
				{
					return;
				}
				_layout = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("placement")] 
		public rendRenderTextureBlobPlacement Placement
		{
			get
			{
				if (_placement == null)
				{
					_placement = (rendRenderTextureBlobPlacement) CR2WTypeManager.Create("rendRenderTextureBlobPlacement", "placement", cr2w, this);
				}
				return _placement;
			}
			set
			{
				if (_placement == value)
				{
					return;
				}
				_placement = value;
				PropertySet(this);
			}
		}

		public rendRenderTextureBlobMipMapInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
