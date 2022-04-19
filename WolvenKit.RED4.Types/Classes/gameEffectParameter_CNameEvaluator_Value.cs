using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectParameter_CNameEvaluator_Value : gameIEffectParameter_CNameEvaluator
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CName Value
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameEffectParameter_CNameEvaluator_Value()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
