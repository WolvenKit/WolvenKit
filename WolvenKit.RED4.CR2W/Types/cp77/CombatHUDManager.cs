using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CombatHUDManager : gameScriptableComponent
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

		public CombatHUDManager(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
