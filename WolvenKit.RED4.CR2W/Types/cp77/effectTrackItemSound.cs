using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemSound : effectTrackItem
	{
		[Ordinal(3)] [RED("eventName")] public CName EventName { get; set; }
		[Ordinal(4)] [RED("switches")] public CArray<audioAudSwitch> Switches { get; set; }
		[Ordinal(5)] [RED("params")] public CArray<audioAudParameter> Params { get; set; }
		[Ordinal(6)] [RED("positionName")] public CName PositionName { get; set; }
		[Ordinal(7)] [RED("emitterMetadataName")] public CName EmitterMetadataName { get; set; }
		[Ordinal(8)] [RED("rtpcName")] public CName RtpcName { get; set; }
		[Ordinal(9)] [RED("rtpcValue")] public CHandle<IEvaluatorFloat> RtpcValue { get; set; }

		public effectTrackItemSound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
