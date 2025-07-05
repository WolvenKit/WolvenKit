using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameRegisterCooldownFromRecordRequest : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<entEntity> Owner
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(1)] 
		[RED("ownerItemId")] 
		public gameItemID OwnerItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(2)] 
		[RED("ownerRecord")] 
		public TweakDBID OwnerRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("cooldownRecord")] 
		public CHandle<gamedataCooldown_Record> CooldownRecord
		{
			get => GetPropertyValue<CHandle<gamedataCooldown_Record>>();
			set => SetPropertyValue<CHandle<gamedataCooldown_Record>>(value);
		}

		public gameRegisterCooldownFromRecordRequest()
		{
			OwnerItemId = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
