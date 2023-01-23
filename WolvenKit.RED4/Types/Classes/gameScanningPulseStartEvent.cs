using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameScanningPulseStartEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("targetsAffected")] 
		public CInt32 TargetsAffected
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameScanningPulseStartEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
