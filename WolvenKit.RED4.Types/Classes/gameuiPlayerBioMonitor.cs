using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiPlayerBioMonitor : RedBaseClass
	{
		private CInt32 _currentHealth;
		private CInt32 _maximumHealth;
		private CInt32 _currentCyberwarePct;
		private CInt32 _currentArmor;
		private CInt32 _maximumArmor;

		[Ordinal(0)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get => GetProperty(ref _currentHealth);
			set => SetProperty(ref _currentHealth, value);
		}

		[Ordinal(1)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get => GetProperty(ref _maximumHealth);
			set => SetProperty(ref _maximumHealth, value);
		}

		[Ordinal(2)] 
		[RED("currentCyberwarePct")] 
		public CInt32 CurrentCyberwarePct
		{
			get => GetProperty(ref _currentCyberwarePct);
			set => SetProperty(ref _currentCyberwarePct, value);
		}

		[Ordinal(3)] 
		[RED("currentArmor")] 
		public CInt32 CurrentArmor
		{
			get => GetProperty(ref _currentArmor);
			set => SetProperty(ref _currentArmor, value);
		}

		[Ordinal(4)] 
		[RED("maximumArmor")] 
		public CInt32 MaximumArmor
		{
			get => GetProperty(ref _maximumArmor);
			set => SetProperty(ref _maximumArmor, value);
		}
	}
}
