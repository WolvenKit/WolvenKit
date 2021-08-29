using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnScenesVersionsChangedRecord : RedBaseClass
	{
		private CUInt32 _changeInVersion;
		private CResourceAsyncReference<scnSceneResource> _sceneBeforeChange;

		[Ordinal(0)] 
		[RED("changeInVersion")] 
		public CUInt32 ChangeInVersion
		{
			get => GetProperty(ref _changeInVersion);
			set => SetProperty(ref _changeInVersion, value);
		}

		[Ordinal(1)] 
		[RED("sceneBeforeChange")] 
		public CResourceAsyncReference<scnSceneResource> SceneBeforeChange
		{
			get => GetProperty(ref _sceneBeforeChange);
			set => SetProperty(ref _sceneBeforeChange, value);
		}
	}
}
