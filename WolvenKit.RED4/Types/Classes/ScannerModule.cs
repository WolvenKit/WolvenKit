using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerModule : HUDModule
	{
		[Ordinal(3)] 
		[RED("activeScans")] 
		public CArray<CHandle<ScanInstance>> ActiveScans
		{
			get => GetPropertyValue<CArray<CHandle<ScanInstance>>>();
			set => SetPropertyValue<CArray<CHandle<ScanInstance>>>(value);
		}

		public ScannerModule()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
