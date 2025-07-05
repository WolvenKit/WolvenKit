using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnSceneInstanceId : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("sceneId")] 
		public scnSceneId SceneId
		{
			get => GetPropertyValue<scnSceneId>();
			set => SetPropertyValue<scnSceneId>(value);
		}

		[Ordinal(1)] 
		[RED("ownerId")] 
		public scnSceneInstanceOwnerId OwnerId
		{
			get => GetPropertyValue<scnSceneInstanceOwnerId>();
			set => SetPropertyValue<scnSceneInstanceOwnerId>(value);
		}

		[Ordinal(2)] 
		[RED("internalId")] 
		public CUInt8 InternalId
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(3)] 
		[RED("hash")] 
		public CUInt64 Hash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public scnSceneInstanceId()
		{
			SceneId = new scnSceneId();
			OwnerId = new scnSceneInstanceOwnerId();
			InternalId = 255;
			Hash = 6242570315725555409;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
