using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gametargetingSystemEntityUntargetedEvent : redEvent
	{
		private CWeakHandle<entEntity> _targetingEntity;

		[Ordinal(0)] 
		[RED("targetingEntity")] 
		public CWeakHandle<entEntity> TargetingEntity
		{
			get => GetProperty(ref _targetingEntity);
			set => SetProperty(ref _targetingEntity, value);
		}
	}
}
