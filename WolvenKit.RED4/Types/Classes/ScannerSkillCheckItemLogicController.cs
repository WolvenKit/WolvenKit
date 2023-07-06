using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerSkillCheckItemLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("NameRef")] 
		public inkTextWidgetReference NameRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("ConditionDataListRef")] 
		public inkCompoundWidgetReference ConditionDataListRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("ConditionDataItems")] 
		public CArray<CWeakHandle<inkWidget>> ConditionDataItems
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(4)] 
		[RED("ConditionDataItemName")] 
		public CName ConditionDataItemName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("PassedStateName")] 
		public CName PassedStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("FailedStateName")] 
		public CName FailedStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ScannerSkillCheckItemLogicController()
		{
			NameRef = new inkTextWidgetReference();
			ConditionDataListRef = new inkCompoundWidgetReference();
			ConditionDataItems = new();
			ConditionDataItemName = "ConditionDataItem";
			PassedStateName = "Passed";
			FailedStateName = "Failed";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
