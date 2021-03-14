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
			get
			{
				if (_delaySystem == null)
				{
					_delaySystem = (CHandle<gameDelaySystem>) CR2WTypeManager.Create("handle:gameDelaySystem", "delaySystem", cr2w, this);
				}
				return _delaySystem;
			}
			set
			{
				if (_delaySystem == value)
				{
					return;
				}
				_delaySystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("callback")] 
		public CHandle<TemporalPrereqDelayCallback> Callback
		{
			get
			{
				if (_callback == null)
				{
					_callback = (CHandle<TemporalPrereqDelayCallback>) CR2WTypeManager.Create("handle:TemporalPrereqDelayCallback", "callback", cr2w, this);
				}
				return _callback;
			}
			set
			{
				if (_callback == value)
				{
					return;
				}
				_callback = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lapsedTime")] 
		public CFloat LapsedTime
		{
			get
			{
				if (_lapsedTime == null)
				{
					_lapsedTime = (CFloat) CR2WTypeManager.Create("Float", "lapsedTime", cr2w, this);
				}
				return _lapsedTime;
			}
			set
			{
				if (_lapsedTime == value)
				{
					return;
				}
				_lapsedTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get
			{
				if (_delayID == null)
				{
					_delayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "delayID", cr2w, this);
				}
				return _delayID;
			}
			set
			{
				if (_delayID == value)
				{
					return;
				}
				_delayID = value;
				PropertySet(this);
			}
		}

		public TemporalPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
