using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnFindEntityInEntityParams : RedBaseClass
	{
		private scnActorId _actorId;
		private scnPerformerId _performerId;
		private TweakDBID _itemID;
		private TweakDBID _slotID;
		private CBool _forceMaxVisibility;
		private scnPropOwnershipTransferOptions _ownershipTransferOptions;

		[Ordinal(0)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get => GetProperty(ref _actorId);
			set => SetProperty(ref _actorId, value);
		}

		[Ordinal(1)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetProperty(ref _performerId);
			set => SetProperty(ref _performerId, value);
		}

		[Ordinal(2)] 
		[RED("itemID")] 
		public TweakDBID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(3)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(4)] 
		[RED("forceMaxVisibility")] 
		public CBool ForceMaxVisibility
		{
			get => GetProperty(ref _forceMaxVisibility);
			set => SetProperty(ref _forceMaxVisibility, value);
		}

		[Ordinal(5)] 
		[RED("ownershipTransferOptions")] 
		public scnPropOwnershipTransferOptions OwnershipTransferOptions
		{
			get => GetProperty(ref _ownershipTransferOptions);
			set => SetProperty(ref _ownershipTransferOptions, value);
		}
	}
}
