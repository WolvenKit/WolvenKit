using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectAction_MissEvent : gameEffectAction
	{
		[Ordinal(0)] 
		[RED("npcMissEvents")] 
		public CBool NpcMissEvents
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameEffectAction_MissEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
