using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questUseWeapon_NodeType : questIItemManagerNodeType
	{
		[Ordinal(0)]  [RED("objectRef")] public CHandle<questUniversalRef> ObjectRef { get; set; }
		[Ordinal(1)]  [RED("overrideShootEffect")] public CName OverrideShootEffect { get; set; }
		[Ordinal(2)]  [RED("usageType")] public CEnum<questWeaponUsageType> UsageType { get; set; }

		public questUseWeapon_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
