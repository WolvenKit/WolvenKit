using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scnGameplayTransitionEvent : scnSceneEvent
	{
		[Ordinal(0)]  [RED("performer")] public scnPerformerId Performer { get; set; }
		[Ordinal(1)]  [RED("vehState")] public CEnum<scnPuppetVehicleState> VehState { get; set; }

		public scnGameplayTransitionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
