using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSceneLocation : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sceneWorldMarkerTag")] 
		public CName SceneWorldMarkerTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
