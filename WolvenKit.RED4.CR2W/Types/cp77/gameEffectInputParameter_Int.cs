using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectInputParameter_Int : CVariable
	{
		private CHandle<gameIEffectParameter_IntEvaluator> _evaluator;

		[Ordinal(0)] 
		[RED("evaluator")] 
		public CHandle<gameIEffectParameter_IntEvaluator> Evaluator
		{
			get
			{
				if (_evaluator == null)
				{
					_evaluator = (CHandle<gameIEffectParameter_IntEvaluator>) CR2WTypeManager.Create("handle:gameIEffectParameter_IntEvaluator", "evaluator", cr2w, this);
				}
				return _evaluator;
			}
			set
			{
				if (_evaluator == value)
				{
					return;
				}
				_evaluator = value;
				PropertySet(this);
			}
		}

		public gameEffectInputParameter_Int(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
