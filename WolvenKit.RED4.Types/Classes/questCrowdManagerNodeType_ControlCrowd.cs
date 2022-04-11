using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
	}
}
