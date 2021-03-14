using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorPredictTargetMovementDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _target;
		private CHandle<AIArgumentMapping> _timeInterval;
		private CHandle<AIArgumentMapping> _result;

		[Ordinal(1)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("timeInterval")] 
		public CHandle<AIArgumentMapping> TimeInterval
		{
			get
			{
				if (_timeInterval == null)
				{
					_timeInterval = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "timeInterval", cr2w, this);
				}
				return _timeInterval;
			}
			set
			{
				if (_timeInterval == value)
				{
					return;
				}
				_timeInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("result")] 
		public CHandle<AIArgumentMapping> Result
		{
			get
			{
				if (_result == null)
				{
					_result = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "result", cr2w, this);
				}
				return _result;
			}
			set
			{
				if (_result == value)
				{
					return;
				}
				_result = value;
				PropertySet(this);
			}
		}

		public AIbehaviorPredictTargetMovementDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
