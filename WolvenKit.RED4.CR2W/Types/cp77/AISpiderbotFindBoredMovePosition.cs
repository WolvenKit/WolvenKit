using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISpiderbotFindBoredMovePosition : AIFindPositionAroundSelf
	{
		[Ordinal(6)] [RED("maxWanderDistance")] public CHandle<AIArgumentMapping> MaxWanderDistance { get; set; }

		public AISpiderbotFindBoredMovePosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
