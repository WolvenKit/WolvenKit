using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInputActionRangedAttack : gameIMuppetInputAction
	{
		[Ordinal(0)] [RED("actionType")] public CEnum<gameMuppetInputActionType> ActionType { get; set; }

		public gameMuppetInputActionRangedAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
