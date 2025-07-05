using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gametargetingSystemEntityUntargetedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("targetingEntity")] 
		public CWeakHandle<entEntity> TargetingEntity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		public gametargetingSystemEntityUntargetedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
