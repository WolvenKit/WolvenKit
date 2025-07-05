using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCameraClippingPlane_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)] 
		[RED("preset")] 
		public CEnum<questCameraPlanesPreset> Preset
		{
			get => GetPropertyValue<CEnum<questCameraPlanesPreset>>();
			set => SetPropertyValue<CEnum<questCameraPlanesPreset>>(value);
		}

		public questCameraClippingPlane_NodeType()
		{
			Preset = Enums.questCameraPlanesPreset.Normal;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
