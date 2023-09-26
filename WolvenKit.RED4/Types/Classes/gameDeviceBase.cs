using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameDeviceBase : gameObject
	{
		[Ordinal(36)] 
		[RED("isLogicReady")] 
		public CBool IsLogicReady
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameDeviceBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
