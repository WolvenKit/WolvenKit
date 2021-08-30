using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerCombatStateTimePrereq : gameIScriptablePrereq
	{
		private CFloat _minTime;
		private CFloat _maxTime;

		[Ordinal(0)] 
		[RED("minTime")] 
		public CFloat MinTime
		{
			get => GetProperty(ref _minTime);
			set => SetProperty(ref _minTime, value);
		}

		[Ordinal(1)] 
		[RED("maxTime")] 
		public CFloat MaxTime
		{
			get => GetProperty(ref _maxTime);
			set => SetProperty(ref _maxTime, value);
		}

		public PlayerCombatStateTimePrereq()
		{
			_minTime = -1.000000F;
			_maxTime = -1.000000F;
		}
	}
}
