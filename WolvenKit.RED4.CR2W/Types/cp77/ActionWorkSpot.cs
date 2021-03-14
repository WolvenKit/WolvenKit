using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActionWorkSpot : ActionBool
	{
		[Ordinal(25)] [RED("workspotTarget")] public wCHandle<gamePuppet> WorkspotTarget { get; set; }

		public ActionWorkSpot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
