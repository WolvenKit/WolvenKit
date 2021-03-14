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
			get
			{
				if (_fxResourceMapper == null)
				{
					_fxResourceMapper = (CHandle<FxResourceMapperComponent>) CR2WTypeManager.Create("handle:FxResourceMapperComponent", "fxResourceMapper", cr2w, this);
				}
				return _fxResourceMapper;
			}
			set
			{
				if (_fxResourceMapper == value)
				{
					return;
				}
				_fxResourceMapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("forceHighlightTargetBuckets")] 
		public CArray<CHandle<GameEffectTargetVisualizationData>> ForceHighlightTargetBuckets
		{
			get
			{
				if (_forceHighlightTargetBuckets == null)
				{
					_forceHighlightTargetBuckets = (CArray<CHandle<GameEffectTargetVisualizationData>>) CR2WTypeManager.Create("array:handle:GameEffectTargetVisualizationData", "forceHighlightTargetBuckets", cr2w, this);
				}
				return _forceHighlightTargetBuckets;
			}
			set
			{
				if (_forceHighlightTargetBuckets == value)
				{
					return;
				}
				_forceHighlightTargetBuckets = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("availableQuickHacks")] 
		public CArray<CName> AvailableQuickHacks
		{
			get
			{
				if (_availableQuickHacks == null)
				{
					_availableQuickHacks = (CArray<CName>) CR2WTypeManager.Create("array:CName", "availableQuickHacks", cr2w, this);
				}
				return _availableQuickHacks;
			}
			set
			{
				if (_availableQuickHacks == value)
				{
					return;
				}
				_availableQuickHacks = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("availablespiderbotActions")] 
		public CArray<CName> AvailablespiderbotActions
		{
			get
			{
				if (_availablespiderbotActions == null)
				{
					_availablespiderbotActions = (CArray<CName>) CR2WTypeManager.Create("array:CName", "availablespiderbotActions", cr2w, this);
				}
				return _availablespiderbotActions;
			}
			set
			{
				if (_availablespiderbotActions == value)
				{
					return;
				}
				_availablespiderbotActions = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("activeAction")] 
		public CHandle<BaseScriptableAction> ActiveAction
		{
			get
			{
				if (_activeAction == null)
				{
					_activeAction = (CHandle<BaseScriptableAction>) CR2WTypeManager.Create("handle:BaseScriptableAction", "activeAction", cr2w, this);
				}
				return _activeAction;
			}
			set
			{
				if (_activeAction == value)
				{
					return;
				}
				_activeAction = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("activeEffectIndex")] 
		public CInt32 ActiveEffectIndex
		{
			get
			{
				if (_activeEffectIndex == null)
				{
					_activeEffectIndex = (CInt32) CR2WTypeManager.Create("Int32", "activeEffectIndex", cr2w, this);
				}
				return _activeEffectIndex;
			}
			set
			{
				if (_activeEffectIndex == value)
				{
					return;
				}
				_activeEffectIndex = value;
				PropertySet(this);
			}
		}

		public AreaEffectVisualizationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
