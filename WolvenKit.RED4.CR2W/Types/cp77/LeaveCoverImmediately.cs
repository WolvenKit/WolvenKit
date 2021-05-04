using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LeaveCoverImmediately : AIbehaviortaskScript
	{
		private CFloat _delay;
		private CBool _completeOnLeave;
		private CFloat _timeStamp;
		private CBool _triggered;

		[Ordinal(0)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		[Ordinal(1)] 
		[RED("completeOnLeave")] 
		public CBool CompleteOnLeave
		{
			get => GetProperty(ref _completeOnLeave);
			set => SetProperty(ref _completeOnLeave, value);
		}

		[Ordinal(2)] 
		[RED("timeStamp")] 
		public CFloat TimeStamp
		{
			get => GetProperty(ref _timeStamp);
			set => SetProperty(ref _timeStamp, value);
		}

		[Ordinal(3)] 
		[RED("triggered")] 
		public CBool Triggered
		{
			get => GetProperty(ref _triggered);
			set => SetProperty(ref _triggered, value);
		}

		public LeaveCoverImmediately(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
