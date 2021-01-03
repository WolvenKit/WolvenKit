using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldTriggerAreaEventInfo : CVariable
	{
		[Ordinal(0)]  [RED("activatorID")] public CUInt32 ActivatorID { get; set; }
		[Ordinal(1)]  [RED("eventWorldPosition")] public Vector3 EventWorldPosition { get; set; }
		[Ordinal(2)]  [RED("nodeInstance")] public CHandle<worldTriggerAreaNodeInstance> NodeInstance { get; set; }
		[Ordinal(3)]  [RED("numActivatorsInArea")] public CUInt32 NumActivatorsInArea { get; set; }

		public worldTriggerAreaEventInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
