using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questGameTimeDelay_ConditionType : questITimeConditionType
	{
		[Ordinal(0)] 
		[RED("days")] 
		public CUInt32 Days
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("hours")] 
		public CUInt32 Hours
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("minutes")] 
		public CUInt32 Minutes
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("seconds")] 
		public CUInt32 Seconds
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public questGameTimeDelay_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
