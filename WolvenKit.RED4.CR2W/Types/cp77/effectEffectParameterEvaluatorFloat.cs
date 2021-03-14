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
			get
			{
				if (_evaluator == null)
				{
					_evaluator = (CHandle<IEvaluatorFloat>) CR2WTypeManager.Create("handle:IEvaluatorFloat", "evaluator", cr2w, this);
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

		[Ordinal(2)] 
		[RED("inputParameterIsPostMultiplier")] 
		public CBool InputParameterIsPostMultiplier
		{
			get
			{
				if (_inputParameterIsPostMultiplier == null)
				{
					_inputParameterIsPostMultiplier = (CBool) CR2WTypeManager.Create("Bool", "inputParameterIsPostMultiplier", cr2w, this);
				}
				return _inputParameterIsPostMultiplier;
			}
			set
			{
				if (_inputParameterIsPostMultiplier == value)
				{
					return;
				}
				_inputParameterIsPostMultiplier = value;
				PropertySet(this);
			}
		}

		public effectEffectParameterEvaluatorFloat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
