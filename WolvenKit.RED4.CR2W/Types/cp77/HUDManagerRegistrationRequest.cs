using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDManagerRegistrationRequest : HUDManagerRequest
	{
		[Ordinal(1)] [RED("isRegistering")] public CBool IsRegistering { get; set; }
		[Ordinal(2)] [RED("type")] public CEnum<HUDActorType> Type { get; set; }

		public HUDManagerRegistrationRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
