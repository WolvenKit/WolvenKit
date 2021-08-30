using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DisableRPGRequirementsForDeviceActions : redEvent
	{
		private TweakDBID _action;
		private CBool _disable;

		[Ordinal(0)] 
		[RED("action")] 
		public TweakDBID Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(1)] 
		[RED("disable")] 
		public CBool Disable
		{
			get => GetProperty(ref _disable);
			set => SetProperty(ref _disable, value);
		}

		public DisableRPGRequirementsForDeviceActions()
		{
			_disable = true;
		}
	}
}
