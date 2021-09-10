using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectInputParameter_Bool : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("evaluator")] 
		public CHandle<gameIEffectParameter_BoolEvaluator> Evaluator
		{
			get => GetPropertyValue<CHandle<gameIEffectParameter_BoolEvaluator>>();
			set => SetPropertyValue<CHandle<gameIEffectParameter_BoolEvaluator>>(value);
		}
	}
}
