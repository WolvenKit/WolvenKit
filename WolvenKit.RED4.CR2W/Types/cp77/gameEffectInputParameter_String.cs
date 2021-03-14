using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectInputParameter_String : CVariable
	{
		private CHandle<gameIEffectParameter_StringEvaluator> _evaluator;

		[Ordinal(0)] 
		[RED("evaluator")] 
		public CHandle<gameIEffectParameter_StringEvaluator> Evaluator
		{
			get
			{
				if (_evaluator == null)
				{
					_evaluator = (CHandle<gameIEffectParameter_StringEvaluator>) CR2WTypeManager.Create("handle:gameIEffectParameter_StringEvaluator", "evaluator", cr2w, this);
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

		public gameEffectInputParameter_String(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
