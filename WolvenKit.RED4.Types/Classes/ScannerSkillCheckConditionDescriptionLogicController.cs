using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerSkillCheckConditionDescriptionLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("NameRef")] 
		public inkTextWidgetReference NameRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("PassedStateName")] 
		public CName PassedStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("FailedStateName")] 
		public CName FailedStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public ScannerSkillCheckConditionDescriptionLogicController()
		{
			NameRef = new();
			PassedStateName = "Passed";
			FailedStateName = "Failed";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
