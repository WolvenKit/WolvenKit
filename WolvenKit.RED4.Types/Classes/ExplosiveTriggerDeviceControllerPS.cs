using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExplosiveTriggerDeviceControllerPS : ExplosiveDeviceControllerPS
	{
		private CBool _playerSafePass;
		private CBool _triggerExploded;

		[Ordinal(120)] 
		[RED("playerSafePass")] 
		public CBool PlayerSafePass
		{
			get => GetProperty(ref _playerSafePass);
			set => SetProperty(ref _playerSafePass, value);
		}

		[Ordinal(121)] 
		[RED("triggerExploded")] 
		public CBool TriggerExploded
		{
			get => GetProperty(ref _triggerExploded);
			set => SetProperty(ref _triggerExploded, value);
		}
	}
}
