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
			get => GetProperty(ref _firstInput);
			set => SetProperty(ref _firstInput, value);
		}

		[Ordinal(12)] 
		[RED("secondInput")] 
		public animVectorLink SecondInput
		{
			get => GetProperty(ref _secondInput);
			set => SetProperty(ref _secondInput, value);
		}

		[Ordinal(13)] 
		[RED("weight")] 
		public animFloatLink Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		public animAnimNode_VectorInterpolation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
