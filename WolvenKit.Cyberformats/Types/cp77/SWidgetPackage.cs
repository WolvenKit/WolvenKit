using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SWidgetPackage : SWidgetPackageBase
	{
		[Ordinal(7)] [RED("displayName")] public CString DisplayName { get; set; }
		[Ordinal(8)] [RED("ownerID")] public gamePersistentID OwnerID { get; set; }
		[Ordinal(9)] [RED("ownerIDClassName")] public CName OwnerIDClassName { get; set; }
		[Ordinal(10)] [RED("customData")] public CHandle<WidgetCustomData> CustomData { get; set; }
		[Ordinal(11)] [RED("isWidgetInactive")] public CBool IsWidgetInactive { get; set; }
		[Ordinal(12)] [RED("widgetState")] public CEnum<EWidgetState> WidgetState { get; set; }
		[Ordinal(13)] [RED("iconID")] public CName IconID { get; set; }
		[Ordinal(14)] [RED("bckgroundTextureID")] public TweakDBID BckgroundTextureID { get; set; }
		[Ordinal(15)] [RED("iconTextureID")] public TweakDBID IconTextureID { get; set; }
		[Ordinal(16)] [RED("textData")] public CHandle<textTextParameterSet> TextData { get; set; }

		public SWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
