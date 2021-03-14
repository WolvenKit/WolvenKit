using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNodeSourceChannel_OrientationVector : animIAnimNodeSourceChannel_Vector
	{
		private animTransformIndex _transformIndex;
		private animTransformIndex _inputTransformIndex;
		private Vector3 _up;

		[Ordinal(0)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get
			{
				if (_transformIndex == null)
				{
					_transformIndex = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "transformIndex", cr2w, this);
				}
				return _transformIndex;
			}
			set
			{
				if (_transformIndex == value)
				{
					return;
				}
				_transformIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("inputTransformIndex")] 
		public animTransformIndex InputTransformIndex
		{
			get
			{
				if (_inputTransformIndex == null)
				{
					_inputTransformIndex = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "inputTransformIndex", cr2w, this);
				}
				return _inputTransformIndex;
			}
			set
			{
				if (_inputTransformIndex == value)
				{
					return;
				}
				_inputTransformIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("up")] 
		public Vector3 Up
		{
			get
			{
				if (_up == null)
				{
					_up = (Vector3) CR2WTypeManager.Create("Vector3", "up", cr2w, this);
				}
				return _up;
			}
			set
			{
				if (_up == value)
				{
					return;
				}
				_up = value;
				PropertySet(this);
			}
		}

		public animAnimNodeSourceChannel_OrientationVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
