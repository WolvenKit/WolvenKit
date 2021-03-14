using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TwistConstraint : animAnimNode_OnePoseInput
	{
		private CEnum<animAxis> _frontAxis;
		private animTransformIndex _transformA;
		private animTransformIndex _transformB;
		private CArray<animTwistOutput> _outputs;
		private CBool _debug;

		[Ordinal(12)] 
		[RED("frontAxis")] 
		public CEnum<animAxis> FrontAxis
		{
			get
			{
				if (_frontAxis == null)
				{
					_frontAxis = (CEnum<animAxis>) CR2WTypeManager.Create("animAxis", "frontAxis", cr2w, this);
				}
				return _frontAxis;
			}
			set
			{
				if (_frontAxis == value)
				{
					return;
				}
				_frontAxis = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("transformA")] 
		public animTransformIndex TransformA
		{
			get
			{
				if (_transformA == null)
				{
					_transformA = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "transformA", cr2w, this);
				}
				return _transformA;
			}
			set
			{
				if (_transformA == value)
				{
					return;
				}
				_transformA = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("transformB")] 
		public animTransformIndex TransformB
		{
			get
			{
				if (_transformB == null)
				{
					_transformB = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "transformB", cr2w, this);
				}
				return _transformB;
			}
			set
			{
				if (_transformB == value)
				{
					return;
				}
				_transformB = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("outputs")] 
		public CArray<animTwistOutput> Outputs
		{
			get
			{
				if (_outputs == null)
				{
					_outputs = (CArray<animTwistOutput>) CR2WTypeManager.Create("array:animTwistOutput", "outputs", cr2w, this);
				}
				return _outputs;
			}
			set
			{
				if (_outputs == value)
				{
					return;
				}
				_outputs = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("debug")] 
		public CBool Debug
		{
			get
			{
				if (_debug == null)
				{
					_debug = (CBool) CR2WTypeManager.Create("Bool", "debug", cr2w, this);
				}
				return _debug;
			}
			set
			{
				if (_debug == value)
				{
					return;
				}
				_debug = value;
				PropertySet(this);
			}
		}

		public animAnimNode_TwistConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
