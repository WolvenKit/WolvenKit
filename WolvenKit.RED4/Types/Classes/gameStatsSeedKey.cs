using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStatsSeedKey : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("seed")] 
		public CUInt32 Seed
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameStatsSeedKey()
		{
			EntityID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
