using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_IconicItem : animAnimFeature
	{
		private CBool _isScanning;
		private CBool _isFreeDrilling;
		private CBool _isActiveDrilling;
		private CBool _isScanToInteraction;
		private CBool _isItemEquipped;

		[Ordinal(0)] 
		[RED("isScanning")] 
		public CBool IsScanning
		{
			get => GetProperty(ref _isScanning);
			set => SetProperty(ref _isScanning, value);
		}

		[Ordinal(1)] 
		[RED("isFreeDrilling")] 
		public CBool IsFreeDrilling
		{
			get => GetProperty(ref _isFreeDrilling);
			set => SetProperty(ref _isFreeDrilling, value);
		}

		[Ordinal(2)] 
		[RED("isActiveDrilling")] 
		public CBool IsActiveDrilling
		{
			get => GetProperty(ref _isActiveDrilling);
			set => SetProperty(ref _isActiveDrilling, value);
		}

		[Ordinal(3)] 
		[RED("isScanToInteraction")] 
		public CBool IsScanToInteraction
		{
			get => GetProperty(ref _isScanToInteraction);
			set => SetProperty(ref _isScanToInteraction, value);
		}

		[Ordinal(4)] 
		[RED("isItemEquipped")] 
		public CBool IsItemEquipped
		{
			get => GetProperty(ref _isItemEquipped);
			set => SetProperty(ref _isItemEquipped, value);
		}
	}
}
