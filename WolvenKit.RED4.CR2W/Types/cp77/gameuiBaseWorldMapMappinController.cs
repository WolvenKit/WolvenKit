using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseWorldMapMappinController : gameuiInteractionMappinController
	{
		private CBool _selected;
		private CBool _inZoomLevel;
		private CBool _inCustomFilter;
		private CBool _hasCustomFilter;
		private CBool _isFastTravelEnabled;
		private CBool _isVisibleInFilterAndZoom;
		private CEnum<gameuiMappinGroupState> _groupState;
		private CUInt8 _collectionCount;
		private inkWidgetReference _groupContainerWidget;
		private inkTextWidgetReference _groupCountTextWidget;
		private inkWidgetReference _isNewContainer;
		private wCHandle<gamemappinsIMappin> _mappin;
		private CBool _isCompletedPhase;
		private CHandle<inkanimProxy> _fadeAnim;
		private CHandle<inkanimProxy> _selectAnim;

		[Ordinal(11)] 
		[RED("selected")] 
		public CBool Selected
		{
			get
			{
				if (_selected == null)
				{
					_selected = (CBool) CR2WTypeManager.Create("Bool", "selected", cr2w, this);
				}
				return _selected;
			}
			set
			{
				if (_selected == value)
				{
					return;
				}
				_selected = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("inZoomLevel")] 
		public CBool InZoomLevel
		{
			get
			{
				if (_inZoomLevel == null)
				{
					_inZoomLevel = (CBool) CR2WTypeManager.Create("Bool", "inZoomLevel", cr2w, this);
				}
				return _inZoomLevel;
			}
			set
			{
				if (_inZoomLevel == value)
				{
					return;
				}
				_inZoomLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("inCustomFilter")] 
		public CBool InCustomFilter
		{
			get
			{
				if (_inCustomFilter == null)
				{
					_inCustomFilter = (CBool) CR2WTypeManager.Create("Bool", "inCustomFilter", cr2w, this);
				}
				return _inCustomFilter;
			}
			set
			{
				if (_inCustomFilter == value)
				{
					return;
				}
				_inCustomFilter = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("hasCustomFilter")] 
		public CBool HasCustomFilter
		{
			get
			{
				if (_hasCustomFilter == null)
				{
					_hasCustomFilter = (CBool) CR2WTypeManager.Create("Bool", "hasCustomFilter", cr2w, this);
				}
				return _hasCustomFilter;
			}
			set
			{
				if (_hasCustomFilter == value)
				{
					return;
				}
				_hasCustomFilter = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("isFastTravelEnabled")] 
		public CBool IsFastTravelEnabled
		{
			get
			{
				if (_isFastTravelEnabled == null)
				{
					_isFastTravelEnabled = (CBool) CR2WTypeManager.Create("Bool", "isFastTravelEnabled", cr2w, this);
				}
				return _isFastTravelEnabled;
			}
			set
			{
				if (_isFastTravelEnabled == value)
				{
					return;
				}
				_isFastTravelEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("isVisibleInFilterAndZoom")] 
		public CBool IsVisibleInFilterAndZoom
		{
			get
			{
				if (_isVisibleInFilterAndZoom == null)
				{
					_isVisibleInFilterAndZoom = (CBool) CR2WTypeManager.Create("Bool", "isVisibleInFilterAndZoom", cr2w, this);
				}
				return _isVisibleInFilterAndZoom;
			}
			set
			{
				if (_isVisibleInFilterAndZoom == value)
				{
					return;
				}
				_isVisibleInFilterAndZoom = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("groupState")] 
		public CEnum<gameuiMappinGroupState> GroupState
		{
			get
			{
				if (_groupState == null)
				{
					_groupState = (CEnum<gameuiMappinGroupState>) CR2WTypeManager.Create("gameuiMappinGroupState", "groupState", cr2w, this);
				}
				return _groupState;
			}
			set
			{
				if (_groupState == value)
				{
					return;
				}
				_groupState = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("collectionCount")] 
		public CUInt8 CollectionCount
		{
			get
			{
				if (_collectionCount == null)
				{
					_collectionCount = (CUInt8) CR2WTypeManager.Create("Uint8", "collectionCount", cr2w, this);
				}
				return _collectionCount;
			}
			set
			{
				if (_collectionCount == value)
				{
					return;
				}
				_collectionCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("groupContainerWidget")] 
		public inkWidgetReference GroupContainerWidget
		{
			get
			{
				if (_groupContainerWidget == null)
				{
					_groupContainerWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "groupContainerWidget", cr2w, this);
				}
				return _groupContainerWidget;
			}
			set
			{
				if (_groupContainerWidget == value)
				{
					return;
				}
				_groupContainerWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("groupCountTextWidget")] 
		public inkTextWidgetReference GroupCountTextWidget
		{
			get
			{
				if (_groupCountTextWidget == null)
				{
					_groupCountTextWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "groupCountTextWidget", cr2w, this);
				}
				return _groupCountTextWidget;
			}
			set
			{
				if (_groupCountTextWidget == value)
				{
					return;
				}
				_groupCountTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("isNewContainer")] 
		public inkWidgetReference IsNewContainer
		{
			get
			{
				if (_isNewContainer == null)
				{
					_isNewContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "isNewContainer", cr2w, this);
				}
				return _isNewContainer;
			}
			set
			{
				if (_isNewContainer == value)
				{
					return;
				}
				_isNewContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("mappin")] 
		public wCHandle<gamemappinsIMappin> Mappin
		{
			get
			{
				if (_mappin == null)
				{
					_mappin = (wCHandle<gamemappinsIMappin>) CR2WTypeManager.Create("whandle:gamemappinsIMappin", "mappin", cr2w, this);
				}
				return _mappin;
			}
			set
			{
				if (_mappin == value)
				{
					return;
				}
				_mappin = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("isCompletedPhase")] 
		public CBool IsCompletedPhase
		{
			get
			{
				if (_isCompletedPhase == null)
				{
					_isCompletedPhase = (CBool) CR2WTypeManager.Create("Bool", "isCompletedPhase", cr2w, this);
				}
				return _isCompletedPhase;
			}
			set
			{
				if (_isCompletedPhase == value)
				{
					return;
				}
				_isCompletedPhase = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("fadeAnim")] 
		public CHandle<inkanimProxy> FadeAnim
		{
			get
			{
				if (_fadeAnim == null)
				{
					_fadeAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "fadeAnim", cr2w, this);
				}
				return _fadeAnim;
			}
			set
			{
				if (_fadeAnim == value)
				{
					return;
				}
				_fadeAnim = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("selectAnim")] 
		public CHandle<inkanimProxy> SelectAnim
		{
			get
			{
				if (_selectAnim == null)
				{
					_selectAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "selectAnim", cr2w, this);
				}
				return _selectAnim;
			}
			set
			{
				if (_selectAnim == value)
				{
					return;
				}
				_selectAnim = value;
				PropertySet(this);
			}
		}

		public gameuiBaseWorldMapMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
