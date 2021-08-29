using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectEffectParameterEvaluatorFloat : RedBaseClass
	{
		private CHandle<IEvaluatorFloat> _evaluator;
		private CName _inputParameterOverride;
		private CBool _inputParameterIsPostMultiplier;

		[Ordinal(0)] 
		[RED("evaluator")] 
		public CHandle<IEvaluatorFloat> Evaluator
		{
			get => GetProperty(ref _evaluator);
			set => SetProperty(ref _evaluator, value);
		}

		[Ordinal(1)] 
		[RED("inputParameterOverride")] 
		public CName InputParameterOverride
		{
			get => GetProperty(ref _inputParameterOverride);
			set => SetProperty(ref _inputParameterOverride, value);
		}

		[Ordinal(2)] 
		[RED("inputParameterIsPostMultiplier")] 
		public CBool InputParameterIsPostMultiplier
		{
			get => GetProperty(ref _inputParameterIsPostMultiplier);
			set => SetProperty(ref _inputParameterIsPostMultiplier, value);
		}
	}
}
