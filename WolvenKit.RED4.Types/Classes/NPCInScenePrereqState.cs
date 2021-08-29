using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class NPCInScenePrereqState : gamePrereqState
	{
		private CHandle<gameScriptedPrereqSceneInspectionListenerWrapper> _sceneListener;

		[Ordinal(0)] 
		[RED("sceneListener")] 
		public CHandle<gameScriptedPrereqSceneInspectionListenerWrapper> SceneListener
		{
			get => GetProperty(ref _sceneListener);
			set => SetProperty(ref _sceneListener, value);
		}
	}
}
