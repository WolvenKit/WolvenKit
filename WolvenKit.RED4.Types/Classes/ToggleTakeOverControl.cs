using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ToggleTakeOverControl : ActionBool
	{
		private CBool _isRequestedFormOtherDevice;

		[Ordinal(25)] 
		[RED("isRequestedFormOtherDevice")] 
		public CBool IsRequestedFormOtherDevice
		{
			get => GetProperty(ref _isRequestedFormOtherDevice);
			set => SetProperty(ref _isRequestedFormOtherDevice, value);
		}
	}
}
