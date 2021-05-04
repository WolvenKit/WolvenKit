using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SpringDamp : animAnimNode_FloatValue
	{
		private CFloat _massFactor;
		private CFloat _springFactor;
		private CFloat _dampFactor;
		private CBool _startFromDefaultValue;
		private CFloat _defaultInitialValue;
		private CBool _wrapAroundRange;
		private CFloat _rangeMin;
		private CFloat _rangeMax;
		private CFloat _timeStep;
		private animFloatLink _inputNode;

		[Ordinal(11)] 
		[RED("massFactor")] 
		public CFloat MassFactor
		{
			get => GetProperty(ref _massFactor);
			set => SetProperty(ref _massFactor, value);
		}

		[Ordinal(12)] 
		[RED("springFactor")] 
		public CFloat SpringFactor
		{
			get => GetProperty(ref _springFactor);
			set => SetProperty(ref _springFactor, value);
		}

		[Ordinal(13)] 
		[RED("dampFactor")] 
		public CFloat DampFactor
		{
			get => GetProperty(ref _dampFactor);
			set => SetProperty(ref _dampFactor, value);
		}

		[Ordinal(14)] 
		[RED("startFromDefaultValue")] 
		public CBool StartFromDefaultValue
		{
			get => GetProperty(ref _startFromDefaultValue);
			set => SetProperty(ref _startFromDefaultValue, value);
		}

		[Ordinal(15)] 
		[RED("defaultInitialValue")] 
		public CFloat DefaultInitialValue
		{
			get => GetProperty(ref _defaultInitialValue);
			set => SetProperty(ref _defaultInitialValue, value);
		}

		[Ordinal(16)] 
		[RED("wrapAroundRange")] 
		public CBool WrapAroundRange
		{
			get => GetProperty(ref _wrapAroundRange);
			set => SetProperty(ref _wrapAroundRange, value);
		}

		[Ordinal(17)] 
		[RED("rangeMin")] 
		public CFloat RangeMin
		{
			get => GetProperty(ref _rangeMin);
			set => SetProperty(ref _rangeMin, value);
		}

		[Ordinal(18)] 
		[RED("rangeMax")] 
		public CFloat RangeMax
		{
			get => GetProperty(ref _rangeMax);
			set => SetProperty(ref _rangeMax, value);
		}

		[Ordinal(19)] 
		[RED("timeStep")] 
		public CFloat TimeStep
		{
			get => GetProperty(ref _timeStep);
			set => SetProperty(ref _timeStep, value);
		}

		[Ordinal(20)] 
		[RED("inputNode")] 
		public animFloatLink InputNode
		{
			get => GetProperty(ref _inputNode);
			set => SetProperty(ref _inputNode, value);
		}

		public animAnimNode_SpringDamp(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
