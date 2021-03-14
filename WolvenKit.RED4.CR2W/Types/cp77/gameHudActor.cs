using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHudActor : IScriptable
	{
		private entEntityID _entityID;
		private CEnum<HUDActorType> _type;
		private CEnum<HUDActorStatus> _status;
		private CEnum<ActorVisibilityStatus> _visibility;
		private CArray<wCHandle<HUDModule>> _activeModules;
		private CBool _isRevealed;
		private CBool _isTagged;
		private HUDClueData _clueData;
		private CBool _isRemotelyAccessed;
		private CBool _canOpenScannerInfo;
		private CBool _isInIconForcedVisibilityRange;
		private CBool _isIconForcedVisibleThroughWalls;
		private CBool _shouldRefreshQHack;

		[Ordinal(0)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get
			{
				if (_entityID == null)
				{
					_entityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "entityID", cr2w, this);
				}
				return _entityID;
			}
			set
			{
				if (_entityID == value)
				{
					return;
				}
				_entityID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<HUDActorType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<HUDActorType>) CR2WTypeManager.Create("HUDActorType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("status")] 
		public CEnum<HUDActorStatus> Status
		{
			get
			{
				if (_status == null)
				{
					_status = (CEnum<HUDActorStatus>) CR2WTypeManager.Create("HUDActorStatus", "status", cr2w, this);
				}
				return _status;
			}
			set
			{
				if (_status == value)
				{
					return;
				}
				_status = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("visibility")] 
		public CEnum<ActorVisibilityStatus> Visibility
		{
			get
			{
				if (_visibility == null)
				{
					_visibility = (CEnum<ActorVisibilityStatus>) CR2WTypeManager.Create("ActorVisibilityStatus", "visibility", cr2w, this);
				}
				return _visibility;
			}
			set
			{
				if (_visibility == value)
				{
					return;
				}
				_visibility = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("activeModules")] 
		public CArray<wCHandle<HUDModule>> ActiveModules
		{
			get
			{
				if (_activeModules == null)
				{
					_activeModules = (CArray<wCHandle<HUDModule>>) CR2WTypeManager.Create("array:whandle:HUDModule", "activeModules", cr2w, this);
				}
				return _activeModules;
			}
			set
			{
				if (_activeModules == value)
				{
					return;
				}
				_activeModules = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isRevealed")] 
		public CBool IsRevealed
		{
			get
			{
				if (_isRevealed == null)
				{
					_isRevealed = (CBool) CR2WTypeManager.Create("Bool", "isRevealed", cr2w, this);
				}
				return _isRevealed;
			}
			set
			{
				if (_isRevealed == value)
				{
					return;
				}
				_isRevealed = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("isTagged")] 
		public CBool IsTagged
		{
			get
			{
				if (_isTagged == null)
				{
					_isTagged = (CBool) CR2WTypeManager.Create("Bool", "isTagged", cr2w, this);
				}
				return _isTagged;
			}
			set
			{
				if (_isTagged == value)
				{
					return;
				}
				_isTagged = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("clueData")] 
		public HUDClueData ClueData
		{
			get
			{
				if (_clueData == null)
				{
					_clueData = (HUDClueData) CR2WTypeManager.Create("HUDClueData", "clueData", cr2w, this);
				}
				return _clueData;
			}
			set
			{
				if (_clueData == value)
				{
					return;
				}
				_clueData = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isRemotelyAccessed")] 
		public CBool IsRemotelyAccessed
		{
			get
			{
				if (_isRemotelyAccessed == null)
				{
					_isRemotelyAccessed = (CBool) CR2WTypeManager.Create("Bool", "isRemotelyAccessed", cr2w, this);
				}
				return _isRemotelyAccessed;
			}
			set
			{
				if (_isRemotelyAccessed == value)
				{
					return;
				}
				_isRemotelyAccessed = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("canOpenScannerInfo")] 
		public CBool CanOpenScannerInfo
		{
			get
			{
				if (_canOpenScannerInfo == null)
				{
					_canOpenScannerInfo = (CBool) CR2WTypeManager.Create("Bool", "canOpenScannerInfo", cr2w, this);
				}
				return _canOpenScannerInfo;
			}
			set
			{
				if (_canOpenScannerInfo == value)
				{
					return;
				}
				_canOpenScannerInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("isInIconForcedVisibilityRange")] 
		public CBool IsInIconForcedVisibilityRange
		{
			get
			{
				if (_isInIconForcedVisibilityRange == null)
				{
					_isInIconForcedVisibilityRange = (CBool) CR2WTypeManager.Create("Bool", "isInIconForcedVisibilityRange", cr2w, this);
				}
				return _isInIconForcedVisibilityRange;
			}
			set
			{
				if (_isInIconForcedVisibilityRange == value)
				{
					return;
				}
				_isInIconForcedVisibilityRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("isIconForcedVisibleThroughWalls")] 
		public CBool IsIconForcedVisibleThroughWalls
		{
			get
			{
				if (_isIconForcedVisibleThroughWalls == null)
				{
					_isIconForcedVisibleThroughWalls = (CBool) CR2WTypeManager.Create("Bool", "isIconForcedVisibleThroughWalls", cr2w, this);
				}
				return _isIconForcedVisibleThroughWalls;
			}
			set
			{
				if (_isIconForcedVisibleThroughWalls == value)
				{
					return;
				}
				_isIconForcedVisibleThroughWalls = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("shouldRefreshQHack")] 
		public CBool ShouldRefreshQHack
		{
			get
			{
				if (_shouldRefreshQHack == null)
				{
					_shouldRefreshQHack = (CBool) CR2WTypeManager.Create("Bool", "shouldRefreshQHack", cr2w, this);
				}
				return _shouldRefreshQHack;
			}
			set
			{
				if (_shouldRefreshQHack == value)
				{
					return;
				}
				_shouldRefreshQHack = value;
				PropertySet(this);
			}
		}

		public gameHudActor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
