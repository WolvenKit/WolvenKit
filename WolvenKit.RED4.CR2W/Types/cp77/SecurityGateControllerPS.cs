using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityGateControllerPS : MasterControllerPS
	{
		[Ordinal(104)] [RED("securityGateDetectionProperties")] public SecurityGateDetectionProperties SecurityGateDetectionProperties { get; set; }
		[Ordinal(105)] [RED("securityGateResponseProperties")] public SecurityGateResponseProperties SecurityGateResponseProperties { get; set; }
		[Ordinal(106)] [RED("securityGateStatus")] public CEnum<ESecurityGateStatus> SecurityGateStatus { get; set; }
		[Ordinal(107)] [RED("trespassersDataList")] public CArray<TrespasserEntry> TrespassersDataList { get; set; }

		public SecurityGateControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
