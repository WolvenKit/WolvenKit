using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehiclePersistentDataPS : gameComponentPS
	{
		[Ordinal(0)]  [RED("audio")] public vehicleAudioPSData Audio { get; set; }
		[Ordinal(1)]  [RED("autopilotCurrentSpeed")] public CFloat AutopilotCurrentSpeed { get; set; }
		[Ordinal(2)]  [RED("autopilotPos")] public CFloat AutopilotPos { get; set; }
		[Ordinal(3)]  [RED("destruction")] public vehicleDestructionPSData Destruction { get; set; }
		[Ordinal(4)]  [RED("flags")] public CUInt32 Flags { get; set; }
		[Ordinal(5)]  [RED("questEnforcedTransform")] public Transform QuestEnforcedTransform { get; set; }
		[Ordinal(6)]  [RED("wheelRuntimeData", 4)] public CStatic<vehicleWheelRuntimePSData> WheelRuntimeData { get; set; }

		public vehiclePersistentDataPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
