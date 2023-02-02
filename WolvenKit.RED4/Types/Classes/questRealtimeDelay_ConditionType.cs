using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questRealtimeDelay_ConditionType : questITimeConditionType
	{
		[Ordinal(0)] 
		[RED("hours")] 
		public CUInt32 Hours
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("minutes")] 
		public CUInt32 Minutes
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("seconds")] 
		public CUInt32 Seconds
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("miliseconds")] 
		public CUInt32 Miliseconds
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public questRealtimeDelay_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
