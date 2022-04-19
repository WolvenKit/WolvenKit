using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsUnequipItemFromPerformer : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("performerId")] 
		public scnPerformerId PerformerId
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(7)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(8)] 
		[RED("restoreGameplayItem")] 
		public CBool RestoreGameplayItem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public scneventsUnequipItemFromPerformer()
		{
			Id = new() { Id = 18446744073709551615 };
			PerformerId = new() { Id = 4294967040 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
