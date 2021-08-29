using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseDeviceStatus : ActionEnum
	{
		private CBool _isRestarting;

		[Ordinal(25)] 
		[RED("isRestarting")] 
		public CBool IsRestarting
		{
			get => GetProperty(ref _isRestarting);
			set => SetProperty(ref _isRestarting, value);
		}
	}
}
