using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entTriggerEvent : redEvent
	{
		[Ordinal(0)] [RED("triggerID")] public entEntityID TriggerID { get; set; }
		[Ordinal(1)] [RED("activator")] public entEntityGameInterface Activator { get; set; }
		[Ordinal(2)] [RED("worldPosition")] public Vector4 WorldPosition { get; set; }
		[Ordinal(3)] [RED("numActivatorsInArea")] public CUInt32 NumActivatorsInArea { get; set; }
		[Ordinal(4)] [RED("activatorID")] public CUInt32 ActivatorID { get; set; }
		[Ordinal(5)] [RED("componentName")] public CName ComponentName { get; set; }

		public entTriggerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
