using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entdismembermentBodyMaterialConfig : CVariable
	{
		[Ordinal(0)]  [RED("CyberBodyMask")] public physicsRagdollBodyPartE CyberBodyMask { get; set; }
		[Ordinal(1)]  [RED("FleshBodyMask")] public physicsRagdollBodyPartE FleshBodyMask { get; set; }

		public entdismembermentBodyMaterialConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
