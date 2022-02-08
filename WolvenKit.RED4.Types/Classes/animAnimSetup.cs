using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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

		public animAnimSetup()
		{
			Cinematics = new();
			Gameplay = new();
		}
	}
}
