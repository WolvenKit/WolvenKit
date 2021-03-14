using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SpawnLaserAttackEvent : redEvent
	{
		private CHandle<gamedataAttack_Record> _attackRecord;
		private CFloat _range;
		private CFloat _duration;
		private CInt32 _index;
		private CBool _playSlotAnimation;

		[Ordinal(0)] 
		[RED("attackRecord")] 
		public CHandle<gamedataAttack_Record> AttackRecord
		{
			get
			{
				if (_attackRecord == null)
				{
					_attackRecord = (CHandle<gamedataAttack_Record>) CR2WTypeManager.Create("handle:gamedataAttack_Record", "attackRecord", cr2w, this);
				}
				return _attackRecord;
			}
			set
			{
				if (_attackRecord == value)
				{
					return;
				}
				_attackRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("range")] 
		public CFloat Range
		{
			get
			{
				if (_range == null)
				{
					_range = (CFloat) CR2WTypeManager.Create("Float", "range", cr2w, this);
				}
				return _range;
			}
			set
			{
				if (_range == value)
				{
					return;
				}
				_range = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("index")] 
		public CInt32 Index
		{
			get
			{
				if (_index == null)
				{
					_index = (CInt32) CR2WTypeManager.Create("Int32", "index", cr2w, this);
				}
				return _index;
			}
			set
			{
				if (_index == value)
				{
					return;
				}
				_index = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("playSlotAnimation")] 
		public CBool PlaySlotAnimation
		{
			get
			{
				if (_playSlotAnimation == null)
				{
					_playSlotAnimation = (CBool) CR2WTypeManager.Create("Bool", "playSlotAnimation", cr2w, this);
				}
				return _playSlotAnimation;
			}
			set
			{
				if (_playSlotAnimation == value)
				{
					return;
				}
				_playSlotAnimation = value;
				PropertySet(this);
			}
		}

		public SpawnLaserAttackEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
