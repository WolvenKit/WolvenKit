using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleDriveToNodeRefEvent : redEvent
	{
		private NodeRef _targetRef;
		private CBool _useTraffic;
		private CFloat _speedInTraffic;

		[Ordinal(0)] 
		[RED("targetRef")] 
		public NodeRef TargetRef
		{
			get
			{
				if (_targetRef == null)
				{
					_targetRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "targetRef", cr2w, this);
				}
				return _targetRef;
			}
			set
			{
				if (_targetRef == value)
				{
					return;
				}
				_targetRef = value;
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

		public vehicleDriveToNodeRefEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
