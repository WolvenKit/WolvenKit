using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioAmbientAreaNotifier : worldITriggerAreaNotifer
	{
		[Ordinal(3)] [RED("Settings")] public CHandle<audioAmbientAreaSettings> Settings { get; set; }
		[Ordinal(4)] [RED("usePhysicsObstruction")] public CBool UsePhysicsObstruction { get; set; }
		[Ordinal(5)] [RED("occlusionEnabled")] public CBool OcclusionEnabled { get; set; }
		[Ordinal(6)] [RED("acousticRepositioningEnabled")] public CBool AcousticRepositioningEnabled { get; set; }
		[Ordinal(7)] [RED("obstructionChangeTime")] public CFloat ObstructionChangeTime { get; set; }
		[Ordinal(8)] [RED("overrideRolloff")] public CBool OverrideRolloff { get; set; }
		[Ordinal(9)] [RED("rolloffOverride")] public CFloat RolloffOverride { get; set; }
		[Ordinal(10)] [RED("useAutoOutdoorness")] public CBool UseAutoOutdoorness { get; set; }

		public audioAmbientAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
