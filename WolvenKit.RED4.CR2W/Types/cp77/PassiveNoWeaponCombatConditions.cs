using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PassiveNoWeaponCombatConditions : PassiveAutonomousCondition
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

		public PassiveNoWeaponCombatConditions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
