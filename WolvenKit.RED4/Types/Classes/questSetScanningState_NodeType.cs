using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSetScanningState_NodeType : questIVisionModeNodeType
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<questScanningState> State
		{
			get => GetPropertyValue<CEnum<questScanningState>>();
			set => SetPropertyValue<CEnum<questScanningState>>(value);
		}

		public questSetScanningState_NodeType()
		{
			ObjectRef = new gameEntityReference { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
