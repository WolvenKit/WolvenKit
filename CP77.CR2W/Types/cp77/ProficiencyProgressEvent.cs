using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ProficiencyProgressEvent : redEvent
	{
		[Ordinal(0)]  [RED("currentLevel")] public CInt32 CurrentLevel { get; set; }
		[Ordinal(1)]  [RED("delta")] public CInt32 Delta { get; set; }
		[Ordinal(2)]  [RED("expValue")] public CInt32 ExpValue { get; set; }
		[Ordinal(3)]  [RED("isLevelMaxed")] public CBool IsLevelMaxed { get; set; }
		[Ordinal(4)]  [RED("remainingXP")] public CInt32 RemainingXP { get; set; }
		[Ordinal(5)]  [RED("type")] public CEnum<gamedataProficiencyType> Type { get; set; }

		public ProficiencyProgressEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
