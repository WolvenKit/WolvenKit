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
			get => GetProperty(ref _interpolationType);
			set => SetProperty(ref _interpolationType, value);
		}

		[Ordinal(12)] 
		[RED("firstInput")] 
		public animTransformLink FirstInput
		{
			get => GetProperty(ref _firstInput);
			set => SetProperty(ref _firstInput, value);
		}

		[Ordinal(13)] 
		[RED("secondInput")] 
		public animTransformLink SecondInput
		{
			get => GetProperty(ref _secondInput);
			set => SetProperty(ref _secondInput, value);
		}

		[Ordinal(14)] 
		[RED("weight")] 
		public animFloatLink Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		public animAnimNode_TransformInterpolation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
