using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioFoleyNPCMetadata : audioAudioMetadata
	{
		[Ordinal(1)] [RED("fastHeavy")] public audioMeleeSound FastHeavy { get; set; }
		[Ordinal(2)] [RED("fastMedium")] public audioMeleeSound FastMedium { get; set; }
		[Ordinal(3)] [RED("fastLight")] public audioMeleeSound FastLight { get; set; }
		[Ordinal(4)] [RED("normalHeavy")] public audioMeleeSound NormalHeavy { get; set; }
		[Ordinal(5)] [RED("normalMedium")] public audioMeleeSound NormalMedium { get; set; }
		[Ordinal(6)] [RED("normalLight")] public audioMeleeSound NormalLight { get; set; }
		[Ordinal(7)] [RED("slowHeavy")] public audioMeleeSound SlowHeavy { get; set; }
		[Ordinal(8)] [RED("slowMedium")] public audioMeleeSound SlowMedium { get; set; }
		[Ordinal(9)] [RED("slowLight")] public audioMeleeSound SlowLight { get; set; }
		[Ordinal(10)] [RED("walk")] public audioMeleeSound Walk { get; set; }
		[Ordinal(11)] [RED("run")] public audioMeleeSound Run { get; set; }

		public audioFoleyNPCMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
