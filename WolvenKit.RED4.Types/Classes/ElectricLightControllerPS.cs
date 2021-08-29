using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ElectricLightControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _isConnectedToCLS;
		private CBool _wasCLSInitTriggered;

		[Ordinal(104)] 
		[RED("isConnectedToCLS")] 
		public CBool IsConnectedToCLS
		{
			get => GetProperty(ref _isConnectedToCLS);
			set => SetProperty(ref _isConnectedToCLS, value);
		}

		[Ordinal(105)] 
		[RED("wasCLSInitTriggered")] 
		public CBool WasCLSInitTriggered
		{
			get => GetProperty(ref _wasCLSInitTriggered);
			set => SetProperty(ref _wasCLSInitTriggered, value);
		}
	}
}
