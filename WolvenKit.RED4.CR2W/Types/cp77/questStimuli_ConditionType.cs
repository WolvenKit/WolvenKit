using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questStimuli_ConditionType : questISensesConditionType
	{
		private gameEntityReference _instigatorRef;
		private CBool _isPlayerInstigator;
		private gameEntityReference _targetRef;
		private CEnum<gamedataStimType> _type;

		[Ordinal(0)] 
		[RED("instigatorRef")] 
		public gameEntityReference InstigatorRef
		{
			get
			{
				if (_instigatorRef == null)
				{
					_instigatorRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "instigatorRef", cr2w, this);
				}
				return _instigatorRef;
			}
			set
			{
				if (_instigatorRef == value)
				{
					return;
				}
				_instigatorRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isPlayerInstigator")] 
		public CBool IsPlayerInstigator
		{
			get
			{
				if (_isPlayerInstigator == null)
				{
					_isPlayerInstigator = (CBool) CR2WTypeManager.Create("Bool", "isPlayerInstigator", cr2w, this);
				}
				return _isPlayerInstigator;
			}
			set
			{
				if (_isPlayerInstigator == value)
				{
					return;
				}
				_isPlayerInstigator = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targetRef")] 
		public gameEntityReference TargetRef
		{
			get
			{
				if (_targetRef == null)
				{
					_targetRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "targetRef", cr2w, this);
				}
				return _targetRef;
			}
			set
			{
				if (_targetRef == value)
				{
					return;
				}
				_targetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<gamedataStimType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataStimType>) CR2WTypeManager.Create("gamedataStimType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public questStimuli_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
