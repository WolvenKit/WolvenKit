using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AreaEffectVisualizationComponent : gameScriptableComponent
	{
		private CHandle<FxResourceMapperComponent> _fxResourceMapper;
		private CArray<CHandle<GameEffectTargetVisualizationData>> _forceHighlightTargetBuckets;
		private CArray<CName> _availableQuickHacks;
		private CArray<CName> _availablespiderbotActions;
		private CHandle<BaseScriptableAction> _activeAction;
		private CInt32 _activeEffectIndex;

		[Ordinal(5)] 
		[RED("fxResourceMapper")] 
		public CHandle<FxResourceMapperComponent> FxResourceMapper
		{
			get => GetProperty(ref _fxResourceMapper);
			set => SetProperty(ref _fxResourceMapper, value);
		}

		[Ordinal(6)] 
		[RED("forceHighlightTargetBuckets")] 
		public CArray<CHandle<GameEffectTargetVisualizationData>> ForceHighlightTargetBuckets
		{
			get => GetProperty(ref _forceHighlightTargetBuckets);
			set => SetProperty(ref _forceHighlightTargetBuckets, value);
		}

		[Ordinal(7)] 
		[RED("availableQuickHacks")] 
		public CArray<CName> AvailableQuickHacks
		{
			get => GetProperty(ref _availableQuickHacks);
			set => SetProperty(ref _availableQuickHacks, value);
		}

		[Ordinal(8)] 
		[RED("availablespiderbotActions")] 
		public CArray<CName> AvailablespiderbotActions
		{
			get => GetProperty(ref _availablespiderbotActions);
			set => SetProperty(ref _availablespiderbotActions, value);
		}

		[Ordinal(9)] 
		[RED("activeAction")] 
		public CHandle<BaseScriptableAction> ActiveAction
		{
			get => GetProperty(ref _activeAction);
			set => SetProperty(ref _activeAction, value);
		}

		[Ordinal(10)] 
		[RED("activeEffectIndex")] 
		public CInt32 ActiveEffectIndex
		{
			get => GetProperty(ref _activeEffectIndex);
			set => SetProperty(ref _activeEffectIndex, value);
		}

		public AreaEffectVisualizationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
