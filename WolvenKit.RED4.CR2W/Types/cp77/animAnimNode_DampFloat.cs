using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_DampFloat : animAnimNode_FloatValue
	{
		private CFloat _defaultIncreaseSpeed;
		private CFloat _defaultDecreaseSpeed;
		private CBool _startFromDefaultValue;
		private CFloat _defaultInitialValue;
		private CBool _wrapAroundRange;
		private CFloat _rangeMin;
		private CFloat _rangeMax;
		private animFloatLink _inputNode;
		private animFloatLink _increaseSpeedNode;
		private animFloatLink _decreaseSpeedNode;

		[Ordinal(11)] 
		[RED("defaultIncreaseSpeed")] 
		public CFloat DefaultIncreaseSpeed
		{
			get => GetProperty(ref _defaultIncreaseSpeed);
			set => SetProperty(ref _defaultIncreaseSpeed, value);
		}

		[Ordinal(12)] 
		[RED("defaultDecreaseSpeed")] 
		public CFloat DefaultDecreaseSpeed
		{
			get => GetProperty(ref _defaultDecreaseSpeed);
			set => SetProperty(ref _defaultDecreaseSpeed, value);
		}

		[Ordinal(13)] 
		[RED("startFromDefaultValue")] 
		public CBool StartFromDefaultValue
		{
			get => GetProperty(ref _startFromDefaultValue);
			set => SetProperty(ref _startFromDefaultValue, value);
		}

		[Ordinal(14)] 
		[RED("defaultInitialValue")] 
		public CFloat DefaultInitialValue
		{
			get => GetProperty(ref _defaultInitialValue);
			set => SetProperty(ref _defaultInitialValue, value);
		}

		[Ordinal(15)] 
		[RED("wrapAroundRange")] 
		public CBool WrapAroundRange
		{
			get => GetProperty(ref _wrapAroundRange);
			set => SetProperty(ref _wrapAroundRange, value);
		}

		[Ordinal(16)] 
		[RED("rangeMin")] 
		public CFloat RangeMin
		{
			get => GetProperty(ref _rangeMin);
			set => SetProperty(ref _rangeMin, value);
		}

		[Ordinal(17)] 
		[RED("rangeMax")] 
		public CFloat RangeMax
		{
			get => GetProperty(ref _rangeMax);
			set => SetProperty(ref _rangeMax, value);
		}

		[Ordinal(18)] 
		[RED("inputNode")] 
		public animFloatLink InputNode
		{
			get => GetProperty(ref _inputNode);
			set => SetProperty(ref _inputNode, value);
		}

		[Ordinal(19)] 
		[RED("increaseSpeedNode")] 
		public animFloatLink IncreaseSpeedNode
		{
			get => GetProperty(ref _increaseSpeedNode);
			set => SetProperty(ref _increaseSpeedNode, value);
		}

		[Ordinal(20)] 
		[RED("decreaseSpeedNode")] 
		public animFloatLink DecreaseSpeedNode
		{
			get => GetProperty(ref _decreaseSpeedNode);
			set => SetProperty(ref _decreaseSpeedNode, value);
		}

		public animAnimNode_DampFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
