using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldAutoFoliageMappingItem : CVariable
	{
		[Ordinal(0)]  [RED("FoliageBrush")] public raRef<worldFoliageBrush> FoliageBrush { get; set; }
		[Ordinal(1)]  [RED("LayerIndex")] public CUInt32 LayerIndex { get; set; }
		[Ordinal(2)]  [RED("Material")] public CName Material { get; set; }

		public worldAutoFoliageMappingItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
