using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAttachmentSlotReplicatedState : RedBaseClass
	{
		private TweakDBID _slotID;
		private gameItemID _activeItemID;
		private CBool _hasItemObject;

		[Ordinal(0)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(1)] 
		[RED("activeItemID")] 
		public gameItemID ActiveItemID
		{
			get => GetProperty(ref _activeItemID);
			set => SetProperty(ref _activeItemID, value);
		}

		[Ordinal(2)] 
		[RED("hasItemObject")] 
		public CBool HasItemObject
		{
			get => GetProperty(ref _hasItemObject);
			set => SetProperty(ref _hasItemObject, value);
		}
	}
}
