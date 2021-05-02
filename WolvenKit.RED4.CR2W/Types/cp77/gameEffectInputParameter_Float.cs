using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectInputParameter_Float : CVariable
	{
		private CHandle<gameIEffectParameter_FloatEvaluator> _evaluator;

		[Ordinal(0)] 
		[RED("evaluator")] 
		public CHandle<gameIEffectParameter_FloatEvaluator> Evaluator
		{
			get => GetProperty(ref _evaluator);
			set => SetProperty(ref _evaluator, value);
		}

		public gameEffectInputParameter_Float(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
