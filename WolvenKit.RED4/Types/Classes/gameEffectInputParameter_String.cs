using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectInputParameter_String : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("evaluator")] 
		public CHandle<gameIEffectParameter_StringEvaluator> Evaluator
		{
			get => GetPropertyValue<CHandle<gameIEffectParameter_StringEvaluator>>();
			set => SetPropertyValue<CHandle<gameIEffectParameter_StringEvaluator>>(value);
		}

		public gameEffectInputParameter_String()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
