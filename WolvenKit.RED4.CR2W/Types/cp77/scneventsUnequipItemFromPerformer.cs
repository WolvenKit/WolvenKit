using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsUnequipItemFromPerformer : scnSceneEvent
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

		public scneventsUnequipItemFromPerformer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
