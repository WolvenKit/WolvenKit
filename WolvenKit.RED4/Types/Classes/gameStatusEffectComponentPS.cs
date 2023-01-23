using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStatusEffectComponentPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("statusEffectArray")] 
		public CArray<gameStatusEffect> StatusEffectArray
		{
			get => GetPropertyValue<CArray<gameStatusEffect>>();
			set => SetPropertyValue<CArray<gameStatusEffect>>(value);
		}

		[Ordinal(1)] 
		[RED("delayedFunctions")] 
		public CHandle<gameDelayedFunctionsScheduler> DelayedFunctions
		{
			get => GetPropertyValue<CHandle<gameDelayedFunctionsScheduler>>();
			set => SetPropertyValue<CHandle<gameDelayedFunctionsScheduler>>(value);
		}

		[Ordinal(2)] 
		[RED("delayedFunctionsNoTd")] 
		public CHandle<gameDelayedFunctionsScheduler> DelayedFunctionsNoTd
		{
			get => GetPropertyValue<CHandle<gameDelayedFunctionsScheduler>>();
			set => SetPropertyValue<CHandle<gameDelayedFunctionsScheduler>>(value);
		}

		[Ordinal(3)] 
		[RED("isPlayerControlled")] 
		public CBool IsPlayerControlled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("tickComponent")] 
		public CBool TickComponent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameStatusEffectComponentPS()
		{
			StatusEffectArray = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
