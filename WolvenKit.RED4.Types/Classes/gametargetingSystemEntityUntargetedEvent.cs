using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gametargetingSystemEntityUntargetedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("targetingEntity")] 
		public CWeakHandle<entEntity> TargetingEntity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}
	}
}
