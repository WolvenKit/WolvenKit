using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SimpleCombatConditon : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("firstCoverEvaluationDone")] 
		public CBool FirstCoverEvaluationDone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("takeCoverAbility")] 
		public CHandle<gamedataGameplayAbility_Record> TakeCoverAbility
		{
			get => GetPropertyValue<CHandle<gamedataGameplayAbility_Record>>();
			set => SetPropertyValue<CHandle<gamedataGameplayAbility_Record>>(value);
		}

		[Ordinal(2)] 
		[RED("quickhackAbility")] 
		public CHandle<gamedataGameplayAbility_Record> QuickhackAbility
		{
			get => GetPropertyValue<CHandle<gamedataGameplayAbility_Record>>();
			set => SetPropertyValue<CHandle<gamedataGameplayAbility_Record>>(value);
		}

		public SimpleCombatConditon()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
