using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICombatGuardAreaConnectedCommunity : CVariable
	{
		private gameEntityReference _communityArea;
		private CArray<CHandle<AIICombatGuardAreaCondition>> _conditions;

		[Ordinal(0)] 
		[RED("communityArea")] 
		public gameEntityReference CommunityArea
		{
			get => GetProperty(ref _communityArea);
			set => SetProperty(ref _communityArea, value);
		}

		[Ordinal(1)] 
		[RED("conditions")] 
		public CArray<CHandle<AIICombatGuardAreaCondition>> Conditions
		{
			get => GetProperty(ref _conditions);
			set => SetProperty(ref _conditions, value);
		}

		public AICombatGuardAreaConnectedCommunity(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
