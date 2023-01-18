using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTimePeriod_ConditionType : questITimeConditionType
	{
		[Ordinal(0)] 
		[RED("begin")] 
		public GameTime Begin
		{
			get => GetPropertyValue<GameTime>();
			set => SetPropertyValue<GameTime>(value);
		}

		[Ordinal(1)] 
		[RED("end")] 
		public GameTime End
		{
			get => GetPropertyValue<GameTime>();
			set => SetPropertyValue<GameTime>(value);
		}

		public questTimePeriod_ConditionType()
		{
			Begin = new();
			End = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
