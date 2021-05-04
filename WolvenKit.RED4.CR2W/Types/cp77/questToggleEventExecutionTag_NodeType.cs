using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questToggleEventExecutionTag_NodeType : questISceneManagerNodeType
	{
		private raRef<scnSceneResource> _sceneFile;
		private CName _eventExecutionTag;
		private CBool _mute;

		[Ordinal(0)] 
		[RED("sceneFile")] 
		public raRef<scnSceneResource> SceneFile
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

		public questToggleEventExecutionTag_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
