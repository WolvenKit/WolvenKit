using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkanimTextInterpolator : inkanimInterpolator
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

		public inkanimTextInterpolator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
