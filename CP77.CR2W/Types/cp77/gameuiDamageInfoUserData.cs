using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiDamageInfoUserData : IScriptable
	{
		[Ordinal(0)] [RED("flags")] public CArray<SHitFlag> Flags { get; set; }
		[Ordinal(1)] [RED("hitShapeType")] public CEnum<EHitShapeType> HitShapeType { get; set; }

		public gameuiDamageInfoUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
