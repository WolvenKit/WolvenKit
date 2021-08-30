using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CombatHUDManager : gameScriptableComponent
	{
		private CBool _isRunning;
		private CArray<CombatTarget> _targets;
		private CFloat _interval;
		private CFloat _timeSinceLastUpdate;

		[Ordinal(5)] 
		[RED("isRunning")] 
		public CBool IsRunning
		{
			get => GetProperty(ref _isRunning);
			set => SetProperty(ref _isRunning, value);
		}

		[Ordinal(6)] 
		[RED("targets")] 
		public CArray<CombatTarget> Targets
		{
			get => GetProperty(ref _targets);
			set => SetProperty(ref _targets, value);
		}

		[Ordinal(7)] 
		[RED("interval")] 
		public CFloat Interval
		{
			get => GetProperty(ref _interval);
			set => SetProperty(ref _interval, value);
		}

		[Ordinal(8)] 
		[RED("timeSinceLastUpdate")] 
		public CFloat TimeSinceLastUpdate
		{
			get => GetProperty(ref _timeSinceLastUpdate);
			set => SetProperty(ref _timeSinceLastUpdate, value);
		}

		public CombatHUDManager()
		{
			_interval = 1.000000F;
		}
	}
}
