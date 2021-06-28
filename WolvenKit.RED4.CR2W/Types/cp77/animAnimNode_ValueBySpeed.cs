using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ValueBySpeed : animAnimNode_FloatValue
	{
		private CFloat _defaultValue;
		private CEnum<animClampType> _clampType;
		private CFloat _rangeMin;
		private CFloat _rangeMax;
		private CBool _resetOnActivation;
		private animFloatLink _speed;

		[Ordinal(11)] 
		[RED("defaultValue")] 
		public CFloat DefaultValue
		{
			get => GetProperty(ref _defaultValue);
			set => SetProperty(ref _defaultValue, value);
		}

		[Ordinal(12)] 
		[RED("clampType")] 
		public CEnum<animClampType> ClampType
		{
			get => GetProperty(ref _clampType);
			set => SetProperty(ref _clampType, value);
		}

		[Ordinal(13)] 
		[RED("rangeMin")] 
		public CFloat RangeMin
		{
			get => GetProperty(ref _rangeMin);
			set => SetProperty(ref _rangeMin, value);
		}

		[Ordinal(14)] 
		[RED("rangeMax")] 
		public CFloat RangeMax
		{
			get => GetProperty(ref _rangeMax);
			set => SetProperty(ref _rangeMax, value);
		}

		[Ordinal(15)] 
		[RED("resetOnActivation")] 
		public CBool ResetOnActivation
		{
			get => GetProperty(ref _resetOnActivation);
			set => SetProperty(ref _resetOnActivation, value);
		}

		[Ordinal(16)] 
		[RED("speed")] 
		public animFloatLink Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		public animAnimNode_ValueBySpeed(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
