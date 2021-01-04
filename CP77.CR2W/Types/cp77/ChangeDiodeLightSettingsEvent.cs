using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ChangeDiodeLightSettingsEvent : redEvent
	{
		[Ordinal(0)]  [RED("colorValues")] public CArray<CInt32> ColorValues { get; set; }
		[Ordinal(1)]  [RED("curve")] public CName Curve { get; set; }
		[Ordinal(2)]  [RED("loop")] public CBool Loop { get; set; }
		[Ordinal(3)]  [RED("strength")] public CFloat Strength { get; set; }
		[Ordinal(4)]  [RED("time")] public CFloat Time { get; set; }

		public ChangeDiodeLightSettingsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
