using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FriendlyTargetWeaponChangeCallback : gameAttachmentSlotsScriptCallback
	{
		[Ordinal(2)] [RED("followerRole")] public CHandle<AIFollowerRole> FollowerRole { get; set; }

		public FriendlyTargetWeaponChangeCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
