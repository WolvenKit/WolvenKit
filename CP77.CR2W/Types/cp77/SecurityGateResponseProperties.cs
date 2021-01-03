using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SecurityGateResponseProperties : CVariable
	{
		[Ordinal(0)]  [RED("securityGateResponseType")] public CEnum<ESecurityGateResponseType> SecurityGateResponseType { get; set; }
		[Ordinal(1)]  [RED("securityLevelAccessGranted")] public CEnum<ESecurityAccessLevel> SecurityLevelAccessGranted { get; set; }

		public SecurityGateResponseProperties(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
