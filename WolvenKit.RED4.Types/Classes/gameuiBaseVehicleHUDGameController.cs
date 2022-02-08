using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiBaseVehicleHUDGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("mounted")] 
		public CBool Mounted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
