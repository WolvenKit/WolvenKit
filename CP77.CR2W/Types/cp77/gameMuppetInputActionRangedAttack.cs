using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInputActionRangedAttack : gameIMuppetInputAction
	{
		[Ordinal(0)]  [RED("actionType")] public CEnum<gameMuppetInputActionType> ActionType { get; set; }

		public gameMuppetInputActionRangedAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
