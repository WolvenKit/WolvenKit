using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class senseStimuliEvent : senseBaseStimuliEvent
	{
		[Ordinal(0)]  [RED("data")] public CHandle<senseStimuliData> Data { get; set; }
		[Ordinal(1)]  [RED("detection")] public CFloat Detection { get; set; }
		[Ordinal(2)]  [RED("id")] public CUInt32 Id { get; set; }
		[Ordinal(3)]  [RED("movePositions")] public CArray<Vector4> MovePositions { get; set; }
		[Ordinal(4)]  [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(5)]  [RED("sourceObject")] public wCHandle<gameObject> SourceObject { get; set; }
		[Ordinal(6)]  [RED("sourcePosition")] public Vector4 SourcePosition { get; set; }
		[Ordinal(7)]  [RED("stimCategory")] public CName StimCategory { get; set; }
		[Ordinal(8)]  [RED("stimInvestigateData")] public stimInvestigateData StimInvestigateData { get; set; }
		[Ordinal(9)]  [RED("stimPriority")] public CEnum<gamedataStimPriority> StimPriority { get; set; }
		[Ordinal(10)]  [RED("stimPropagation")] public CEnum<gamedataStimPropagation> StimPropagation { get; set; }
		[Ordinal(11)]  [RED("stimTags")] public CArray<CName> StimTags { get; set; }
		[Ordinal(12)]  [RED("stimType")] public CEnum<gamedataStimType> StimType { get; set; }

		public senseStimuliEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
