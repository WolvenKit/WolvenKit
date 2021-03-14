using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileFollowTrajectoryParams : gameprojectileTrajectoryParams
	{
		private CFloat _startVel;
		private wCHandle<gameObject> _target;
		private wCHandle<entIPlacedComponent> _targetComponent;
		private CFloat _accuracy;
		private Vector4 _targetOffset;

		[Ordinal(0)] 
		[RED("startVel")] 
		public CFloat StartVel
		{
			get
			{
				if (_startVel == null)
				{
					_startVel = (CFloat) CR2WTypeManager.Create("Float", "startVel", cr2w, this);
				}
				return _startVel;
			}
			set
			{
				if (_startVel == value)
				{
					return;
				}
				_startVel = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("targetComponent")] 
		public wCHandle<entIPlacedComponent> TargetComponent
		{
			get
			{
				if (_targetComponent == null)
				{
					_targetComponent = (wCHandle<entIPlacedComponent>) CR2WTypeManager.Create("whandle:entIPlacedComponent", "targetComponent", cr2w, this);
				}
				return _targetComponent;
			}
			set
			{
				if (_targetComponent == value)
				{
					return;
				}
				_targetComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("accuracy")] 
		public CFloat Accuracy
		{
			get
			{
				if (_accuracy == null)
				{
					_accuracy = (CFloat) CR2WTypeManager.Create("Float", "accuracy", cr2w, this);
				}
				return _accuracy;
			}
			set
			{
				if (_accuracy == value)
				{
					return;
				}
				_accuracy = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("targetOffset")] 
		public Vector4 TargetOffset
		{
			get
			{
				if (_targetOffset == null)
				{
					_targetOffset = (Vector4) CR2WTypeManager.Create("Vector4", "targetOffset", cr2w, this);
				}
				return _targetOffset;
			}
			set
			{
				if (_targetOffset == value)
				{
					return;
				}
				_targetOffset = value;
				PropertySet(this);
			}
		}

		public gameprojectileFollowTrajectoryParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
