using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioDeviceStateSettings : CVariable
	{
		[Ordinal(0)]  [RED("powerRestoredSound")] public CName PowerRestoredSound { get; set; }
		[Ordinal(1)]  [RED("powerCutSound")] public CName PowerCutSound { get; set; }
		[Ordinal(2)]  [RED("turnOnSound")] public CName TurnOnSound { get; set; }
		[Ordinal(3)]  [RED("turnOffSound")] public CName TurnOffSound { get; set; }
		[Ordinal(4)]  [RED("breakingSound")] public CName BreakingSound { get; set; }

		public audioDeviceStateSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
