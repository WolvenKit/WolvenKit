using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questUseWeapon_NodeType : questIItemManagerNodeType
	{
		[Ordinal(0)]  [RED("usageType")] public CEnum<questWeaponUsageType> UsageType { get; set; }
		[Ordinal(1)]  [RED("objectRef")] public CHandle<questUniversalRef> ObjectRef { get; set; }
		[Ordinal(2)]  [RED("overrideShootEffect")] public CName OverrideShootEffect { get; set; }

		public questUseWeapon_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
