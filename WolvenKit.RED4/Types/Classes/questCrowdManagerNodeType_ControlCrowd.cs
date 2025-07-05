using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCrowdManagerNodeType_ControlCrowd : questICrowdManager_NodeType
	{
		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<questControlCrowdAction> Action
		{
			get => GetPropertyValue<CEnum<questControlCrowdAction>>();
			set => SetPropertyValue<CEnum<questControlCrowdAction>>(value);
		}

		[Ordinal(1)] 
		[RED("debugSource")] 
		public CName DebugSource
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("distantCrowdOnly")] 
		public CBool DistantCrowdOnly
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questCrowdManagerNodeType_ControlCrowd()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
