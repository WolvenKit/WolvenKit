using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTextureAtlasSlice : CVariable
	{
		[Ordinal(0)] [RED("partName")] public CName PartName { get; set; }
		[Ordinal(1)] [RED("nineSliceScaleRect")] public RectF NineSliceScaleRect { get; set; }

		public inkTextureAtlasSlice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
