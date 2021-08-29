using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scneventsUnequipItemFromPerformer : scnSceneEvent
	{
		private scnPerformerId _performerId;
		private TweakDBID _slotId;
		private CBool _restoreGameplayItem;

		[Ordinal(6)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetProperty(ref _performerId);
			set => SetProperty(ref _performerId, value);
		}

		[Ordinal(7)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get => GetProperty(ref _slotId);
			set => SetProperty(ref _slotId, value);
		}

		[Ordinal(8)] 
		[RED("restoreGameplayItem")] 
		public CBool RestoreGameplayItem
		{
			get => GetProperty(ref _restoreGameplayItem);
			set => SetProperty(ref _restoreGameplayItem, value);
		}
	}
}
