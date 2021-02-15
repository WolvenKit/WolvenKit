using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnGameplayTransitionEvent : scnSceneEvent
	{
		[Ordinal(6)] [RED("performer")] public scnPerformerId Performer { get; set; }
		[Ordinal(7)] [RED("vehState")] public CEnum<scnPuppetVehicleState> VehState { get; set; }

		public scnGameplayTransitionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
