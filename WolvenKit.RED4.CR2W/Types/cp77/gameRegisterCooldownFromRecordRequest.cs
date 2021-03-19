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
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("ownerItemId")] 
		public gameItemID OwnerItemId
		{
			get => GetProperty(ref _ownerItemId);
			set => SetProperty(ref _ownerItemId, value);
		}

		[Ordinal(2)] 
		[RED("ownerRecord")] 
		public TweakDBID OwnerRecord
		{
			get => GetProperty(ref _ownerRecord);
			set => SetProperty(ref _ownerRecord, value);
		}

		[Ordinal(3)] 
		[RED("cooldownRecord")] 
		public CHandle<gamedataCooldown_Record> CooldownRecord
		{
			get => GetProperty(ref _cooldownRecord);
			set => SetProperty(ref _cooldownRecord, value);
		}

		public gameRegisterCooldownFromRecordRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
