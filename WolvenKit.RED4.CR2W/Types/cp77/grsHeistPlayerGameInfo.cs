using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class grsHeistPlayerGameInfo : CVariable
	{
		private netPeerID _peerID;
		private CBool _isInGame;
		private CBool _isReady;
		private CBool _isRespawning;
		private CBool _isDead;
		private netTime _spawnTime;
		private CUInt32 _killCount;
		private CUInt32 _deathCount;
		private CString _characterRecord;

		[Ordinal(0)] 
		[RED("peerID")] 
		public netPeerID PeerID
		{
			get
			{
				if (_peerID == null)
				{
					_peerID = (netPeerID) CR2WTypeManager.Create("netPeerID", "peerID", cr2w, this);
				}
				return _peerID;
			}
			set
			{
				if (_peerID == value)
				{
					return;
				}
				_peerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isInGame")] 
		public CBool IsInGame
		{
			get
			{
				if (_isInGame == null)
				{
					_isInGame = (CBool) CR2WTypeManager.Create("Bool", "isInGame", cr2w, this);
				}
				return _isInGame;
			}
			set
			{
				if (_isInGame == value)
				{
					return;
				}
				_isInGame = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isReady")] 
		public CBool IsReady
		{
			get
			{
				if (_isReady == null)
				{
					_isReady = (CBool) CR2WTypeManager.Create("Bool", "isReady", cr2w, this);
				}
				return _isReady;
			}
			set
			{
				if (_isReady == value)
				{
					return;
				}
				_isReady = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isRespawning")] 
		public CBool IsRespawning
		{
			get
			{
				if (_isRespawning == null)
				{
					_isRespawning = (CBool) CR2WTypeManager.Create("Bool", "isRespawning", cr2w, this);
				}
				return _isRespawning;
			}
			set
			{
				if (_isRespawning == value)
				{
					return;
				}
				_isRespawning = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isDead")] 
		public CBool IsDead
		{
			get
			{
				if (_isDead == null)
				{
					_isDead = (CBool) CR2WTypeManager.Create("Bool", "isDead", cr2w, this);
				}
				return _isDead;
			}
			set
			{
				if (_isDead == value)
				{
					return;
				}
				_isDead = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("spawnTime")] 
		public netTime SpawnTime
		{
			get
			{
				if (_spawnTime == null)
				{
					_spawnTime = (netTime) CR2WTypeManager.Create("netTime", "spawnTime", cr2w, this);
				}
				return _spawnTime;
			}
			set
			{
				if (_spawnTime == value)
				{
					return;
				}
				_spawnTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("killCount")] 
		public CUInt32 KillCount
		{
			get
			{
				if (_killCount == null)
				{
					_killCount = (CUInt32) CR2WTypeManager.Create("Uint32", "killCount", cr2w, this);
				}
				return _killCount;
			}
			set
			{
				if (_killCount == value)
				{
					return;
				}
				_killCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("deathCount")] 
		public CUInt32 DeathCount
		{
			get
			{
				if (_deathCount == null)
				{
					_deathCount = (CUInt32) CR2WTypeManager.Create("Uint32", "deathCount", cr2w, this);
				}
				return _deathCount;
			}
			set
			{
				if (_deathCount == value)
				{
					return;
				}
				_deathCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("characterRecord")] 
		public CString CharacterRecord
		{
			get
			{
				if (_characterRecord == null)
				{
					_characterRecord = (CString) CR2WTypeManager.Create("String", "characterRecord", cr2w, this);
				}
				return _characterRecord;
			}
			set
			{
				if (_characterRecord == value)
				{
					return;
				}
				_characterRecord = value;
				PropertySet(this);
			}
		}

		public grsHeistPlayerGameInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
