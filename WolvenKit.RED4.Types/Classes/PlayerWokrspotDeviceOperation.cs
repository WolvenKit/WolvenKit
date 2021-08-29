using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerWokrspotDeviceOperation : DeviceOperationBase
	{
		private SWorkspotData _playerWorkspot;

		[Ordinal(5)] 
		[RED("playerWorkspot")] 
		public SWorkspotData PlayerWorkspot
		{
			get => GetProperty(ref _playerWorkspot);
			set => SetProperty(ref _playerWorkspot, value);
		}
	}
}
