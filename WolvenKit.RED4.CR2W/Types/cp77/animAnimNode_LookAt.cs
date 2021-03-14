using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LookAt : animAnimNode_OnePoseInput
	{
		private animTransformIndex _transform;
		private CEnum<animAxis> _forwardAxis;
		private CBool _useLimits;
		private CEnum<animAxis> _limitAxis;
		private CFloat _limitAngle;
		private animVectorLink _targetNode;
		private animFloatLink _weightNode;

		[Ordinal(12)] 
		[RED("transform")] 
		public animTransformIndex Transform
		{
			get
			{
				if (_transform == null)
				{
					_transform = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "transform", cr2w, this);
				}
				return _transform;
			}
			set
			{
				if (_transform == value)
				{
					return;
				}
				_transform = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("forwardAxis")] 
		public CEnum<animAxis> ForwardAxis
		{
			get
			{
				if (_forwardAxis == null)
				{
					_forwardAxis = (CEnum<animAxis>) CR2WTypeManager.Create("animAxis", "forwardAxis", cr2w, this);
				}
				return _forwardAxis;
			}
			set
			{
				if (_forwardAxis == value)
				{
					return;
				}
				_forwardAxis = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("useLimits")] 
		public CBool UseLimits
		{
			get
			{
				if (_useLimits == null)
				{
					_useLimits = (CBool) CR2WTypeManager.Create("Bool", "useLimits", cr2w, this);
				}
				return _useLimits;
			}
			set
			{
				if (_useLimits == value)
				{
					return;
				}
				_useLimits = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("limitAxis")] 
		public CEnum<animAxis> LimitAxis
		{
			get
			{
				if (_limitAxis == null)
				{
					_limitAxis = (CEnum<animAxis>) CR2WTypeManager.Create("animAxis", "limitAxis", cr2w, this);
				}
				return _limitAxis;
			}
			set
			{
				if (_limitAxis == value)
				{
					return;
				}
				_limitAxis = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("limitAngle")] 
		public CFloat LimitAngle
		{
			get
			{
				if (_limitAngle == null)
				{
					_limitAngle = (CFloat) CR2WTypeManager.Create("Float", "limitAngle", cr2w, this);
				}
				return _limitAngle;
			}
			set
			{
				if (_limitAngle == value)
				{
					return;
				}
				_limitAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("targetNode")] 
		public animVectorLink TargetNode
		{
			get
			{
				if (_targetNode == null)
				{
					_targetNode = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "targetNode", cr2w, this);
				}
				return _targetNode;
			}
			set
			{
				if (_targetNode == value)
				{
					return;
				}
				_targetNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get
			{
				if (_weightNode == null)
				{
					_weightNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "weightNode", cr2w, this);
				}
				return _weightNode;
			}
			set
			{
				if (_weightNode == value)
				{
					return;
				}
				_weightNode = value;
				PropertySet(this);
			}
		}

		public animAnimNode_LookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
