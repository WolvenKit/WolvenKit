using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UpperBodyEventsTransition : UpperBodyTransition
	{
		private CBool _switchButtonPushed;
		private CBool _cyclePushed;
		private CFloat _delay;
		private CFloat _cycleBlock;
		private CBool _switchPending;
		private CInt32 _counter;

		[Ordinal(0)] 
		[RED("switchButtonPushed")] 
		public CBool SwitchButtonPushed
		{
			get => GetProperty(ref _switchButtonPushed);
			set => SetProperty(ref _switchButtonPushed, value);
		}

		[Ordinal(1)] 
		[RED("cyclePushed")] 
		public CBool CyclePushed
		{
			get => GetProperty(ref _cyclePushed);
			set => SetProperty(ref _cyclePushed, value);
		}

		[Ordinal(2)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		[Ordinal(3)] 
		[RED("cycleBlock")] 
		public CFloat CycleBlock
		{
			get => GetProperty(ref _cycleBlock);
			set => SetProperty(ref _cycleBlock, value);
		}

		[Ordinal(4)] 
		[RED("switchPending")] 
		public CBool SwitchPending
		{
			get => GetProperty(ref _switchPending);
			set => SetProperty(ref _switchPending, value);
		}

		[Ordinal(5)] 
		[RED("counter")] 
		public CInt32 Counter
		{
			get => GetProperty(ref _counter);
			set => SetProperty(ref _counter, value);
		}

		public UpperBodyEventsTransition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
