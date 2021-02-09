using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WorkspotFunctionalTestsDebugListener : IScriptable
	{
		[Ordinal(0)]  [RED("entityId")] public entEntityID EntityId { get; set; }
		[Ordinal(1)]  [RED("instancesCreated")] public CInt32 InstancesCreated { get; set; }
		[Ordinal(2)]  [RED("instancesRemoved")] public CInt32 InstancesRemoved { get; set; }
		[Ordinal(3)]  [RED("workspotsSetup")] public CInt32 WorkspotsSetup { get; set; }
		[Ordinal(4)]  [RED("workspotsStarted")] public CInt32 WorkspotsStarted { get; set; }
		[Ordinal(5)]  [RED("workspotsFinished")] public CInt32 WorkspotsFinished { get; set; }
		[Ordinal(6)]  [RED("animationsStack")] public CArray<CString> AnimationsStack { get; set; }
		[Ordinal(7)]  [RED("animationsSkippedStack")] public CArray<CString> AnimationsSkippedStack { get; set; }
		[Ordinal(8)]  [RED("animationsMissingStack")] public CArray<CString> AnimationsMissingStack { get; set; }
		[Ordinal(9)]  [RED("skipOverflows")] public CInt32 SkipOverflows { get; set; }
		[Ordinal(10)]  [RED("teleportRequests")] public CInt32 TeleportRequests { get; set; }
		[Ordinal(11)]  [RED("movementRequests")] public CInt32 MovementRequests { get; set; }

		public WorkspotFunctionalTestsDebugListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
