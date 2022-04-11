using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectInputParameter_Quat : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("evaluator")] 
		public CHandle<gameIEffectParameter_QuatEvaluator> Evaluator
		{
			get => GetPropertyValue<CHandle<gameIEffectParameter_QuatEvaluator>>();
			set => SetPropertyValue<CHandle<gameIEffectParameter_QuatEvaluator>>(value);
		}
	}
}
