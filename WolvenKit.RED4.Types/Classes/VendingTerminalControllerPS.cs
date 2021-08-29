using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendingTerminalControllerPS : ScriptableDeviceComponentPS
	{
		private VendingTerminalSetup _vendingTerminalSetup;
		private CBool _isReady;
		private CHandle<VendorDataManager> _vendorDataManager;

		[Ordinal(104)] 
		[RED("vendingTerminalSetup")] 
		public VendingTerminalSetup VendingTerminalSetup
		{
			get => GetProperty(ref _vendingTerminalSetup);
			set => SetProperty(ref _vendingTerminalSetup, value);
		}

		[Ordinal(105)] 
		[RED("isReady")] 
		public CBool IsReady
		{
			get => GetProperty(ref _isReady);
			set => SetProperty(ref _isReady, value);
		}

		[Ordinal(106)] 
		[RED("VendorDataManager")] 
		public CHandle<VendorDataManager> VendorDataManager
		{
			get => GetProperty(ref _vendorDataManager);
			set => SetProperty(ref _vendorDataManager, value);
		}
	}
}
