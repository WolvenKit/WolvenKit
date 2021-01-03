using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SwitchSeatsEvents : VehicleEventsTransition
	{
		[Ordinal(0)]  [RED("enabledSceneMode")] public CBool EnabledSceneMode { get; set; }
		[Ordinal(1)]  [RED("workspotSystem")] public CHandle<gameWorkspotGameSystem> WorkspotSystem { get; set; }

		public SwitchSeatsEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
