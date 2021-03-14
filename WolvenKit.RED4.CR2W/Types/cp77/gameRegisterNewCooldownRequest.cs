using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameRegisterNewCooldownRequest : CVariable
	{
		private wCHandle<entEntity> _owner;
		private gameItemID _ownerItemId;
		private TweakDBID _ownerRecord;
		private CName _cooldownName;
		private CFloat _duration;
		private CEnum<gamedataStatType> _type;
		private CBool _modifiable;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("ownerItemId")] 
		public gameItemID OwnerItemId
		{
			get
			{
				if (_ownerItemId == null)
				{
					_ownerItemId = (gameItemID) CR2WTypeManager.Create("gameItemID", "ownerItemId", cr2w, this);
				}
				return _ownerItemId;
			}
			set
			{
				if (_ownerItemId == value)
				{
					return;
				}
				_ownerItemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("cooldownName")] 
		public CName CooldownName
		{
			get
			{
				if (_cooldownName == null)
				{
					_cooldownName = (CName) CR2WTypeManager.Create("CName", "cooldownName", cr2w, this);
				}
				return _cooldownName;
			}
			set
			{
				if (_cooldownName == value)
				{
					return;
				}
				_cooldownName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		public gameRegisterNewCooldownRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
