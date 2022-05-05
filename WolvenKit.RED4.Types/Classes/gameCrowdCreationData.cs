using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCrowdCreationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("timePeriods", 4)] 
		public CStatic<gameCrowdPhaseTimePeriod> TimePeriods
		{
			get => GetPropertyValue<CStatic<gameCrowdPhaseTimePeriod>>();
			set => SetPropertyValue<CStatic<gameCrowdPhaseTimePeriod>>(value);
		}

		public gameCrowdCreationData()
		{
			TimePeriods = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
