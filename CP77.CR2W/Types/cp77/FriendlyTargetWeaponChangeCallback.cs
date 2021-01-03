using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FriendlyTargetWeaponChangeCallback : gameAttachmentSlotsScriptCallback
	{
		[Ordinal(0)]  [RED("followerRole")] public CHandle<AIFollowerRole> FollowerRole { get; set; }

		public FriendlyTargetWeaponChangeCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
