using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ToggleOffMeshConnectionsDeviceOperation : DeviceOperationBase
	{
		private CBool _enable;
		private CBool _affectsPlayer;
		private CBool _affectsNPCs;

		[Ordinal(5)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(6)] 
		[RED("affectsPlayer")] 
		public CBool AffectsPlayer
		{
			get => GetProperty(ref _affectsPlayer);
			set => SetProperty(ref _affectsPlayer, value);
		}

		[Ordinal(7)] 
		[RED("affectsNPCs")] 
		public CBool AffectsNPCs
		{
			get => GetProperty(ref _affectsNPCs);
			set => SetProperty(ref _affectsNPCs, value);
		}
	}
}
