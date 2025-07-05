using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSwitchToScenario_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("startScenarioName")] 
		public CName StartScenarioName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("endScenarioName")] 
		public CName EndScenarioName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("userData")] 
		public CHandle<inkUserData> UserData
		{
			get => GetPropertyValue<CHandle<inkUserData>>();
			set => SetPropertyValue<CHandle<inkUserData>>(value);
		}

		[Ordinal(3)] 
		[RED("forceOpenDuringFadeout")] 
		public CBool ForceOpenDuringFadeout
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questSwitchToScenario_NodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
