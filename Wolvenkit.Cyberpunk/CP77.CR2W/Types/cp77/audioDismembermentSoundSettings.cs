using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioDismembermentSoundSettings : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("armEvent")] public CName ArmEvent { get; set; }
		[Ordinal(1)]  [RED("headEvent")] public CName HeadEvent { get; set; }
		[Ordinal(2)]  [RED("legEvent")] public CName LegEvent { get; set; }

		public audioDismembermentSoundSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
