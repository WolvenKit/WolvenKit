using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DamageHistoryEntry : CVariable
	{
		private CHandle<gameeventsHitEvent> _hitEvent;
		private CFloat _totalDamageReceived;
		private CUInt64 _frameReceived;
		private CFloat _timestamp;
		private CFloat _healthAtTheTime;
		private wCHandle<gameObject> _source;
		private wCHandle<gameObject> _target;

		[Ordinal(0)] 
		[RED("hitEvent")] 
		public CHandle<gameeventsHitEvent> HitEvent
		{
			get
			{
				if (_hitEvent == null)
				{
					_hitEvent = (CHandle<gameeventsHitEvent>) CR2WTypeManager.Create("handle:gameeventsHitEvent", "hitEvent", cr2w, this);
				}
				return _hitEvent;
			}
			set
			{
				if (_hitEvent == value)
				{
					return;
				}
				_hitEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("totalDamageReceived")] 
		public CFloat TotalDamageReceived
		{
			get
			{
				if (_totalDamageReceived == null)
				{
					_totalDamageReceived = (CFloat) CR2WTypeManager.Create("Float", "totalDamageReceived", cr2w, this);
				}
				return _totalDamageReceived;
			}
			set
			{
				if (_totalDamageReceived == value)
				{
					return;
				}
				_totalDamageReceived = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("frameReceived")] 
		public CUInt64 FrameReceived
		{
			get
			{
				if (_frameReceived == null)
				{
					_frameReceived = (CUInt64) CR2WTypeManager.Create("Uint64", "frameReceived", cr2w, this);
				}
				return _frameReceived;
			}
			set
			{
				if (_frameReceived == value)
				{
					return;
				}
				_frameReceived = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("timestamp")] 
		public CFloat Timestamp
		{
			get
			{
				if (_timestamp == null)
				{
					_timestamp = (CFloat) CR2WTypeManager.Create("Float", "timestamp", cr2w, this);
				}
				return _timestamp;
			}
			set
			{
				if (_timestamp == value)
				{
					return;
				}
				_timestamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("healthAtTheTime")] 
		public CFloat HealthAtTheTime
		{
			get
			{
				if (_healthAtTheTime == null)
				{
					_healthAtTheTime = (CFloat) CR2WTypeManager.Create("Float", "healthAtTheTime", cr2w, this);
				}
				return _healthAtTheTime;
			}
			set
			{
				if (_healthAtTheTime == value)
				{
					return;
				}
				_healthAtTheTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("source")] 
		public wCHandle<gameObject> Source
		{
			get
			{
				if (_source == null)
				{
					_source = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "source", cr2w, this);
				}
				return _source;
			}
			set
			{
				if (_source == value)
				{
					return;
				}
				_source = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		public DamageHistoryEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
