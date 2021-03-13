using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CurrentHighLevelNPCStatePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("valueToCheck")] public CEnum<gamedataNPCHighLevelState> ValueToCheck { get; set; }
		[Ordinal(1)] [RED("invert")] public CBool Invert { get; set; }

		public CurrentHighLevelNPCStatePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
