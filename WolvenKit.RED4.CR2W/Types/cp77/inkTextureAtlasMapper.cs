using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTextureAtlasMapper : CVariable
	{
		private CName _partName;
		private Rect _clippingRectInPixels;
		private RectF _clippingRectInUVCoords;

		[Ordinal(0)] 
		[RED("partName")] 
		public CName PartName
		{
			get
			{
				if (_partName == null)
				{
					_partName = (CName) CR2WTypeManager.Create("CName", "partName", cr2w, this);
				}
				return _partName;
			}
			set
			{
				if (_partName == value)
				{
					return;
				}
				_partName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("clippingRectInPixels")] 
		public Rect ClippingRectInPixels
		{
			get
			{
				if (_clippingRectInPixels == null)
				{
					_clippingRectInPixels = (Rect) CR2WTypeManager.Create("Rect", "clippingRectInPixels", cr2w, this);
				}
				return _clippingRectInPixels;
			}
			set
			{
				if (_clippingRectInPixels == value)
				{
					return;
				}
				_clippingRectInPixels = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("clippingRectInUVCoords")] 
		public RectF ClippingRectInUVCoords
		{
			get
			{
				if (_clippingRectInUVCoords == null)
				{
					_clippingRectInUVCoords = (RectF) CR2WTypeManager.Create("RectF", "clippingRectInUVCoords", cr2w, this);
				}
				return _clippingRectInUVCoords;
			}
			set
			{
				if (_clippingRectInUVCoords == value)
				{
					return;
				}
				_clippingRectInUVCoords = value;
				PropertySet(this);
			}
		}

		public inkTextureAtlasMapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
