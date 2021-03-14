using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldRoadMaterialInfo : CVariable
	{
		[Ordinal(0)] [RED("startOffset")] public CFloat StartOffset { get; set; }
		[Ordinal(1)] [RED("material")] public CEnum<worldRoadMaterial> Material { get; set; }

		public worldRoadMaterialInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
