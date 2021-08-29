using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameRegisterCooldownFromRecordRequest : RedBaseClass
	{
		private CWeakHandle<entEntity> _owner;
		private gameItemID _ownerItemId;
		private TweakDBID _ownerRecord;
		private CHandle<gamedataCooldown_Record> _cooldownRecord;

		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<entEntity> Owner
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
	}
}
