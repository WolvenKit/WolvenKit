using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISpiderbotFindBoredMovePosition : AIFindPositionAroundSelf
	{
		private CHandle<AIArgumentMapping> _maxWanderDistance;

		[Ordinal(6)] 
		[RED("maxWanderDistance")] 
		public CHandle<AIArgumentMapping> MaxWanderDistance
		{
			get => GetProperty(ref _maxWanderDistance);
			set => SetProperty(ref _maxWanderDistance, value);
		}

		public AISpiderbotFindBoredMovePosition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
