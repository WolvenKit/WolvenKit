using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIRemovedAsHostileThreat : AIAIEvent
	{
		private CWeakHandle<AITargetTrackerComponent> _threateningEntity;
		private CBool _threateningEntityCanTriggersCombat;

		[Ordinal(2)] 
		[RED("threateningEntity")] 
		public CWeakHandle<AITargetTrackerComponent> ThreateningEntity
		{
			get => GetProperty(ref _threateningEntity);
			set => SetProperty(ref _threateningEntity, value);
		}

		[Ordinal(3)] 
		[RED("threateningEntityCanTriggersCombat")] 
		public CBool ThreateningEntityCanTriggersCombat
		{
			get => GetProperty(ref _threateningEntityCanTriggersCombat);
			set => SetProperty(ref _threateningEntityCanTriggersCombat, value);
		}
	}
}
