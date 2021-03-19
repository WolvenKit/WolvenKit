using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTextureAtlasSlice : CVariable
	{
		private CName _partName;
		private RectF _nineSliceScaleRect;

		[Ordinal(0)] 
		[RED("partName")] 
		public CName PartName
		{
			get => GetProperty(ref _partName);
			set => SetProperty(ref _partName, value);
		}

		[Ordinal(1)] 
		[RED("nineSliceScaleRect")] 
		public RectF NineSliceScaleRect
		{
			get => GetProperty(ref _nineSliceScaleRect);
			set => SetProperty(ref _nineSliceScaleRect, value);
		}

		public inkTextureAtlasSlice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
