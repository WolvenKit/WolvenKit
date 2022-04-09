using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Agent : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("link")] 
		public DeviceLink Link
		{
			get => GetPropertyValue<DeviceLink>();
			set => SetPropertyValue<DeviceLink>(value);
		}

		[Ordinal(1)] 
		[RED("reprimands")] 
		public CArray<ReprimandData> Reprimands
		{
			get => GetPropertyValue<CArray<ReprimandData>>();
			set => SetPropertyValue<CArray<ReprimandData>>(value);
		}

		[Ordinal(2)] 
		[RED("supportingAgents")] 
		public CArray<gamePersistentID> SupportingAgents
		{
			get => GetPropertyValue<CArray<gamePersistentID>>();
			set => SetPropertyValue<CArray<gamePersistentID>>(value);
		}

		[Ordinal(3)] 
		[RED("areas")] 
		public CArray<DeviceLink> Areas
		{
			get => GetPropertyValue<CArray<DeviceLink>>();
			set => SetPropertyValue<CArray<DeviceLink>>(value);
		}

		[Ordinal(4)] 
		[RED("incomingFilter")] 
		public CEnum<EFilterType> IncomingFilter
		{
			get => GetPropertyValue<CEnum<EFilterType>>();
			set => SetPropertyValue<CEnum<EFilterType>>(value);
		}

		[Ordinal(5)] 
		[RED("cachedDelayDuration")] 
		public CFloat CachedDelayDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public Agent()
		{
			Link = new() { PSID = new() };
			Reprimands = new();
			SupportingAgents = new();
			Areas = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
