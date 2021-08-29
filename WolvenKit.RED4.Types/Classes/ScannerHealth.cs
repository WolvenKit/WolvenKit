using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerHealth : ScannerChunk
	{
		private CInt32 _currentHealth;
		private CInt32 _totalHealth;

		[Ordinal(0)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get => GetProperty(ref _currentHealth);
			set => SetProperty(ref _currentHealth, value);
		}

		[Ordinal(1)] 
		[RED("totalHealth")] 
		public CInt32 TotalHealth
		{
			get => GetProperty(ref _totalHealth);
			set => SetProperty(ref _totalHealth, value);
		}
	}
}
