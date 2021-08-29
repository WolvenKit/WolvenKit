using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RetractableAdControllerPS : BaseAnimatedDeviceControllerPS
	{
		private CBool _isControlled;

		[Ordinal(109)] 
		[RED("isControlled")] 
		public CBool IsControlled
		{
			get => GetProperty(ref _isControlled);
			set => SetProperty(ref _isControlled, value);
		}
	}
}
