using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioUiSpecificControlSettingsMap : audioAudioMetadata
	{
		[Ordinal(1)] [RED("specificControlSettingsMatrix")] public CArray<audioUiSpecificControlSettingsMapItem> SpecificControlSettingsMatrix { get; set; }

		public audioUiSpecificControlSettingsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
