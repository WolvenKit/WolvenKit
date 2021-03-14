using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectInputParameter_Vector : CVariable
	{
		private CHandle<gameIEffectParameter_VectorEvaluator> _evaluator;

		[Ordinal(0)] 
		[RED("evaluator")] 
		public CHandle<gameIEffectParameter_VectorEvaluator> Evaluator
		{
			get
			{
				if (_evaluator == null)
				{
					_evaluator = (CHandle<gameIEffectParameter_VectorEvaluator>) CR2WTypeManager.Create("handle:gameIEffectParameter_VectorEvaluator", "evaluator", cr2w, this);
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

		public gameEffectInputParameter_Vector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
