using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DEBUG_VisualizerComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("TEXT_OFFSET")] public CFloat TEXT_OFFSET { get; set; }
		[Ordinal(1)]  [RED("TEXT_SCALE_ATTITUDE")] public CFloat TEXT_SCALE_ATTITUDE { get; set; }
		[Ordinal(2)]  [RED("TEXT_SCALE_IMMORTALITY_MODE")] public CFloat TEXT_SCALE_IMMORTALITY_MODE { get; set; }
		[Ordinal(3)]  [RED("TEXT_SCALE_NAME")] public CFloat TEXT_SCALE_NAME { get; set; }
		[Ordinal(4)]  [RED("TEXT_TOP")] public CFloat TEXT_TOP { get; set; }
		[Ordinal(5)]  [RED("TICK_TIME_DELTA")] public CFloat TICK_TIME_DELTA { get; set; }
		[Ordinal(6)]  [RED("offsetCounter")] public CInt32 OffsetCounter { get; set; }
		[Ordinal(7)]  [RED("processedRecordIndex")] public CInt32 ProcessedRecordIndex { get; set; }
		[Ordinal(8)]  [RED("records")] public CArray<DEBUG_VisualRecord> Records { get; set; }
		[Ordinal(9)]  [RED("showWeaponsStreaming")] public CBool ShowWeaponsStreaming { get; set; }
		[Ordinal(10)]  [RED("timeToNextUpdate")] public CFloat TimeToNextUpdate { get; set; }

		public DEBUG_VisualizerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
