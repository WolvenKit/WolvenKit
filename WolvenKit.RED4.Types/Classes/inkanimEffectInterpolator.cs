using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimEffectInterpolator : inkanimInterpolator
	{
		private CFloat _startValue;
		private CFloat _endValue;
		private CEnum<inkEffectType> _effectType;
		private CName _effectName;
		private CName _paramName;

		[Ordinal(7)] 
		[RED("startValue")] 
		public CFloat StartValue
		{
			get => GetProperty(ref _startValue);
			set => SetProperty(ref _startValue, value);
		}

		[Ordinal(8)] 
		[RED("endValue")] 
		public CFloat EndValue
		{
			get => GetProperty(ref _endValue);
			set => SetProperty(ref _endValue, value);
		}

		[Ordinal(9)] 
		[RED("effectType")] 
		public CEnum<inkEffectType> EffectType
		{
			get => GetProperty(ref _effectType);
			set => SetProperty(ref _effectType, value);
		}

		[Ordinal(10)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetProperty(ref _effectName);
			set => SetProperty(ref _effectName, value);
		}

		[Ordinal(11)] 
		[RED("paramName")] 
		public CName ParamName
		{
			get => GetProperty(ref _paramName);
			set => SetProperty(ref _paramName, value);
		}

		public inkanimEffectInterpolator()
		{
			_effectName = "";
		}
	}
}
