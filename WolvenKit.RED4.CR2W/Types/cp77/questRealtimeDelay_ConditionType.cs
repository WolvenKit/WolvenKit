using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRealtimeDelay_ConditionType : questITimeConditionType
	{
		[Ordinal(0)] [RED("hours")] public CUInt32 Hours { get; set; }
		[Ordinal(1)] [RED("minutes")] public CUInt32 Minutes { get; set; }
		[Ordinal(2)] [RED("seconds")] public CUInt32 Seconds { get; set; }
		[Ordinal(3)] [RED("miliseconds")] public CUInt32 Miliseconds { get; set; }

		public questRealtimeDelay_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
