using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BaseDeviceStatus : ActionEnum
	{
		[Ordinal(38)] 
		[RED("isRestarting")] 
		public CBool IsRestarting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BaseDeviceStatus()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
