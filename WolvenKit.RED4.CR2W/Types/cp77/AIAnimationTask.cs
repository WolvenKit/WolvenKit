using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIAnimationTask : AIbehaviortaskScript
	{
		private TweakDBID _record;
		private CHandle<AIArgumentMapping> _animVariation;
		private wCHandle<gamedataAIAction_Record> _actionRecord;
		private CString _actionDebugName;
		private CInt32 _animVariationValue;
		private wCHandle<gamedataAIActionPhase_Record> _phaseRecord;
		private CEnum<EAIActionPhase> _actionPhase;
		private CFloat _phaseActivationTime;
		private CFloat _phaseDuration;

		[Ordinal(0)] 
		[RED("record")] 
		public TweakDBID Record
		{
			get
			{
				if (_record == null)
				{
					_record = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "record", cr2w, this);
				}
				return _record;
			}
			set
			{
				if (_record == value)
				{
					return;
				}
				_record = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("animVariation")] 
		public CHandle<AIArgumentMapping> AnimVariation
		{
			get
			{
				if (_animVariation == null)
				{
					_animVariation = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "animVariation", cr2w, this);
				}
				return _animVariation;
			}
			set
			{
				if (_animVariation == value)
				{
					return;
				}
				_animVariation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("actionRecord")] 
		public wCHandle<gamedataAIAction_Record> ActionRecord
		{
			get
			{
				if (_actionRecord == null)
				{
					_actionRecord = (wCHandle<gamedataAIAction_Record>) CR2WTypeManager.Create("whandle:gamedataAIAction_Record", "actionRecord", cr2w, this);
				}
				return _actionRecord;
			}
			set
			{
				if (_actionRecord == value)
				{
					return;
				}
				_actionRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("actionDebugName")] 
		public CString ActionDebugName
		{
			get
			{
				if (_actionDebugName == null)
				{
					_actionDebugName = (CString) CR2WTypeManager.Create("String", "actionDebugName", cr2w, this);
				}
				return _actionDebugName;
			}
			set
			{
				if (_actionDebugName == value)
				{
					return;
				}
				_actionDebugName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("animVariationValue")] 
		public CInt32 AnimVariationValue
		{
			get
			{
				if (_animVariationValue == null)
				{
					_animVariationValue = (CInt32) CR2WTypeManager.Create("Int32", "animVariationValue", cr2w, this);
				}
				return _animVariationValue;
			}
			set
			{
				if (_animVariationValue == value)
				{
					return;
				}
				_animVariationValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("phaseRecord")] 
		public wCHandle<gamedataAIActionPhase_Record> PhaseRecord
		{
			get
			{
				if (_phaseRecord == null)
				{
					_phaseRecord = (wCHandle<gamedataAIActionPhase_Record>) CR2WTypeManager.Create("whandle:gamedataAIActionPhase_Record", "phaseRecord", cr2w, this);
				}
				return _phaseRecord;
			}
			set
			{
				if (_phaseRecord == value)
				{
					return;
				}
				_phaseRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("actionPhase")] 
		public CEnum<EAIActionPhase> ActionPhase
		{
			get
			{
				if (_actionPhase == null)
				{
					_actionPhase = (CEnum<EAIActionPhase>) CR2WTypeManager.Create("EAIActionPhase", "actionPhase", cr2w, this);
				}
				return _actionPhase;
			}
			set
			{
				if (_actionPhase == value)
				{
					return;
				}
				_actionPhase = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("phaseActivationTime")] 
		public CFloat PhaseActivationTime
		{
			get
			{
				if (_phaseActivationTime == null)
				{
					_phaseActivationTime = (CFloat) CR2WTypeManager.Create("Float", "phaseActivationTime", cr2w, this);
				}
				return _phaseActivationTime;
			}
			set
			{
				if (_phaseActivationTime == value)
				{
					return;
				}
				_phaseActivationTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("phaseDuration")] 
		public CFloat PhaseDuration
		{
			get
			{
				if (_phaseDuration == null)
				{
					_phaseDuration = (CFloat) CR2WTypeManager.Create("Float", "phaseDuration", cr2w, this);
				}
				return _phaseDuration;
			}
			set
			{
				if (_phaseDuration == value)
				{
					return;
				}
				_phaseDuration = value;
				PropertySet(this);
			}
		}

		public AIAnimationTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
