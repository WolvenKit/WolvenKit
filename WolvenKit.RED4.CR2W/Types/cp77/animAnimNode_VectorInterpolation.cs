using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_VectorInterpolation : animAnimNode_VectorValue
	{
		private animVectorLink _firstInput;
		private animVectorLink _secondInput;
		private animFloatLink _weight;

		[Ordinal(11)] 
		[RED("firstInput")] 
		public animVectorLink FirstInput
		{
			get
			{
				if (_firstInput == null)
				{
					_firstInput = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "firstInput", cr2w, this);
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

		[Ordinal(12)] 
		[RED("secondInput")] 
		public animVectorLink SecondInput
		{
			get
			{
				if (_secondInput == null)
				{
					_secondInput = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "secondInput", cr2w, this);
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

		[Ordinal(13)] 
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

		public animAnimNode_VectorInterpolation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
