using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatComparator : animAnimNode_FloatValue
	{
		private CFloat _firstValue;
		private CFloat _secondValue;
		private CFloat _trueValue;
		private CFloat _falseValue;
		private CEnum<animEAnimGraphCompareFunc> _operation;
		private animFloatLink _firstInputLink;
		private animFloatLink _secondInputLink;
		private animFloatLink _trueInputLink;
		private animFloatLink _falseInputLink;

		[Ordinal(11)] 
		[RED("firstValue")] 
		public CFloat FirstValue
		{
			get => GetProperty(ref _firstValue);
			set => SetProperty(ref _firstValue, value);
		}

		[Ordinal(12)] 
		[RED("secondValue")] 
		public CFloat SecondValue
		{
			get => GetProperty(ref _secondValue);
			set => SetProperty(ref _secondValue, value);
		}

		[Ordinal(13)] 
		[RED("trueValue")] 
		public CFloat TrueValue
		{
			get => GetProperty(ref _trueValue);
			set => SetProperty(ref _trueValue, value);
		}

		[Ordinal(14)] 
		[RED("falseValue")] 
		public CFloat FalseValue
		{
			get => GetProperty(ref _falseValue);
			set => SetProperty(ref _falseValue, value);
		}

		[Ordinal(15)] 
		[RED("operation")] 
		public CEnum<animEAnimGraphCompareFunc> Operation
		{
			get => GetProperty(ref _operation);
			set => SetProperty(ref _operation, value);
		}

		[Ordinal(16)] 
		[RED("firstInputLink")] 
		public animFloatLink FirstInputLink
		{
			get => GetProperty(ref _firstInputLink);
			set => SetProperty(ref _firstInputLink, value);
		}

		[Ordinal(17)] 
		[RED("secondInputLink")] 
		public animFloatLink SecondInputLink
		{
			get => GetProperty(ref _secondInputLink);
			set => SetProperty(ref _secondInputLink, value);
		}

		[Ordinal(18)] 
		[RED("trueInputLink")] 
		public animFloatLink TrueInputLink
		{
			get => GetProperty(ref _trueInputLink);
			set => SetProperty(ref _trueInputLink, value);
		}

		[Ordinal(19)] 
		[RED("falseInputLink")] 
		public animFloatLink FalseInputLink
		{
			get => GetProperty(ref _falseInputLink);
			set => SetProperty(ref _falseInputLink, value);
		}

		public animAnimNode_FloatComparator(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
