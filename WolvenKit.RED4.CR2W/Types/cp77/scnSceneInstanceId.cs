using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneInstanceId : CVariable
	{
		private scnSceneId _sceneId;
		private scnSceneInstanceOwnerId _ownerId;
		private CUInt8 _internalId;
		private CUInt64 _hash;

		[Ordinal(0)] 
		[RED("sceneId")] 
		public scnSceneId SceneId
		{
			get => GetProperty(ref _sceneId);
			set => SetProperty(ref _sceneId, value);
		}

		[Ordinal(1)] 
		[RED("ownerId")] 
		public scnSceneInstanceOwnerId OwnerId
		{
			get => GetProperty(ref _ownerId);
			set => SetProperty(ref _ownerId, value);
		}

		[Ordinal(2)] 
		[RED("internalId")] 
		public CUInt8 InternalId
		{
			get => GetProperty(ref _internalId);
			set => SetProperty(ref _internalId, value);
		}

		[Ordinal(3)] 
		[RED("hash")] 
		public CUInt64 Hash
		{
			get => GetProperty(ref _hash);
			set => SetProperty(ref _hash, value);
		}

		public scnSceneInstanceId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
