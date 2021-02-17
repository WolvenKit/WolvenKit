using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RevealStatusNotification : HUDManagerRequest
	{
		[Ordinal(1)] [RED("isRevealed")] public CBool IsRevealed { get; set; }

		public RevealStatusNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
