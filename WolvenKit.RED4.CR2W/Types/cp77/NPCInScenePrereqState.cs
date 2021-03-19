using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCInScenePrereqState : gamePrereqState
	{
		private CHandle<gameScriptedPrereqSceneInspectionListenerWrapper> _sceneListener;

		[Ordinal(0)] 
		[RED("sceneListener")] 
		public CHandle<gameScriptedPrereqSceneInspectionListenerWrapper> SceneListener
		{
			get => GetProperty(ref _sceneListener);
			set => SetProperty(ref _sceneListener, value);
		}

		public NPCInScenePrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
