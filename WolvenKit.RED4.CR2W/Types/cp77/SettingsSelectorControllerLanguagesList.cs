using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingsSelectorControllerLanguagesList : SettingsSelectorControllerListName
	{
		[Ordinal(22)] [RED("downloadButton")] public inkWidgetReference DownloadButton { get; set; }
		[Ordinal(23)] [RED("descriptionText")] public inkTextWidgetReference DescriptionText { get; set; }
		[Ordinal(24)] [RED("isVoiceOverInstalled")] public CBool IsVoiceOverInstalled { get; set; }
		[Ordinal(25)] [RED("currentSetIndex")] public CInt32 CurrentSetIndex { get; set; }

		public SettingsSelectorControllerLanguagesList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
