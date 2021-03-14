using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMultiplayerTeleportPuppetParams : CVariable
	{
		private CBool _teleportAllPlayers;
		private CName _spawnPointTag;
		private gameEntityReference _destinationRef;
		private Vector3 _destinationOffset;
		private gameEntityReference _areaNodeTriggerRef;

		[Ordinal(0)] 
		[RED("teleportAllPlayers")] 
		public CBool TeleportAllPlayers
		{
			get
			{
				if (_teleportAllPlayers == null)
				{
					_teleportAllPlayers = (CBool) CR2WTypeManager.Create("Bool", "teleportAllPlayers", cr2w, this);
				}
				return _teleportAllPlayers;
			}
			set
			{
				if (_teleportAllPlayers == value)
				{
					return;
				}
				_teleportAllPlayers = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("spawnPointTag")] 
		public CName SpawnPointTag
		{
			get
			{
				if (_spawnPointTag == null)
				{
					_spawnPointTag = (CName) CR2WTypeManager.Create("CName", "spawnPointTag", cr2w, this);
				}
				return _spawnPointTag;
			}
			set
			{
				if (_spawnPointTag == value)
				{
					return;
				}
				_spawnPointTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("destinationRef")] 
		public gameEntityReference DestinationRef
		{
			get
			{
				if (_destinationRef == null)
				{
					_destinationRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "destinationRef", cr2w, this);
				}
				return _destinationRef;
			}
			set
			{
				if (_destinationRef == value)
				{
					return;
				}
				_destinationRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("destinationOffset")] 
		public Vector3 DestinationOffset
		{
			get
			{
				if (_destinationOffset == null)
				{
					_destinationOffset = (Vector3) CR2WTypeManager.Create("Vector3", "destinationOffset", cr2w, this);
				}
				return _destinationOffset;
			}
			set
			{
				if (_destinationOffset == value)
				{
					return;
				}
				_destinationOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("areaNodeTriggerRef")] 
		public gameEntityReference AreaNodeTriggerRef
		{
			get
			{
				if (_areaNodeTriggerRef == null)
				{
					_areaNodeTriggerRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "areaNodeTriggerRef", cr2w, this);
				}
				return _areaNodeTriggerRef;
			}
			set
			{
				if (_areaNodeTriggerRef == value)
				{
					return;
				}
				_areaNodeTriggerRef = value;
				PropertySet(this);
			}
		}

		public questMultiplayerTeleportPuppetParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
