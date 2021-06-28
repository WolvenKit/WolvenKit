using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectEffectParameterEvaluatorColor : CVariable
	{
		private CHandle<IEvaluatorColor> _evaluator;
		private CName _inputParameterOverride;

		[Ordinal(0)] 
		[RED("evaluator")] 
		public CHandle<IEvaluatorColor> Evaluator
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

		public effectEffectParameterEvaluatorColor(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
