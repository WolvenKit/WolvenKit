using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TransformRotator : animAnimNode_OnePoseInput
	{
		private animTransformIndex _transform;
		private Vector3 _axis;
		private CFloat _valueScale;
		private CBool _clamp;
		private CFloat _angleMin;
		private CFloat _angleMax;
		private animFloatLink _angleValueNode;
		private animFloatLink _angleSpeedNode;

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
		[RED("axis")] 
		public Vector3 Axis
		{
			get
			{
				if (_axis == null)
				{
					_axis = (Vector3) CR2WTypeManager.Create("Vector3", "axis", cr2w, this);
				}
				return _axis;
			}
			set
			{
				if (_axis == value)
				{
					return;
				}
				_axis = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("valueScale")] 
		public CFloat ValueScale
		{
			get
			{
				if (_valueScale == null)
				{
					_valueScale = (CFloat) CR2WTypeManager.Create("Float", "valueScale", cr2w, this);
				}
				return _valueScale;
			}
			set
			{
				if (_valueScale == value)
				{
					return;
				}
				_valueScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("clamp")] 
		public CBool Clamp
		{
			get
			{
				if (_clamp == null)
				{
					_clamp = (CBool) CR2WTypeManager.Create("Bool", "clamp", cr2w, this);
				}
				return _clamp;
			}
			set
			{
				if (_clamp == value)
				{
					return;
				}
				_clamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("angleMin")] 
		public CFloat AngleMin
		{
			get
			{
				if (_angleMin == null)
				{
					_angleMin = (CFloat) CR2WTypeManager.Create("Float", "angleMin", cr2w, this);
				}
				return _angleMin;
			}
			set
			{
				if (_angleMin == value)
				{
					return;
				}
				_angleMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("angleMax")] 
		public CFloat AngleMax
		{
			get
			{
				if (_angleMax == null)
				{
					_angleMax = (CFloat) CR2WTypeManager.Create("Float", "angleMax", cr2w, this);
				}
				return _angleMax;
			}
			set
			{
				if (_angleMax == value)
				{
					return;
				}
				_angleMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("angleValueNode")] 
		public animFloatLink AngleValueNode
		{
			get
			{
				if (_angleValueNode == null)
				{
					_angleValueNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "angleValueNode", cr2w, this);
				}
				return _angleValueNode;
			}
			set
			{
				if (_angleValueNode == value)
				{
					return;
				}
				_angleValueNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("angleSpeedNode")] 
		public animFloatLink AngleSpeedNode
		{
			get
			{
				if (_angleSpeedNode == null)
				{
					_angleSpeedNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "angleSpeedNode", cr2w, this);
				}
				return _angleSpeedNode;
			}
			set
			{
				if (_angleSpeedNode == value)
				{
					return;
				}
				_angleSpeedNode = value;
				PropertySet(this);
			}
		}

		public animAnimNode_TransformRotator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
