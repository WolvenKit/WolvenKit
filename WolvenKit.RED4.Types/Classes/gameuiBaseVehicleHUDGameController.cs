using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiBaseVehicleHUDGameController : gameuiHUDGameController
	{
		private CBool _mounted;

		[Ordinal(9)] 
		[RED("mounted")] 
		public CBool Mounted
		{
			get => GetProperty(ref _mounted);
			set => SetProperty(ref _mounted, value);
		}
	}
}
