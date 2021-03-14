using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameRegisterCooldownFromRecordRequest : CVariable
	{
		private wCHandle<entEntity> _owner;
		private gameItemID _ownerItemId;
		private TweakDBID _ownerRecord;
		private CHandle<gamedataCooldown_Record> _cooldownRecord;

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
		[RED("cooldownRecord")] 
		public CHandle<gamedataCooldown_Record> CooldownRecord
		{
			get
			{
				if (_cooldownRecord == null)
				{
					_cooldownRecord = (CHandle<gamedataCooldown_Record>) CR2WTypeManager.Create("handle:gamedataCooldown_Record", "cooldownRecord", cr2w, this);
				}
				return _cooldownRecord;
			}
			set
			{
				if (_cooldownRecord == value)
				{
					return;
				}
				_cooldownRecord = value;
				PropertySet(this);
			}
		}

		public gameRegisterCooldownFromRecordRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
