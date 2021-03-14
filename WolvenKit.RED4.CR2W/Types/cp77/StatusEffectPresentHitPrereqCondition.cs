using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatusEffectPresentHitPrereqCondition : BaseHitPrereqCondition
	{
		private CName _checkType;
		private CName _statusEffectParam;
		private CName _tag;
		private CName _objectToCheck;

		[Ordinal(1)] 
		[RED("checkType")] 
		public CName CheckType
		{
			get
			{
				if (_checkType == null)
				{
					_checkType = (CName) CR2WTypeManager.Create("CName", "checkType", cr2w, this);
				}
				return _checkType;
			}
			set
			{
				if (_checkType == value)
				{
					return;
				}
				_checkType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("statusEffectParam")] 
		public CName StatusEffectParam
		{
			get
			{
				if (_statusEffectParam == null)
				{
					_statusEffectParam = (CName) CR2WTypeManager.Create("CName", "statusEffectParam", cr2w, this);
				}
				return _statusEffectParam;
			}
			set
			{
				if (_statusEffectParam == value)
				{
					return;
				}
				_statusEffectParam = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("tag")] 
		public CName Tag
		{
			get
			{
				if (_tag == null)
				{
					_tag = (CName) CR2WTypeManager.Create("CName", "tag", cr2w, this);
				}
				return _tag;
			}
			set
			{
				if (_tag == value)
				{
					return;
				}
				_tag = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("objectToCheck")] 
		public CName ObjectToCheck
		{
			get
			{
				if (_objectToCheck == null)
				{
					_objectToCheck = (CName) CR2WTypeManager.Create("CName", "objectToCheck", cr2w, this);
				}
				return _objectToCheck;
			}
			set
			{
				if (_objectToCheck == value)
				{
					return;
				}
				_objectToCheck = value;
				PropertySet(this);
			}
		}

		public StatusEffectPresentHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
