using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldRoadMaterialInfo : CVariable
	{
		[Ordinal(0)]  [RED("material")] public CEnum<worldRoadMaterial> Material { get; set; }
		[Ordinal(1)]  [RED("startOffset")] public CFloat StartOffset { get; set; }

		public worldRoadMaterialInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
