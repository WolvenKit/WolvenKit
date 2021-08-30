using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questToggleEventExecutionTag_NodeType : questISceneManagerNodeType
	{
		private CResourceAsyncReference<scnSceneResource> _sceneFile;
		private CName _eventExecutionTag;
		private CBool _mute;

		[Ordinal(0)] 
		[RED("sceneFile")] 
		public CResourceAsyncReference<scnSceneResource> SceneFile
		{
			get => GetProperty(ref _sceneFile);
			set => SetProperty(ref _sceneFile, value);
		}

		[Ordinal(1)] 
		[RED("eventExecutionTag")] 
		public CName EventExecutionTag
		{
			get => GetProperty(ref _eventExecutionTag);
			set => SetProperty(ref _eventExecutionTag, value);
		}

		[Ordinal(2)] 
		[RED("mute")] 
		public CBool Mute
		{
			get => GetProperty(ref _mute);
			set => SetProperty(ref _mute, value);
		}

		public questToggleEventExecutionTag_NodeType()
		{
			_mute = true;
		}
	}
}
