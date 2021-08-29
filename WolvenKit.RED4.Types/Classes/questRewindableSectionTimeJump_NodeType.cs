using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questRewindableSectionTimeJump_NodeType : questISceneManagerNodeType
	{
		private CResourceAsyncReference<scnSceneResource> _sceneFile;
		private CUInt32 _jumpTargetTime;
		private CFloat _jumpSpeed;
		private CEnum<scnPlayDirection> _postJumpPlayDirection;
		private CEnum<scnPlaySpeed> _postJumpPlaySpeed;

		[Ordinal(0)] 
		[RED("sceneFile")] 
		public CResourceAsyncReference<scnSceneResource> SceneFile
		{
			get => GetProperty(ref _sceneFile);
			set => SetProperty(ref _sceneFile, value);
		}

		[Ordinal(1)] 
		[RED("jumpTargetTime")] 
		public CUInt32 JumpTargetTime
		{
			get => GetProperty(ref _jumpTargetTime);
			set => SetProperty(ref _jumpTargetTime, value);
		}

		[Ordinal(2)] 
		[RED("jumpSpeed")] 
		public CFloat JumpSpeed
		{
			get => GetProperty(ref _jumpSpeed);
			set => SetProperty(ref _jumpSpeed, value);
		}

		[Ordinal(3)] 
		[RED("postJumpPlayDirection")] 
		public CEnum<scnPlayDirection> PostJumpPlayDirection
		{
			get => GetProperty(ref _postJumpPlayDirection);
			set => SetProperty(ref _postJumpPlayDirection, value);
		}

		[Ordinal(4)] 
		[RED("postJumpPlaySpeed")] 
		public CEnum<scnPlaySpeed> PostJumpPlaySpeed
		{
			get => GetProperty(ref _postJumpPlaySpeed);
			set => SetProperty(ref _postJumpPlaySpeed, value);
		}
	}
}
