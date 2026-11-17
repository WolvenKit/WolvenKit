using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CEvaluatorColorConst : IEvaluatorColor
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CColor Value
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public CEvaluatorColorConst()
		{
			Value = new CColor { Red = 255, Green = 255, Blue = 255, Alpha = 255 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
