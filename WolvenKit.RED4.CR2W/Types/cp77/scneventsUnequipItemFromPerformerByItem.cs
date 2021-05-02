using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsUnequipItemFromPerformerByItem : scnSceneEvent
	{
		private scnPerformerId _performerId;
		private TweakDBID _itemId;
		private CBool _restoreGameplayItem;

		[Ordinal(6)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetProperty(ref _performerId);
			set => SetProperty(ref _performerId, value);
		}

		[Ordinal(7)] 
		[RED("itemId")] 
		public TweakDBID ItemId
		{
			get => GetProperty(ref _itemId);
			set => SetProperty(ref _itemId, value);
		}

		[Ordinal(8)] 
		[RED("restoreGameplayItem")] 
		public CBool RestoreGameplayItem
		{
			get => GetProperty(ref _restoreGameplayItem);
			set => SetProperty(ref _restoreGameplayItem, value);
		}

		public scneventsUnequipItemFromPerformerByItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
