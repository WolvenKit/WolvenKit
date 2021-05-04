using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnScenesVersionsSceneChanges : CVariable
	{
		private raRef<scnSceneResource> _scene;
		private CArray<scnScenesVersionsChangedRecord> _sceneChanges;

		[Ordinal(0)] 
		[RED("scene")] 
		public raRef<scnSceneResource> Scene
		{
			get => GetProperty(ref _scene);
			set => SetProperty(ref _scene, value);
		}

		[Ordinal(1)] 
		[RED("sceneChanges")] 
		public CArray<scnScenesVersionsChangedRecord> SceneChanges
		{
			get => GetProperty(ref _sceneChanges);
			set => SetProperty(ref _sceneChanges, value);
		}

		public scnScenesVersionsSceneChanges(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
