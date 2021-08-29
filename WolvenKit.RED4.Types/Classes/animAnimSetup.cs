using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimSetup : RedBaseClass
	{
		private CArray<animAnimSetupEntry> _cinematics;
		private CArray<animAnimSetupEntry> _gameplay;

		[Ordinal(0)] 
		[RED("cinematics")] 
		public CArray<animAnimSetupEntry> Cinematics
		{
			get => GetProperty(ref _cinematics);
			set => SetProperty(ref _cinematics, value);
		}

		[Ordinal(1)] 
		[RED("gameplay")] 
		public CArray<animAnimSetupEntry> Gameplay
		{
			get => GetProperty(ref _gameplay);
			set => SetProperty(ref _gameplay, value);
		}
	}
}
