using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("cinematics")] 
		public CArray<animAnimSetupEntry> Cinematics
		{
			get => GetPropertyValue<CArray<animAnimSetupEntry>>();
			set => SetPropertyValue<CArray<animAnimSetupEntry>>(value);
		}

		[Ordinal(1)] 
		[RED("gameplay")] 
		public CArray<animAnimSetupEntry> Gameplay
		{
			get => GetPropertyValue<CArray<animAnimSetupEntry>>();
			set => SetPropertyValue<CArray<animAnimSetupEntry>>(value);
		}

		[Ordinal(2)] 
		[RED("hash")] 
		public CUInt64 Hash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public animAnimSetup()
		{
			Cinematics = new();
			Gameplay = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
