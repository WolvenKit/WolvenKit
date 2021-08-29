using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AICombatGuardAreaConnectedCommunity : RedBaseClass
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
	}
}
