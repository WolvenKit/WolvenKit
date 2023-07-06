using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnFindEntityInEntityParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get => GetPropertyValue<scnActorId>();
			set => SetPropertyValue<scnActorId>(value);
		}

		[Ordinal(1)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(2)] 
		[RED("itemID")] 
		public TweakDBID ItemID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(4)] 
		[RED("forceMaxVisibility")] 
		public CBool ForceMaxVisibility
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("ownershipTransferOptions")] 
		public scnPropOwnershipTransferOptions OwnershipTransferOptions
		{
			get => GetPropertyValue<scnPropOwnershipTransferOptions>();
			set => SetPropertyValue<scnPropOwnershipTransferOptions>(value);
		}

		public scnFindEntityInEntityParams()
		{
			ActorId = new scnActorId { Id = uint.MaxValue };
			PerformerId = new scnPerformerId { Id = 4294967040 };
			OwnershipTransferOptions = new scnPropOwnershipTransferOptions { DettachFromSlot = true, RemoveFromInventory = true };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
