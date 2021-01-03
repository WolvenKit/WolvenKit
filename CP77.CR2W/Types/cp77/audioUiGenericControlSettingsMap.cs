using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioUiGenericControlSettingsMap : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("uiControlMatrix")] public CArray<audioUiGenericControlSettingsMapItem> UiControlMatrix { get; set; }

		public audioUiGenericControlSettingsMap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
