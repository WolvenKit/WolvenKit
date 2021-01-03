using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioAmbientAreaNotifier : worldITriggerAreaNotifer
	{
		[Ordinal(0)]  [RED("Settings")] public CHandle<audioAmbientAreaSettings> Settings { get; set; }
		[Ordinal(1)]  [RED("acousticRepositioningEnabled")] public CBool AcousticRepositioningEnabled { get; set; }
		[Ordinal(2)]  [RED("obstructionChangeTime")] public CFloat ObstructionChangeTime { get; set; }
		[Ordinal(3)]  [RED("occlusionEnabled")] public CBool OcclusionEnabled { get; set; }
		[Ordinal(4)]  [RED("overrideRolloff")] public CBool OverrideRolloff { get; set; }
		[Ordinal(5)]  [RED("rolloffOverride")] public CFloat RolloffOverride { get; set; }
		[Ordinal(6)]  [RED("useAutoOutdoorness")] public CBool UseAutoOutdoorness { get; set; }
		[Ordinal(7)]  [RED("usePhysicsObstruction")] public CBool UsePhysicsObstruction { get; set; }

		public audioAmbientAreaNotifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
