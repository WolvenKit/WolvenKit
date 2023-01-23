using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectInputParameter_CName : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("evaluator")] 
		public CHandle<gameIEffectParameter_CNameEvaluator> Evaluator
		{
			get => GetPropertyValue<CHandle<gameIEffectParameter_CNameEvaluator>>();
			set => SetPropertyValue<CHandle<gameIEffectParameter_CNameEvaluator>>(value);
		}

		public gameEffectInputParameter_CName()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
