using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AreaEffectVisualizationComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("fxResourceMapper")] 
		public CHandle<FxResourceMapperComponent> FxResourceMapper
		{
			get => GetPropertyValue<CHandle<FxResourceMapperComponent>>();
			set => SetPropertyValue<CHandle<FxResourceMapperComponent>>(value);
		}

		[Ordinal(6)] 
		[RED("forceHighlightTargetBuckets")] 
		public CArray<CHandle<GameEffectTargetVisualizationData>> ForceHighlightTargetBuckets
		{
			get => GetPropertyValue<CArray<CHandle<GameEffectTargetVisualizationData>>>();
			set => SetPropertyValue<CArray<CHandle<GameEffectTargetVisualizationData>>>(value);
		}

		[Ordinal(7)] 
		[RED("availableQuickHacks")] 
		public CArray<CName> AvailableQuickHacks
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(8)] 
		[RED("availablespiderbotActions")] 
		public CArray<CName> AvailablespiderbotActions
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(9)] 
		[RED("activeAction")] 
		public CHandle<BaseScriptableAction> ActiveAction
		{
			get => GetPropertyValue<CHandle<BaseScriptableAction>>();
			set => SetPropertyValue<CHandle<BaseScriptableAction>>(value);
		}

		[Ordinal(10)] 
		[RED("activeEffectIndex")] 
		public CInt32 ActiveEffectIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public AreaEffectVisualizationComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
