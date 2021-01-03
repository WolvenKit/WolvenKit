using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SettingsSelectorControllerLanguagesList : SettingsSelectorControllerListName
	{
		[Ordinal(0)]  [RED("currentSetIndex")] public CInt32 CurrentSetIndex { get; set; }
		[Ordinal(1)]  [RED("descriptionText")] public inkTextWidgetReference DescriptionText { get; set; }
		[Ordinal(2)]  [RED("downloadButton")] public inkWidgetReference DownloadButton { get; set; }
		[Ordinal(3)]  [RED("isVoiceOverInstalled")] public CBool IsVoiceOverInstalled { get; set; }

		public SettingsSelectorControllerLanguagesList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
