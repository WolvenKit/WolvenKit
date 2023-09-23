using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NanoTechPlatesEffector : ModifyAttackEffector
	{
		[Ordinal(0)] 
		[RED("chanceToTrigger")] 
		public CFloat ChanceToTrigger
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("chanceIncrement")] 
		public CFloat ChanceIncrement
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("nanoPlatesStacks")] 
		public CInt32 NanoPlatesStacks
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("timeWindow")] 
		public CFloat TimeWindow
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("minTimeBetweenBlocks")] 
		public CFloat MinTimeBetweenBlocks
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("timeStamps")] 
		public CArray<CFloat> TimeStamps
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		public NanoTechPlatesEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
