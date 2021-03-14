using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericHitPrereq : gameIScriptablePrereq
	{
		private CBool _isSync;
		private CEnum<gameDamageCallbackType> _callbackType;
		private CEnum<gameDamagePipelineStage> _pipelineStage;
		private CEnum<gamedataAttackType> _attackType;
		private CArray<CHandle<BaseHitPrereqCondition>> _conditions;

		[Ordinal(0)] 
		[RED("isSync")] 
		public CBool IsSync
		{
			get
			{
				if (_isSync == null)
				{
					_isSync = (CBool) CR2WTypeManager.Create("Bool", "isSync", cr2w, this);
				}
				return _isSync;
			}
			set
			{
				if (_isSync == value)
				{
					return;
				}
				_isSync = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("callbackType")] 
		public CEnum<gameDamageCallbackType> CallbackType
		{
			get
			{
				if (_callbackType == null)
				{
					_callbackType = (CEnum<gameDamageCallbackType>) CR2WTypeManager.Create("gameDamageCallbackType", "callbackType", cr2w, this);
				}
				return _callbackType;
			}
			set
			{
				if (_callbackType == value)
				{
					return;
				}
				_callbackType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("pipelineStage")] 
		public CEnum<gameDamagePipelineStage> PipelineStage
		{
			get
			{
				if (_pipelineStage == null)
				{
					_pipelineStage = (CEnum<gameDamagePipelineStage>) CR2WTypeManager.Create("gameDamagePipelineStage", "pipelineStage", cr2w, this);
				}
				return _pipelineStage;
			}
			set
			{
				if (_pipelineStage == value)
				{
					return;
				}
				_pipelineStage = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("attackType")] 
		public CEnum<gamedataAttackType> AttackType
		{
			get
			{
				if (_attackType == null)
				{
					_attackType = (CEnum<gamedataAttackType>) CR2WTypeManager.Create("gamedataAttackType", "attackType", cr2w, this);
				}
				return _attackType;
			}
			set
			{
				if (_attackType == value)
				{
					return;
				}
				_attackType = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("conditions")] 
		public CArray<CHandle<BaseHitPrereqCondition>> Conditions
		{
			get
			{
				if (_conditions == null)
				{
					_conditions = (CArray<CHandle<BaseHitPrereqCondition>>) CR2WTypeManager.Create("array:handle:BaseHitPrereqCondition", "conditions", cr2w, this);
				}
				return _conditions;
			}
			set
			{
				if (_conditions == value)
				{
					return;
				}
				_conditions = value;
				PropertySet(this);
			}
		}

		public GenericHitPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
