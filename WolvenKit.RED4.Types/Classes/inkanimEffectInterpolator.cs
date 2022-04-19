using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkanimEffectInterpolator : inkanimInterpolator
	{
		[Ordinal(7)] 
		[RED("startValue")] 
		public CFloat StartValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("endValue")] 
		public CFloat EndValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("effectType")] 
		public CEnum<inkEffectType> EffectType
		{
			get => GetPropertyValue<CEnum<inkEffectType>>();
			set => SetPropertyValue<CEnum<inkEffectType>>(value);
		}

		[Ordinal(10)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("paramName")] 
		public CName ParamName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkanimEffectInterpolator()
		{
			InterpolationDirection = Enums.inkanimInterpolationDirection.FromTo;
			EffectName = "";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
