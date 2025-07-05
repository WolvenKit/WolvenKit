using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questRewindableSectionTimeJump_NodeType : questISceneManagerNodeType
	{
		[Ordinal(0)] 
		[RED("sceneFile")] 
		public CResourceAsyncReference<scnSceneResource> SceneFile
		{
			get => GetPropertyValue<CResourceAsyncReference<scnSceneResource>>();
			set => SetPropertyValue<CResourceAsyncReference<scnSceneResource>>(value);
		}

		[Ordinal(1)] 
		[RED("jumpTargetTime")] 
		public CUInt32 JumpTargetTime
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("jumpSpeed")] 
		public CFloat JumpSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("postJumpPlayDirection")] 
		public CEnum<scnPlayDirection> PostJumpPlayDirection
		{
			get => GetPropertyValue<CEnum<scnPlayDirection>>();
			set => SetPropertyValue<CEnum<scnPlayDirection>>(value);
		}

		[Ordinal(4)] 
		[RED("postJumpPlaySpeed")] 
		public CEnum<scnPlaySpeed> PostJumpPlaySpeed
		{
			get => GetPropertyValue<CEnum<scnPlaySpeed>>();
			set => SetPropertyValue<CEnum<scnPlaySpeed>>(value);
		}

		public questRewindableSectionTimeJump_NodeType()
		{
			JumpSpeed = 100.000000F;
			PostJumpPlaySpeed = Enums.scnPlaySpeed.Normal;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
