using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ToggleCustomActionDeviceOperation : DeviceOperationBase
	{
		private CName _customActionID;
		private CBool _enabled;

		[Ordinal(5)] 
		[RED("customActionID")] 
		public CName CustomActionID
		{
			get => GetProperty(ref _customActionID);
			set => SetProperty(ref _customActionID, value);
		}

		[Ordinal(6)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}
	}
}
