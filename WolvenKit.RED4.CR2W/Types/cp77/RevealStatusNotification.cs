using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealStatusNotification : HUDManagerRequest
	{
		[Ordinal(1)] [RED("isRevealed")] public CBool IsRevealed { get; set; }

		public RevealStatusNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
