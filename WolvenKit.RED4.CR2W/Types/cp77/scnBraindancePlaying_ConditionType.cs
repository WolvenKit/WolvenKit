using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnBraindancePlaying_ConditionType : scnIBraindanceConditionType
	{
		private CEnum<scnBraindanceSpeed> _speed;
		private raRef<scnSceneResource> _sceneFile;

		[Ordinal(0)] 
		[RED("speed")] 
		public CEnum<scnBraindanceSpeed> Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(1)] 
		[RED("sceneFile")] 
		public raRef<scnSceneResource> SceneFile
		{
			get => GetProperty(ref _sceneFile);
			set => SetProperty(ref _sceneFile, value);
		}

		public scnBraindancePlaying_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
