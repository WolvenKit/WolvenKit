using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerSkillCheckItemLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _nameRef;
		private inkCompoundWidgetReference _conditionDataListRef;
		private CArray<wCHandle<inkWidget>> _conditionDataItems;
		private CName _conditionDataItemName;
		private CName _passedStateName;
		private CName _failedStateName;

		[Ordinal(1)] 
		[RED("NameRef")] 
		public inkTextWidgetReference NameRef
		{
			get
			{
				if (_nameRef == null)
				{
					_nameRef = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "NameRef", cr2w, this);
				}
				return _nameRef;
			}
			set
			{
				if (_nameRef == value)
				{
					return;
				}
				_nameRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ConditionDataListRef")] 
		public inkCompoundWidgetReference ConditionDataListRef
		{
			get
			{
				if (_conditionDataListRef == null)
				{
					_conditionDataListRef = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "ConditionDataListRef", cr2w, this);
				}
				return _conditionDataListRef;
			}
			set
			{
				if (_conditionDataListRef == value)
				{
					return;
				}
				_conditionDataListRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ConditionDataItems")] 
		public CArray<wCHandle<inkWidget>> ConditionDataItems
		{
			get
			{
				if (_conditionDataItems == null)
				{
					_conditionDataItems = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "ConditionDataItems", cr2w, this);
				}
				return _conditionDataItems;
			}
			set
			{
				if (_conditionDataItems == value)
				{
					return;
				}
				_conditionDataItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ConditionDataItemName")] 
		public CName ConditionDataItemName
		{
			get
			{
				if (_conditionDataItemName == null)
				{
					_conditionDataItemName = (CName) CR2WTypeManager.Create("CName", "ConditionDataItemName", cr2w, this);
				}
				return _conditionDataItemName;
			}
			set
			{
				if (_conditionDataItemName == value)
				{
					return;
				}
				_conditionDataItemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("PassedStateName")] 
		public CName PassedStateName
		{
			get
			{
				if (_passedStateName == null)
				{
					_passedStateName = (CName) CR2WTypeManager.Create("CName", "PassedStateName", cr2w, this);
				}
				return _passedStateName;
			}
			set
			{
				if (_passedStateName == value)
				{
					return;
				}
				_passedStateName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("FailedStateName")] 
		public CName FailedStateName
		{
			get
			{
				if (_failedStateName == null)
				{
					_failedStateName = (CName) CR2WTypeManager.Create("CName", "FailedStateName", cr2w, this);
				}
				return _failedStateName;
			}
			set
			{
				if (_failedStateName == value)
				{
					return;
				}
				_failedStateName = value;
				PropertySet(this);
			}
		}

		public ScannerSkillCheckItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
