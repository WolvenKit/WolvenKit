using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeviceConnectionScannerData : RedBaseClass
	{
		private CString _connectionType;
		private CName _icon;
		private CInt32 _amount;

		[Ordinal(0)] 
		[RED("connectionType")] 
		public CString ConnectionType
		{
			get => GetProperty(ref _connectionType);
			set => SetProperty(ref _connectionType, value);
		}

		[Ordinal(1)] 
		[RED("icon")] 
		public CName Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(2)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get => GetProperty(ref _amount);
			set => SetProperty(ref _amount, value);
		}
	}
}
