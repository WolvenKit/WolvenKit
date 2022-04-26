using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entSpawnEffectEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("blackboard")] 
		public CHandle<worldEffectBlackboard> Blackboard
		{
			get => GetPropertyValue<CHandle<worldEffectBlackboard>>();
			set => SetPropertyValue<CHandle<worldEffectBlackboard>>(value);
		}

		[Ordinal(1)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("idForRandomizedEffect")] 
		public CRUID IdForRandomizedEffect
		{
			get => GetPropertyValue<CRUID>();
			set => SetPropertyValue<CRUID>(value);
		}

		[Ordinal(3)] 
		[RED("effectInstanceName")] 
		public CName EffectInstanceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("persistOnDetach")] 
		public CBool PersistOnDetach
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("breakAllLoops")] 
		public CBool BreakAllLoops
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("breakAllOnDestroy")] 
		public CBool BreakAllOnDestroy
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("e3hackDeferCount")] 
		public CUInt32 E3hackDeferCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public entSpawnEffectEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
