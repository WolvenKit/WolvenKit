using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleRadioLogicController : inkWidgetLogicController
	{
		private CBool _isSoundStopped;

		[Ordinal(1)] 
		[RED("isSoundStopped")] 
		public CBool IsSoundStopped
		{
			get => GetProperty(ref _isSoundStopped);
			set => SetProperty(ref _isSoundStopped, value);
		}
	}
}
