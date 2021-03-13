using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneEvent : ISerializable
	{
		[Ordinal(0)] [RED("id")] public scnSceneEventId Id { get; set; }
		[Ordinal(1)] [RED("type")] public CEnum<scnEventType> Type { get; set; }
		[Ordinal(2)] [RED("startTime")] public CUInt32 StartTime { get; set; }
		[Ordinal(3)] [RED("duration")] public CUInt32 Duration { get; set; }
		[Ordinal(4)] [RED("executionTagFlags")] public CUInt8 ExecutionTagFlags { get; set; }
		[Ordinal(5)] [RED("scalingData")] public CHandle<scnIScalingData> ScalingData { get; set; }

		public scnSceneEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
