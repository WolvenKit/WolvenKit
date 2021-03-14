using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectEffectParameterEvaluatorVector : CVariable
	{
		private CHandle<IEvaluatorVector> _evaluator;
		private CName _inputParameterOverride;

		[Ordinal(0)] 
		[RED("evaluator")] 
		public CHandle<IEvaluatorVector> Evaluator
		{
			get
			{
				if (_evaluator == null)
				{
					_evaluator = (CHandle<IEvaluatorVector>) CR2WTypeManager.Create("handle:IEvaluatorVector", "evaluator", cr2w, this);
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

		[Ordinal(1)] 
		[RED("inputParameterOverride")] 
		public CName InputParameterOverride
		{
			get
			{
				if (_inputParameterOverride == null)
				{
					_inputParameterOverride = (CName) CR2WTypeManager.Create("CName", "inputParameterOverride", cr2w, this);
				}
				return _inputParameterOverride;
			}
			set
			{
				if (_inputParameterOverride == value)
				{
					return;
				}
				_inputParameterOverride = value;
				PropertySet(this);
			}
		}

		public effectEffectParameterEvaluatorVector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
