using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CoderControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(0)]  [RED("providedAuthorizationLevel")] public CEnum<ESecurityAccessLevel> ProvidedAuthorizationLevel { get; set; }

		public CoderControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
