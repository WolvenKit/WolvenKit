using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entShadowMeshChangeEvent : redEvent
	{
		[Ordinal(0)] [RED("requestedState")] public CEnum<entAppearanceStatus> RequestedState { get; set; }

		public entShadowMeshChangeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
