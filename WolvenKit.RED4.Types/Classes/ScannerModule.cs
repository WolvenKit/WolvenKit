using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerModule : HUDModule
	{
		private CArray<CHandle<ScanInstance>> _activeScans;

		[Ordinal(3)] 
		[RED("activeScans")] 
		public CArray<CHandle<ScanInstance>> ActiveScans
		{
			get => GetProperty(ref _activeScans);
			set => SetProperty(ref _activeScans, value);
		}
	}
}
