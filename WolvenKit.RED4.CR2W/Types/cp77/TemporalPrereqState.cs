using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TemporalPrereqState : gamePrereqState
	{
		private CHandle<gameDelaySystem> _delaySystem;
		private CHandle<TemporalPrereqDelayCallback> _callback;
		private CFloat _lapsedTime;
		private gameDelayID _delayID;

		[Ordinal(0)] 
		[RED("delaySystem")] 
		public CHandle<gameDelaySystem> DelaySystem
		{
			get => GetProperty(ref _delaySystem);
			set => SetProperty(ref _delaySystem, value);
		}

		[Ordinal(1)] 
		[RED("callback")] 
		public CHandle<TemporalPrereqDelayCallback> Callback
		{
			get => GetProperty(ref _callback);
			set => SetProperty(ref _callback, value);
		}

		[Ordinal(2)] 
		[RED("lapsedTime")] 
		public CFloat LapsedTime
		{
			get => GetProperty(ref _lapsedTime);
			set => SetProperty(ref _lapsedTime, value);
		}

		[Ordinal(3)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get => GetProperty(ref _delayID);
			set => SetProperty(ref _delayID, value);
		}

		public TemporalPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
