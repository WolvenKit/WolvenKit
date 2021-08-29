using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetCustomPersonalLinkReason : ScriptableDeviceAction
	{
		private TweakDBID _reason;

		[Ordinal(25)] 
		[RED("reason")] 
		public TweakDBID Reason
		{
			get => GetProperty(ref _reason);
			set => SetProperty(ref _reason, value);
		}
	}
}
