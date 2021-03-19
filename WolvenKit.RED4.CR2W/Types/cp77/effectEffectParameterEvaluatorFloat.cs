using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectEffectParameterEvaluatorFloat : CVariable
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

		public effectEffectParameterEvaluatorFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
