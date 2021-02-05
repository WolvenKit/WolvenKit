using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ShaftsAreaSettings : CVariable
	{
		[Ordinal(0)]  [RED("shaftsLevelIndex")] public CUInt32 ShaftsLevelIndex { get; set; }
		[Ordinal(1)]  [RED("shaftsIntensity")] public CFloat ShaftsIntensity { get; set; }
		[Ordinal(2)]  [RED("shaftsThresholdsScale")] public CFloat ShaftsThresholdsScale { get; set; }

		public ShaftsAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
