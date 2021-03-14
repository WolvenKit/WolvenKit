using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SCooldown : CVariable
	{
		private gameDelayID _delayId;
		private gameDelayID _removeId;
		private CInt32 _cid;
		private CName _cdName;
		private wCHandle<entEntity> _owner;
		private gameItemID _ownerItemID;
		private TweakDBID _ownerRecord;
		private CFloat _duration;
		private CEnum<gamedataStatType> _type;
		private CFloat _durationMultiplier;
		private CBool _modifiable;
		private CBool _affectedByTimeDilation;
		private CEnum<gamedataStatType> _abilityType;
		private CHandle<gameStatModifierData> _statMod;

		[Ordinal(0)] 
		[RED("delayId")] 
		public gameDelayID DelayId
		{
			get
			{
				if (_delayId == null)
				{
					_delayId = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "delayId", cr2w, this);
				}
				return _delayId;
			}
			set
			{
				if (_delayId == value)
				{
					return;
				}
				_delayId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("removeId")] 
		public gameDelayID RemoveId
		{
			get
			{
				if (_removeId == null)
				{
					_removeId = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "removeId", cr2w, this);
				}
				return _removeId;
			}
			set
			{
				if (_removeId == value)
				{
					return;
				}
				_removeId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("cid")] 
		public CInt32 Cid
		{
			get
			{
				if (_cid == null)
				{
					_cid = (CInt32) CR2WTypeManager.Create("Int32", "cid", cr2w, this);
				}
				return _cid;
			}
			set
			{
				if (_cid == value)
				{
					return;
				}
				_cid = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("cdName")] 
		public CName CdName
		{
			get
			{
				if (_cdName == null)
				{
					_cdName = (CName) CR2WTypeManager.Create("CName", "cdName", cr2w, this);
				}
				return _cdName;
			}
			set
			{
				if (_cdName == value)
				{
					return;
				}
				_cdName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("owner")] 
		public wCHandle<entEntity> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<entEntity>) CR2WTypeManager.Create("whandle:entEntity", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ownerItemID")] 
		public gameItemID OwnerItemID
		{
			get
			{
				if (_ownerItemID == null)
				{
					_ownerItemID = (gameItemID) CR2WTypeManager.Create("gameItemID", "ownerItemID", cr2w, this);
				}
				return _ownerItemID;
			}
			set
			{
				if (_ownerItemID == value)
				{
					return;
				}
				_ownerItemID = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("ownerRecord")] 
		public TweakDBID OwnerRecord
		{
			get
			{
				if (_ownerRecord == null)
				{
					_ownerRecord = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "ownerRecord", cr2w, this);
				}
				return _ownerRecord;
			}
			set
			{
				if (_ownerRecord == value)
				{
					return;
				}
				_ownerRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("type")] 
		public CEnum<gamedataStatType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataStatType>) CR2WTypeManager.Create("gamedataStatType", "type", cr2w, this);
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

		[Ordinal(9)] 
		[RED("durationMultiplier")] 
		public CFloat DurationMultiplier
		{
			get
			{
				if (_durationMultiplier == null)
				{
					_durationMultiplier = (CFloat) CR2WTypeManager.Create("Float", "durationMultiplier", cr2w, this);
				}
				return _durationMultiplier;
			}
			set
			{
				if (_durationMultiplier == value)
				{
					return;
				}
				_durationMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("modifiable")] 
		public CBool Modifiable
		{
			get
			{
				if (_modifiable == null)
				{
					_modifiable = (CBool) CR2WTypeManager.Create("Bool", "modifiable", cr2w, this);
				}
				return _modifiable;
			}
			set
			{
				if (_modifiable == value)
				{
					return;
				}
				_modifiable = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("affectedByTimeDilation")] 
		public CBool AffectedByTimeDilation
		{
			get
			{
				if (_affectedByTimeDilation == null)
				{
					_affectedByTimeDilation = (CBool) CR2WTypeManager.Create("Bool", "affectedByTimeDilation", cr2w, this);
				}
				return _affectedByTimeDilation;
			}
			set
			{
				if (_affectedByTimeDilation == value)
				{
					return;
				}
				_affectedByTimeDilation = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("abilityType")] 
		public CEnum<gamedataStatType> AbilityType
		{
			get
			{
				if (_abilityType == null)
				{
					_abilityType = (CEnum<gamedataStatType>) CR2WTypeManager.Create("gamedataStatType", "abilityType", cr2w, this);
				}
				return _abilityType;
			}
			set
			{
				if (_abilityType == value)
				{
					return;
				}
				_abilityType = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("statMod")] 
		public CHandle<gameStatModifierData> StatMod
		{
			get
			{
				if (_statMod == null)
				{
					_statMod = (CHandle<gameStatModifierData>) CR2WTypeManager.Create("handle:gameStatModifierData", "statMod", cr2w, this);
				}
				return _statMod;
			}
			set
			{
				if (_statMod == value)
				{
					return;
				}
				_statMod = value;
				PropertySet(this);
			}
		}

		public SCooldown(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
