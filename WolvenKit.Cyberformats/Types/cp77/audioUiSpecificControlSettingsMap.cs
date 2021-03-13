using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioUiSpecificControlSettingsMap : audioAudioMetadata
	{
		[Ordinal(1)] [RED("specificControlSettingsMatrix")] public CArray<audioUiSpecificControlSettingsMapItem> SpecificControlSettingsMatrix { get; set; }

		public audioUiSpecificControlSettingsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
