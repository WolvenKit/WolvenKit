using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entTriggerEvent : redEvent
	{
		[Ordinal(0)]  [RED("activator")] public entEntityGameInterface Activator { get; set; }
		[Ordinal(1)]  [RED("activatorID")] public CUInt32 ActivatorID { get; set; }
		[Ordinal(2)]  [RED("componentName")] public CName ComponentName { get; set; }
		[Ordinal(3)]  [RED("numActivatorsInArea")] public CUInt32 NumActivatorsInArea { get; set; }
		[Ordinal(4)]  [RED("triggerID")] public entEntityID TriggerID { get; set; }
		[Ordinal(5)]  [RED("worldPosition")] public Vector4 WorldPosition { get; set; }

		public entTriggerEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
