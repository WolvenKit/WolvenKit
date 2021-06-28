using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnScenesVersionsChangedRecord : CVariable
	{
		private CUInt32 _changeInVersion;
		private raRef<scnSceneResource> _sceneBeforeChange;

		[Ordinal(0)] 
		[RED("changeInVersion")] 
		public CUInt32 ChangeInVersion
		{
			get => GetProperty(ref _changeInVersion);
			set => SetProperty(ref _changeInVersion, value);
		}

		[Ordinal(1)] 
		[RED("sceneBeforeChange")] 
		public raRef<scnSceneResource> SceneBeforeChange
		{
			get => GetProperty(ref _sceneBeforeChange);
			set => SetProperty(ref _sceneBeforeChange, value);
		}

		public scnScenesVersionsChangedRecord(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
