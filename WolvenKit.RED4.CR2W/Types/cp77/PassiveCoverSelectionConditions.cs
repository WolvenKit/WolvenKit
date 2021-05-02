using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PassiveCoverSelectionConditions : PassiveAutonomousCondition
	{
		private CUInt32 _statsChangedCbId;
		private wCHandle<gamedataGameplayAbility_Record> _ability;
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
		public wCHandle<gamedataGameplayAbility_Record> Ability
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

		public PassiveCoverSelectionConditions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
