using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCInScenePrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("sceneListener")] 
		public CHandle<gameScriptedPrereqSceneInspectionListenerWrapper> SceneListener
		{
			get => GetPropertyValue<CHandle<gameScriptedPrereqSceneInspectionListenerWrapper>>();
			set => SetPropertyValue<CHandle<gameScriptedPrereqSceneInspectionListenerWrapper>>(value);
		}

		public NPCInScenePrereqState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
