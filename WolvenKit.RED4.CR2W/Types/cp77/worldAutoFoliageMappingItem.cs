using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAutoFoliageMappingItem : CVariable
	{
		[Ordinal(0)] [RED("Material")] public CName Material { get; set; }
		[Ordinal(1)] [RED("LayerIndex")] public CUInt32 LayerIndex { get; set; }
		[Ordinal(2)] [RED("FoliageBrush")] public raRef<worldFoliageBrush> FoliageBrush { get; set; }

		public worldAutoFoliageMappingItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
