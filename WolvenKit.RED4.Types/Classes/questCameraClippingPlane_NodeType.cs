using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCameraClippingPlane_NodeType : questISceneManagerNodeType
	{
		private CEnum<questCameraPlanesPreset> _preset;

		[Ordinal(0)] 
		[RED("preset")] 
		public CEnum<questCameraPlanesPreset> Preset
		{
			get => GetProperty(ref _preset);
			set => SetProperty(ref _preset, value);
		}
	}
}
