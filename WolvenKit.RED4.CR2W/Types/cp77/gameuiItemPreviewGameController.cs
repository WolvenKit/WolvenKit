using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiItemPreviewGameController : gameuiPreviewGameController
	{
		private CName _sceneName;
		private NodeRef _cameraRef;

		[Ordinal(6)] 
		[RED("sceneName")] 
		public CName SceneName
		{
			get => GetProperty(ref _sceneName);
			set => SetProperty(ref _sceneName, value);
		}

		[Ordinal(7)] 
		[RED("cameraRef")] 
		public NodeRef CameraRef
		{
			get => GetProperty(ref _cameraRef);
			set => SetProperty(ref _cameraRef, value);
		}

		public gameuiItemPreviewGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
