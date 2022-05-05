using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Time : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("days")] 
		public CInt32 Days
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("hours")] 
		public CInt32 Hours
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("minutes")] 
		public CInt32 Minutes
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public Time()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
