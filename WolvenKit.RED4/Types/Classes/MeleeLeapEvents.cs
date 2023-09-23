using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleeLeapEvents : MeleeEventsTransition
	{
		[Ordinal(1)] 
		[RED("enableVaultFromLeapAttack")] 
		public CBool EnableVaultFromLeapAttack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("exitingToMeleeStrongAttack")] 
		public CBool ExitingToMeleeStrongAttack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isFinisher")] 
		public CBool IsFinisher
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isTargetKnockedOver")] 
		public CBool IsTargetKnockedOver
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("textLayerId")] 
		public CUInt32 TextLayerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public MeleeLeapEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
