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
			get
			{
				if (_sceneListener == null)
				{
					_sceneListener = (CHandle<gameScriptedPrereqSceneInspectionListenerWrapper>) CR2WTypeManager.Create("handle:gameScriptedPrereqSceneInspectionListenerWrapper", "sceneListener", cr2w, this);
				}
				return _sceneListener;
			}
			set
			{
				if (_sceneListener == value)
				{
					return;
				}
				_sceneListener = value;
				PropertySet(this);
			}
		}

		public NPCInScenePrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
