using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameScanningEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<gameScanningState> State
		{
			get => GetPropertyValue<CEnum<gameScanningState>>();
			set => SetPropertyValue<CEnum<gameScanningState>>(value);
		}

		public gameScanningEvent()
		{
			State = Enums.gameScanningState.Stopped;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
