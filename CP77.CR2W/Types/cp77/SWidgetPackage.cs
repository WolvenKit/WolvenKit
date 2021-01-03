using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SWidgetPackage : SWidgetPackageBase
	{
		[Ordinal(0)]  [RED("bckgroundTextureID")] public TweakDBID BckgroundTextureID { get; set; }
		[Ordinal(1)]  [RED("customData")] public CHandle<WidgetCustomData> CustomData { get; set; }
		[Ordinal(2)]  [RED("displayName")] public CString DisplayName { get; set; }
		[Ordinal(3)]  [RED("iconID")] public CName IconID { get; set; }
		[Ordinal(4)]  [RED("iconTextureID")] public TweakDBID IconTextureID { get; set; }
		[Ordinal(5)]  [RED("isWidgetInactive")] public CBool IsWidgetInactive { get; set; }
		[Ordinal(6)]  [RED("ownerID")] public gamePersistentID OwnerID { get; set; }
		[Ordinal(7)]  [RED("ownerIDClassName")] public CName OwnerIDClassName { get; set; }
		[Ordinal(8)]  [RED("textData")] public CHandle<textTextParameterSet> TextData { get; set; }
		[Ordinal(9)]  [RED("widgetState")] public CEnum<EWidgetState> WidgetState { get; set; }

		public SWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
