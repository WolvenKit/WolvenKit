using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TransformInterpolation : animAnimNode_TransformValue
	{
		private CEnum<animQuaternionInterpolationType> _interpolationType;
		private animTransformLink _firstInput;
		private animTransformLink _secondInput;
		private animFloatLink _weight;

		[Ordinal(11)] 
		[RED("interpolationType")] 
		public CEnum<animQuaternionInterpolationType> InterpolationType
		{
			get
			{
				if (_interpolationType == null)
				{
					_interpolationType = (CEnum<animQuaternionInterpolationType>) CR2WTypeManager.Create("animQuaternionInterpolationType", "interpolationType", cr2w, this);
				}
				return _interpolationType;
			}
			set
			{
				if (_interpolationType == value)
				{
					return;
				}
				_interpolationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("firstInput")] 
		public animTransformLink FirstInput
		{
			get
			{
				if (_firstInput == null)
				{
					_firstInput = (animTransformLink) CR2WTypeManager.Create("animTransformLink", "firstInput", cr2w, this);
				}
				return _firstInput;
			}
			set
			{
				if (_firstInput == value)
				{
					return;
				}
				_firstInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("secondInput")] 
		public animTransformLink SecondInput
		{
			get
			{
				if (_secondInput == null)
				{
					_secondInput = (animTransformLink) CR2WTypeManager.Create("animTransformLink", "secondInput", cr2w, this);
				}
				return _secondInput;
			}
			set
			{
				if (_secondInput == value)
				{
					return;
				}
				_secondInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("weight")] 
		public animFloatLink Weight
		{
			get
			{
				if (_weight == null)
				{
					_weight = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "weight", cr2w, this);
				}
				return _weight;
			}
			set
			{
				if (_weight == value)
				{
					return;
				}
				_weight = value;
				PropertySet(this);
			}
		}

		public animAnimNode_TransformInterpolation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
