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
			get => GetProperty(ref _partName);
			set => SetProperty(ref _partName, value);
		}

		[Ordinal(1)] 
		[RED("clippingRectInPixels")] 
		public Rect ClippingRectInPixels
		{
			get => GetProperty(ref _clippingRectInPixels);
			set => SetProperty(ref _clippingRectInPixels, value);
		}

		[Ordinal(2)] 
		[RED("clippingRectInUVCoords")] 
		public RectF ClippingRectInUVCoords
		{
			get => GetProperty(ref _clippingRectInUVCoords);
			set => SetProperty(ref _clippingRectInUVCoords, value);
		}

		public inkTextureAtlasMapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
