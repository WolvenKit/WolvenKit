using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioDynamicEventsWithInterval : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("events")] 
		public CArray<CName> Events
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("interval")] 
		public CFloat Interval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioDynamicEventsWithInterval()
		{
			Events = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
