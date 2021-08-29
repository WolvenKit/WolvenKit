using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PassiveNoWeaponCombatConditions : PassiveAutonomousCondition
	{
		private CUInt32 _delayEvaluationCbId;
		private CUInt32 _onItemAddedToSlotCbId;

		[Ordinal(0)] 
		[RED("delayEvaluationCbId")] 
		public CUInt32 DelayEvaluationCbId
		{
			get => GetProperty(ref _delayEvaluationCbId);
			set => SetProperty(ref _delayEvaluationCbId, value);
		}

		[Ordinal(1)] 
		[RED("onItemAddedToSlotCbId")] 
		public CUInt32 OnItemAddedToSlotCbId
		{
			get => GetProperty(ref _onItemAddedToSlotCbId);
			set => SetProperty(ref _onItemAddedToSlotCbId, value);
		}
	}
}
