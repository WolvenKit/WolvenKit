using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entdismembermentBodyMaterialConfig : CVariable
	{
		[Ordinal(0)]  [RED("CyberBodyMask")] public physicsRagdollBodyPartE CyberBodyMask { get; set; }
		[Ordinal(1)]  [RED("FleshBodyMask")] public physicsRagdollBodyPartE FleshBodyMask { get; set; }

		public entdismembermentBodyMaterialConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
