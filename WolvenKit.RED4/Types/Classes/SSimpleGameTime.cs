using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SSimpleGameTime : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("hours")] 
		public CInt32 Hours
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("minutes")] 
		public CInt32 Minutes
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("seconds")] 
		public CInt32 Seconds
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public SSimpleGameTime()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
