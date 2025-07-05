using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsEquipItemToPerformer : scnSceneEvent
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
		[RED("itemId")] 
		public TweakDBID ItemId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public scneventsEquipItemToPerformer()
		{
			Id = new scnSceneEventId { Id = long.MaxValue };
			PerformerId = new scnPerformerId { Id = 4294967040 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
