using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnInterestingConversation_DEPRECATED : RedBaseClass
	{
		private CResourceAsyncReference<scnSceneResource> _sceneFilename;

		[Ordinal(0)] 
		[RED("sceneFilename")] 
		public CResourceAsyncReference<scnSceneResource> SceneFilename
		{
			get => GetProperty(ref _sceneFilename);
			set => SetProperty(ref _sceneFilename, value);
		}
	}
}
