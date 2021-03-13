using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SwitchSeatsEvents : VehicleEventsTransition
	{
		[Ordinal(3)] [RED("workspotSystem")] public CHandle<gameWorkspotGameSystem> WorkspotSystem { get; set; }
		[Ordinal(4)] [RED("enabledSceneMode")] public CBool EnabledSceneMode { get; set; }

		public SwitchSeatsEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
