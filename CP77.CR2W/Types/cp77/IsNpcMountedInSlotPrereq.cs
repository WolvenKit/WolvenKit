using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class IsNpcMountedInSlotPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)]  [RED("isCheckInverted")] public CBool IsCheckInverted { get; set; }
		[Ordinal(1)]  [RED("slotName")] public CName SlotName { get; set; }

		public IsNpcMountedInSlotPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
