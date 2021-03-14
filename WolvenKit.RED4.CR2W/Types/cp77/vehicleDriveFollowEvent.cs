using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleDriveFollowEvent : redEvent
	{
		private wCHandle<gameObject> _targetObjToFollow;
		private CFloat _distanceMin;
		private CFloat _distanceMax;
		private CBool _stopWhenTargetReached;
		private CBool _useTraffic;

		[Ordinal(0)] 
		[RED("targetObjToFollow")] 
		public wCHandle<gameObject> TargetObjToFollow
		{
			get
			{
				if (_targetObjToFollow == null)
				{
					_targetObjToFollow = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "targetObjToFollow", cr2w, this);
				}
				return _targetObjToFollow;
			}
			set
			{
				if (_targetObjToFollow == value)
				{
					return;
				}
				_targetObjToFollow = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("distanceMin")] 
		public CFloat DistanceMin
		{
			get
			{
				if (_distanceMin == null)
				{
					_distanceMin = (CFloat) CR2WTypeManager.Create("Float", "distanceMin", cr2w, this);
				}
				return _distanceMin;
			}
			set
			{
				if (_distanceMin == value)
				{
					return;
				}
				_distanceMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("distanceMax")] 
		public CFloat DistanceMax
		{
			get
			{
				if (_distanceMax == null)
				{
					_distanceMax = (CFloat) CR2WTypeManager.Create("Float", "distanceMax", cr2w, this);
				}
				return _distanceMax;
			}
			set
			{
				if (_distanceMax == value)
				{
					return;
				}
				_distanceMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("stopWhenTargetReached")] 
		public CBool StopWhenTargetReached
		{
			get
			{
				if (_stopWhenTargetReached == null)
				{
					_stopWhenTargetReached = (CBool) CR2WTypeManager.Create("Bool", "stopWhenTargetReached", cr2w, this);
				}
				return _stopWhenTargetReached;
			}
			set
			{
				if (_stopWhenTargetReached == value)
				{
					return;
				}
				_stopWhenTargetReached = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		public vehicleDriveFollowEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
