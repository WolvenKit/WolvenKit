using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questHackingManager_SetHacked : questHackingManager_ActionType
	{
		[Ordinal(0)] [RED("hacked")] public CBool Hacked { get; set; }

		public questHackingManager_SetHacked(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
