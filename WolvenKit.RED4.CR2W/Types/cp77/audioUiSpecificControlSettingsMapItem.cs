using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioUiSpecificControlSettingsMapItem : audioAudioMetadata
	{
		[Ordinal(1)] [RED("uiEventSettingsMatrix")] public CArray<audioUiControlEventsSettingsMapItem> UiEventSettingsMatrix { get; set; }

		public audioUiSpecificControlSettingsMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
