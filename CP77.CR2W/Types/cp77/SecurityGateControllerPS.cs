using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SecurityGateControllerPS : MasterControllerPS
	{
		[Ordinal(0)]  [RED("securityGateDetectionProperties")] public SecurityGateDetectionProperties SecurityGateDetectionProperties { get; set; }
		[Ordinal(1)]  [RED("securityGateResponseProperties")] public SecurityGateResponseProperties SecurityGateResponseProperties { get; set; }
		[Ordinal(2)]  [RED("securityGateStatus")] public CEnum<ESecurityGateStatus> SecurityGateStatus { get; set; }
		[Ordinal(3)]  [RED("trespassersDataList")] public CArray<TrespasserEntry> TrespassersDataList { get; set; }

		public SecurityGateControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
