using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameItemID : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public TweakDBID Id
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("rngSeed")] 
		public CUInt32 RngSeed
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("uniqueCounter")] 
		public CUInt16 UniqueCounter
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public gameItemID()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
