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
			get => GetProperty(ref _nameRef);
			set => SetProperty(ref _nameRef, value);
		}

		[Ordinal(2)] 
		[RED("ConditionDataListRef")] 
		public inkCompoundWidgetReference ConditionDataListRef
		{
			get => GetProperty(ref _conditionDataListRef);
			set => SetProperty(ref _conditionDataListRef, value);
		}

		[Ordinal(3)] 
		[RED("ConditionDataItems")] 
		public CArray<wCHandle<inkWidget>> ConditionDataItems
		{
			get => GetProperty(ref _conditionDataItems);
			set => SetProperty(ref _conditionDataItems, value);
		}

		[Ordinal(4)] 
		[RED("ConditionDataItemName")] 
		public CName ConditionDataItemName
		{
			get => GetProperty(ref _conditionDataItemName);
			set => SetProperty(ref _conditionDataItemName, value);
		}

		[Ordinal(5)] 
		[RED("PassedStateName")] 
		public CName PassedStateName
		{
			get => GetProperty(ref _passedStateName);
			set => SetProperty(ref _passedStateName, value);
		}

		[Ordinal(6)] 
		[RED("FailedStateName")] 
		public CName FailedStateName
		{
			get => GetProperty(ref _failedStateName);
			set => SetProperty(ref _failedStateName, value);
		}

		public ScannerSkillCheckItemLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
