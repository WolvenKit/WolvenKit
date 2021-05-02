using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SimpleCombatConditon : AIbehaviorconditionScript
	{
		private CBool _firstCoverEvaluationDone;
		private CHandle<gamedataGameplayAbility_Record> _takeCoverAbility;
		private CHandle<gamedataGameplayAbility_Record> _quickhackAbility;

		[Ordinal(0)] 
		[RED("firstCoverEvaluationDone")] 
		public CBool FirstCoverEvaluationDone
		{
			get => GetProperty(ref _firstCoverEvaluationDone);
			set => SetProperty(ref _firstCoverEvaluationDone, value);
		}

		[Ordinal(1)] 
		[RED("takeCoverAbility")] 
		public CHandle<gamedataGameplayAbility_Record> TakeCoverAbility
		{
			get => GetProperty(ref _takeCoverAbility);
			set => SetProperty(ref _takeCoverAbility, value);
		}

		[Ordinal(2)] 
		[RED("quickhackAbility")] 
		public CHandle<gamedataGameplayAbility_Record> QuickhackAbility
		{
			get => GetProperty(ref _quickhackAbility);
			set => SetProperty(ref _quickhackAbility, value);
		}

		public SimpleCombatConditon(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
