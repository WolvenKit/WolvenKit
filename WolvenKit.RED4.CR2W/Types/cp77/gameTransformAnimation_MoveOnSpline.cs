using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTransformAnimation_MoveOnSpline : gameTransformAnimationTrackItemImpl
	{
		private NodeRef _splineNode;
		private CFloat _from;
		private CFloat _to;
		private CEnum<gameTransformAnimation_MoveOnSplineRotationMode> _rotationMode;
		private CHandle<gameTransformAnimation_Movement> _movement;

		[Ordinal(0)] 
		[RED("splineNode")] 
		public NodeRef SplineNode
		{
			get
			{
				if (_splineNode == null)
				{
					_splineNode = (NodeRef) CR2WTypeManager.Create("NodeRef", "splineNode", cr2w, this);
				}
				return _splineNode;
			}
			set
			{
				if (_splineNode == value)
				{
					return;
				}
				_splineNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("from")] 
		public CFloat From
		{
			get
			{
				if (_from == null)
				{
					_from = (CFloat) CR2WTypeManager.Create("Float", "from", cr2w, this);
				}
				return _from;
			}
			set
			{
				if (_from == value)
				{
					return;
				}
				_from = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("to")] 
		public CFloat To
		{
			get
			{
				if (_to == null)
				{
					_to = (CFloat) CR2WTypeManager.Create("Float", "to", cr2w, this);
				}
				return _to;
			}
			set
			{
				if (_to == value)
				{
					return;
				}
				_to = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("rotationMode")] 
		public CEnum<gameTransformAnimation_MoveOnSplineRotationMode> RotationMode
		{
			get
			{
				if (_rotationMode == null)
				{
					_rotationMode = (CEnum<gameTransformAnimation_MoveOnSplineRotationMode>) CR2WTypeManager.Create("gameTransformAnimation_MoveOnSplineRotationMode", "rotationMode", cr2w, this);
				}
				return _rotationMode;
			}
			set
			{
				if (_rotationMode == value)
				{
					return;
				}
				_rotationMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("movement")] 
		public CHandle<gameTransformAnimation_Movement> Movement
		{
			get
			{
				if (_movement == null)
				{
					_movement = (CHandle<gameTransformAnimation_Movement>) CR2WTypeManager.Create("handle:gameTransformAnimation_Movement", "movement", cr2w, this);
				}
				return _movement;
			}
			set
			{
				if (_movement == value)
				{
					return;
				}
				_movement = value;
				PropertySet(this);
			}
		}

		public gameTransformAnimation_MoveOnSpline(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
