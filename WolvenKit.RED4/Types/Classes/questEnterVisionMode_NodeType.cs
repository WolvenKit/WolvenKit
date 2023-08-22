using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEnterVisionMode_NodeType : questIVisionModeNodeType
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("visionModeType")] 
		public CEnum<gameVisionModeType> VisionModeType
		{
			get => GetPropertyValue<CEnum<gameVisionModeType>>();
			set => SetPropertyValue<CEnum<gameVisionModeType>>(value);
		}

		public questEnterVisionMode_NodeType()
		{
			ObjectRef = new gameEntityReference { Names = new() };
			VisionModeType = Enums.gameVisionModeType.Focus;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
