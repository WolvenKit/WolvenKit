using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameReplicatedShotData : CVariable
	{
		private netTime _timeStamp;
		private TweakDBID _attackId;
		private wCHandle<gameObject> _target;
		private Vector3 _targetLocalOffset;

		[Ordinal(0)] 
		[RED("timeStamp")] 
		public netTime TimeStamp
		{
			get
			{
				if (_timeStamp == null)
				{
					_timeStamp = (netTime) CR2WTypeManager.Create("netTime", "timeStamp", cr2w, this);
				}
				return _timeStamp;
			}
			set
			{
				if (_timeStamp == value)
				{
					return;
				}
				_timeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("attackId")] 
		public TweakDBID AttackId
		{
			get
			{
				if (_attackId == null)
				{
					_attackId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "attackId", cr2w, this);
				}
				return _attackId;
			}
			set
			{
				if (_attackId == value)
				{
					return;
				}
				_attackId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("targetLocalOffset")] 
		public Vector3 TargetLocalOffset
		{
			get
			{
				if (_targetLocalOffset == null)
				{
					_targetLocalOffset = (Vector3) CR2WTypeManager.Create("Vector3", "targetLocalOffset", cr2w, this);
				}
				return _targetLocalOffset;
			}
			set
			{
				if (_targetLocalOffset == value)
				{
					return;
				}
				_targetLocalOffset = value;
				PropertySet(this);
			}
		}

		public gameReplicatedShotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
