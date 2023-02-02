using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gametargetingSystemEntityTargetedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("targetingEntity")] 
		public CWeakHandle<entEntity> TargetingEntity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		public gametargetingSystemEntityTargetedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
