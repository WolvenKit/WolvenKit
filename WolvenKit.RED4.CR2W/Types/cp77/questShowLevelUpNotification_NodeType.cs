using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questShowLevelUpNotification_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] [RED("levelUpData")] public questLevelUpData LevelUpData { get; set; }

		public questShowLevelUpNotification_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
