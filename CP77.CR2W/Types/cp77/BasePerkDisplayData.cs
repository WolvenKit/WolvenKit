using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BasePerkDisplayData : IDisplayData
	{
		[Ordinal(0)]  [RED("attributeId")] public TweakDBID AttributeId { get; set; }
		[Ordinal(1)]  [RED("binkRef")] public redResourceReferenceScriptToken BinkRef { get; set; }
		[Ordinal(2)]  [RED("iconID")] public CName IconID { get; set; }
		[Ordinal(3)]  [RED("level")] public CInt32 Level { get; set; }
		[Ordinal(4)]  [RED("localizedDescription")] public CString LocalizedDescription { get; set; }
		[Ordinal(5)]  [RED("localizedName")] public CString LocalizedName { get; set; }
		[Ordinal(6)]  [RED("locked")] public CBool Locked { get; set; }
		[Ordinal(7)]  [RED("maxLevel")] public CInt32 MaxLevel { get; set; }
		[Ordinal(8)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(9)]  [RED("proficiency")] public CEnum<gamedataProficiencyType> Proficiency { get; set; }

		public BasePerkDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
