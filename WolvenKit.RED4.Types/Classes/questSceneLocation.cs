using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSceneLocation : RedBaseClass
	{
		private CName _sceneWorldMarkerTag;

		[Ordinal(0)] 
		[RED("sceneWorldMarkerTag")] 
		public CName SceneWorldMarkerTag
		{
			get => GetProperty(ref _sceneWorldMarkerTag);
			set => SetProperty(ref _sceneWorldMarkerTag, value);
		}
	}
}
