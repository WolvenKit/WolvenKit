using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioFoleyNPCMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("fastHeavy")] public audioMeleeSound FastHeavy { get; set; }
		[Ordinal(1)]  [RED("fastLight")] public audioMeleeSound FastLight { get; set; }
		[Ordinal(2)]  [RED("fastMedium")] public audioMeleeSound FastMedium { get; set; }
		[Ordinal(3)]  [RED("normalHeavy")] public audioMeleeSound NormalHeavy { get; set; }
		[Ordinal(4)]  [RED("normalLight")] public audioMeleeSound NormalLight { get; set; }
		[Ordinal(5)]  [RED("normalMedium")] public audioMeleeSound NormalMedium { get; set; }
		[Ordinal(6)]  [RED("run")] public audioMeleeSound Run { get; set; }
		[Ordinal(7)]  [RED("slowHeavy")] public audioMeleeSound SlowHeavy { get; set; }
		[Ordinal(8)]  [RED("slowLight")] public audioMeleeSound SlowLight { get; set; }
		[Ordinal(9)]  [RED("slowMedium")] public audioMeleeSound SlowMedium { get; set; }
		[Ordinal(10)]  [RED("walk")] public audioMeleeSound Walk { get; set; }

		public audioFoleyNPCMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
