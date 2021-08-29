using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCrowdCreationData : RedBaseClass
	{
		private CStatic<gameCrowdPhaseTimePeriod> _timePeriods;

		[Ordinal(0)] 
		[RED("timePeriods", 4)] 
		public CStatic<gameCrowdPhaseTimePeriod> TimePeriods
		{
			get => GetProperty(ref _timePeriods);
			set => SetProperty(ref _timePeriods, value);
		}
	}
}
