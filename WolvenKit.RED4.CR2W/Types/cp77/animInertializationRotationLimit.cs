using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animInertializationRotationLimit : CVariable
	{
		private animTransformIndex _constrainedTransform;
		private animInertializationFloatClamp _limitOnX;
		private animInertializationFloatClamp _limitOnY;
		private animInertializationFloatClamp _limitOnZ;

		[Ordinal(0)] 
		[RED("constrainedTransform")] 
		public animTransformIndex ConstrainedTransform
		{
			get
			{
				if (_constrainedTransform == null)
				{
					_constrainedTransform = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "constrainedTransform", cr2w, this);
				}
				return _constrainedTransform;
			}
			set
			{
				if (_constrainedTransform == value)
				{
					return;
				}
				_constrainedTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("limitOnX")] 
		public animInertializationFloatClamp LimitOnX
		{
			get
			{
				if (_limitOnX == null)
				{
					_limitOnX = (animInertializationFloatClamp) CR2WTypeManager.Create("animInertializationFloatClamp", "limitOnX", cr2w, this);
				}
				return _limitOnX;
			}
			set
			{
				if (_limitOnX == value)
				{
					return;
				}
				_limitOnX = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("limitOnY")] 
		public animInertializationFloatClamp LimitOnY
		{
			get
			{
				if (_limitOnY == null)
				{
					_limitOnY = (animInertializationFloatClamp) CR2WTypeManager.Create("animInertializationFloatClamp", "limitOnY", cr2w, this);
				}
				return _limitOnY;
			}
			set
			{
				if (_limitOnY == value)
				{
					return;
				}
				_limitOnY = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("limitOnZ")] 
		public animInertializationFloatClamp LimitOnZ
		{
			get
			{
				if (_limitOnZ == null)
				{
					_limitOnZ = (animInertializationFloatClamp) CR2WTypeManager.Create("animInertializationFloatClamp", "limitOnZ", cr2w, this);
				}
				return _limitOnZ;
			}
			set
			{
				if (_limitOnZ == value)
				{
					return;
				}
				_limitOnZ = value;
				PropertySet(this);
			}
		}

		public animInertializationRotationLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
