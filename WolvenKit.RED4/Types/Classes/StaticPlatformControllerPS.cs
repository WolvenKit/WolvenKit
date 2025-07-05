using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StaticPlatformControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("isTriggered")] 
		public CBool IsTriggered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public StaticPlatformControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
