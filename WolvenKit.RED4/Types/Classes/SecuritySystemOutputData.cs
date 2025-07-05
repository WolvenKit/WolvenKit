using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecuritySystemOutputData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("link")] 
		public DeviceLink Link
		{
			get => GetPropertyValue<DeviceLink>();
			set => SetPropertyValue<DeviceLink>(value);
		}

		[Ordinal(1)] 
		[RED("breachOrigin")] 
		public CEnum<EBreachOrigin> BreachOrigin
		{
			get => GetPropertyValue<CEnum<EBreachOrigin>>();
			set => SetPropertyValue<CEnum<EBreachOrigin>>(value);
		}

		[Ordinal(2)] 
		[RED("delayDuration")] 
		public CFloat DelayDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SecuritySystemOutputData()
		{
			Link = new DeviceLink { PSID = new gamePersistentID() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
