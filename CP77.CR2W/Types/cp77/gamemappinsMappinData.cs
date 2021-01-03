using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamemappinsMappinData : gamemappinsIMappinData
	{
		[Ordinal(0)]  [RED("active")] public CBool Active { get; set; }
		[Ordinal(1)]  [RED("debugCaption")] public CString DebugCaption { get; set; }
		[Ordinal(2)]  [RED("localizedCaption")] public LocalizationString LocalizedCaption { get; set; }
		[Ordinal(3)]  [RED("mappinType")] public TweakDBID MappinType { get; set; }
		[Ordinal(4)]  [RED("scriptData")] public CHandle<gamemappinsMappinScriptData> ScriptData { get; set; }
		[Ordinal(5)]  [RED("variant")] public CEnum<gamedataMappinVariant> Variant { get; set; }
		[Ordinal(6)]  [RED("visibleThroughWalls")] public CBool VisibleThroughWalls { get; set; }

		public gamemappinsMappinData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
