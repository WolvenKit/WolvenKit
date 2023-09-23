using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SecurityLocker : InteractiveDevice
	{
		[Ordinal(98)] 
		[RED("cachedEvent")] 
		public CHandle<UseSecurityLocker> CachedEvent
		{
			get => GetPropertyValue<CHandle<UseSecurityLocker>>();
			set => SetPropertyValue<CHandle<UseSecurityLocker>>(value);
		}

		public SecurityLocker()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
