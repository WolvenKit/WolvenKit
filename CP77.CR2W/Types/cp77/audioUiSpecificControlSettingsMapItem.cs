using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioUiSpecificControlSettingsMapItem : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("uiEventSettingsMatrix")] public CArray<audioUiControlEventsSettingsMapItem> UiEventSettingsMatrix { get; set; }

		public audioUiSpecificControlSettingsMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
