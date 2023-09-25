using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetPreventionDifficulty : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("damageDealtToPlayerMultiplier")] 
		public CFloat DamageDealtToPlayerMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("chaseAggressivnessMultiplier")] 
		public CFloat ChaseAggressivnessMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("difficuiltyReset")] 
		public CBool DifficuiltyReset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("source")] 
		public CName Source
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SetPreventionDifficulty()
		{
			DamageDealtToPlayerMultiplier = 1.000000F;
			ChaseAggressivnessMultiplier = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
