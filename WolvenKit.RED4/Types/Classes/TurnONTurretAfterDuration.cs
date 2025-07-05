using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TurnONTurretAfterDuration : redEvent
	{
		[Ordinal(0)] 
		[RED("duration")] 
		public CInt32 Duration
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public TurnONTurretAfterDuration()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
