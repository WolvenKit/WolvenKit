using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CoderControllerPS : BasicDistractionDeviceControllerPS
	{
		[Ordinal(108)] [RED("providedAuthorizationLevel")] public CEnum<ESecurityAccessLevel> ProvidedAuthorizationLevel { get; set; }

		public CoderControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
