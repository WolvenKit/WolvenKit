using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questRadio_ConditionType : questISystemConditionType
	{
		[Ordinal(0)]  [RED("inverted")] public CBool Inverted { get; set; }
		[Ordinal(1)]  [RED("limitToSpecifiedSpeakersStations")] public CBool LimitToSpecifiedSpeakersStations { get; set; }
		[Ordinal(2)]  [RED("speakerType")] public CEnum<audioRadioSpeakerType> SpeakerType { get; set; }

		public questRadio_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
