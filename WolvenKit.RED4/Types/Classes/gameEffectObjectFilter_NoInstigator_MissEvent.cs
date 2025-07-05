using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectFilter_NoInstigator_MissEvent : gameEffectObjectGroupFilter
	{
		[Ordinal(0)] 
		[RED("npcMissEvents")] 
		public CBool NpcMissEvents
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameEffectObjectFilter_NoInstigator_MissEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
