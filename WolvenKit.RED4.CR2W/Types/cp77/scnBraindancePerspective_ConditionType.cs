using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnBraindancePerspective_ConditionType : scnIBraindanceConditionType
	{
		private CEnum<scnBraindancePerspective> _perspective;
		private raRef<scnSceneResource> _sceneFile;
		private CEnum<scnSceneVersionCheck> _sceneVersion;

		[Ordinal(0)] 
		[RED("perspective")] 
		public CEnum<scnBraindancePerspective> Perspective
		{
			get => GetProperty(ref _perspective);
			set => SetProperty(ref _perspective, value);
		}

		[Ordinal(1)] 
		[RED("sceneFile")] 
		public raRef<scnSceneResource> SceneFile
		{
			get => GetProperty(ref _sceneFile);
			set => SetProperty(ref _sceneFile, value);
		}

		[Ordinal(2)] 
		[RED("SceneVersion")] 
		public CEnum<scnSceneVersionCheck> SceneVersion
		{
			get => GetProperty(ref _sceneVersion);
			set => SetProperty(ref _sceneVersion, value);
		}

		public scnBraindancePerspective_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
