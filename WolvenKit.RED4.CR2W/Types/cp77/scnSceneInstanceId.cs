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
			get
			{
				if (_sceneId == null)
				{
					_sceneId = (scnSceneId) CR2WTypeManager.Create("scnSceneId", "sceneId", cr2w, this);
				}
				return _sceneId;
			}
			set
			{
				if (_sceneId == value)
				{
					return;
				}
				_sceneId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ownerId")] 
		public scnSceneInstanceOwnerId OwnerId
		{
			get
			{
				if (_ownerId == null)
				{
					_ownerId = (scnSceneInstanceOwnerId) CR2WTypeManager.Create("scnSceneInstanceOwnerId", "ownerId", cr2w, this);
				}
				return _ownerId;
			}
			set
			{
				if (_ownerId == value)
				{
					return;
				}
				_ownerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("internalId")] 
		public CUInt8 InternalId
		{
			get
			{
				if (_internalId == null)
				{
					_internalId = (CUInt8) CR2WTypeManager.Create("Uint8", "internalId", cr2w, this);
				}
				return _internalId;
			}
			set
			{
				if (_internalId == value)
				{
					return;
				}
				_internalId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hash")] 
		public CUInt64 Hash
		{
			get
			{
				if (_hash == null)
				{
					_hash = (CUInt64) CR2WTypeManager.Create("Uint64", "hash", cr2w, this);
				}
				return _hash;
			}
			set
			{
				if (_hash == value)
				{
					return;
				}
				_hash = value;
				PropertySet(this);
			}
		}

		public scnSceneInstanceId(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
