using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameReplicatedContinuousAttack : CVariable
	{
		private netTime _startTimeStamp;
		private netTime _stopTimeStamp;
		private TweakDBID _attackId;

		[Ordinal(0)] 
		[RED("startTimeStamp")] 
		public netTime StartTimeStamp
		{
			get
			{
				if (_startTimeStamp == null)
				{
					_startTimeStamp = (netTime) CR2WTypeManager.Create("netTime", "startTimeStamp", cr2w, this);
				}
				return _startTimeStamp;
			}
			set
			{
				if (_startTimeStamp == value)
				{
					return;
				}
				_startTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("stopTimeStamp")] 
		public netTime StopTimeStamp
		{
			get
			{
				if (_stopTimeStamp == null)
				{
					_stopTimeStamp = (netTime) CR2WTypeManager.Create("netTime", "stopTimeStamp", cr2w, this);
				}
				return _stopTimeStamp;
			}
			set
			{
				if (_stopTimeStamp == value)
				{
					return;
				}
				_stopTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public gameReplicatedContinuousAttack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
