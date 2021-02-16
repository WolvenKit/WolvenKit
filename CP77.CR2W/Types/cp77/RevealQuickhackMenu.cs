using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RevealQuickhackMenu : HUDManagerRequest
	{
		[Ordinal(1)] [RED("shouldOpenWheel")] public CBool ShouldOpenWheel { get; set; }

		public RevealQuickhackMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
