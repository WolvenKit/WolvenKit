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
			get
			{
				if (_switchButtonPushed == null)
				{
					_switchButtonPushed = (CBool) CR2WTypeManager.Create("Bool", "switchButtonPushed", cr2w, this);
				}
				return _switchButtonPushed;
			}
			set
			{
				if (_switchButtonPushed == value)
				{
					return;
				}
				_switchButtonPushed = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("cyclePushed")] 
		public CBool CyclePushed
		{
			get
			{
				if (_cyclePushed == null)
				{
					_cyclePushed = (CBool) CR2WTypeManager.Create("Bool", "cyclePushed", cr2w, this);
				}
				return _cyclePushed;
			}
			set
			{
				if (_cyclePushed == value)
				{
					return;
				}
				_cyclePushed = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get
			{
				if (_delay == null)
				{
					_delay = (CFloat) CR2WTypeManager.Create("Float", "delay", cr2w, this);
				}
				return _delay;
			}
			set
			{
				if (_delay == value)
				{
					return;
				}
				_delay = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("cycleBlock")] 
		public CFloat CycleBlock
		{
			get
			{
				if (_cycleBlock == null)
				{
					_cycleBlock = (CFloat) CR2WTypeManager.Create("Float", "cycleBlock", cr2w, this);
				}
				return _cycleBlock;
			}
			set
			{
				if (_cycleBlock == value)
				{
					return;
				}
				_cycleBlock = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("switchPending")] 
		public CBool SwitchPending
		{
			get
			{
				if (_switchPending == null)
				{
					_switchPending = (CBool) CR2WTypeManager.Create("Bool", "switchPending", cr2w, this);
				}
				return _switchPending;
			}
			set
			{
				if (_switchPending == value)
				{
					return;
				}
				_switchPending = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("counter")] 
		public CInt32 Counter
		{
			get
			{
				if (_counter == null)
				{
					_counter = (CInt32) CR2WTypeManager.Create("Int32", "counter", cr2w, this);
				}
				return _counter;
			}
			set
			{
				if (_counter == value)
				{
					return;
				}
				_counter = value;
				PropertySet(this);
			}
		}

		public UpperBodyEventsTransition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
