using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimVariableInt : animAnimVariable
	{
		[Ordinal(1)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("default")] 
		public CInt32 Default
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("min")] 
		public CInt32 Min
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("max")] 
		public CInt32 Max
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public animAnimVariableInt()
		{
			Min = -16;
			Max = 16;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
