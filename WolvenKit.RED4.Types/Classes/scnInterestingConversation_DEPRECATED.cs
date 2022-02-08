using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnInterestingConversation_DEPRECATED : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sceneFilename")] 
		public CResourceAsyncReference<scnSceneResource> SceneFilename
		{
			get => GetPropertyValue<CResourceAsyncReference<scnSceneResource>>();
			set => SetPropertyValue<CResourceAsyncReference<scnSceneResource>>(value);
		}
	}
}
