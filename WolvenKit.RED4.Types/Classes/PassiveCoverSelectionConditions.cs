using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PassiveCoverSelectionConditions : PassiveAutonomousCondition
	{
		private CUInt32 _statsChangedCbId;
		private CWeakHandle<gamedataGameplayAbility_Record> _ability;
		private CHandle<AIStatListener> _statListener;

		[Ordinal(0)] 
		[RED("statsChangedCbId")] 
		public CUInt32 StatsChangedCbId
		{
			get => GetProperty(ref _statsChangedCbId);
			set => SetProperty(ref _statsChangedCbId, value);
		}

		[Ordinal(1)] 
		[RED("ability")] 
		public CWeakHandle<gamedataGameplayAbility_Record> Ability
		{
			get => GetProperty(ref _ability);
			set => SetProperty(ref _ability, value);
		}

		[Ordinal(2)] 
		[RED("statListener")] 
		public CHandle<AIStatListener> StatListener
		{
			get => GetProperty(ref _statListener);
			set => SetProperty(ref _statListener, value);
		}
	}
}
