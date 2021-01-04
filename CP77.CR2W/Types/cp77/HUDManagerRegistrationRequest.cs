using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HUDManagerRegistrationRequest : HUDManagerRequest
	{
		[Ordinal(0)]  [RED("isRegistering")] public CBool IsRegistering { get; set; }
		[Ordinal(1)]  [RED("type")] public CEnum<HUDActorType> Type { get; set; }

		public HUDManagerRegistrationRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
