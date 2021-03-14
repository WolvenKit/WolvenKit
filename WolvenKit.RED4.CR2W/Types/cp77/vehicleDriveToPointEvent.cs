using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleDriveToPointEvent : redEvent
	{
		private Vector3 _targetPos;
		private CBool _useTraffic;
		private CFloat _speedInTraffic;

		[Ordinal(0)] 
		[RED("targetPos")] 
		public Vector3 TargetPos
		{
			get
			{
				if (_targetPos == null)
				{
					_targetPos = (Vector3) CR2WTypeManager.Create("Vector3", "targetPos", cr2w, this);
				}
				return _targetPos;
			}
			set
			{
				if (_targetPos == value)
				{
					return;
				}
				_targetPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("useTraffic")] 
		public CBool UseTraffic
		{
			get
			{
				if (_useTraffic == null)
				{
					_useTraffic = (CBool) CR2WTypeManager.Create("Bool", "useTraffic", cr2w, this);
				}
				return _useTraffic;
			}
			set
			{
				if (_useTraffic == value)
				{
					return;
				}
				_useTraffic = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("speedInTraffic")] 
		public CFloat SpeedInTraffic
		{
			get
			{
				if (_speedInTraffic == null)
				{
					_speedInTraffic = (CFloat) CR2WTypeManager.Create("Float", "speedInTraffic", cr2w, this);
				}
				return _speedInTraffic;
			}
			set
			{
				if (_speedInTraffic == value)
				{
					return;
				}
				_speedInTraffic = value;
				PropertySet(this);
			}
		}

		public vehicleDriveToPointEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
