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
			get => GetProperty(ref _selected);
			set => SetProperty(ref _selected, value);
		}

		[Ordinal(12)] 
		[RED("inZoomLevel")] 
		public CBool InZoomLevel
		{
			get => GetProperty(ref _inZoomLevel);
			set => SetProperty(ref _inZoomLevel, value);
		}

		[Ordinal(13)] 
		[RED("inCustomFilter")] 
		public CBool InCustomFilter
		{
			get => GetProperty(ref _inCustomFilter);
			set => SetProperty(ref _inCustomFilter, value);
		}

		[Ordinal(14)] 
		[RED("hasCustomFilter")] 
		public CBool HasCustomFilter
		{
			get => GetProperty(ref _hasCustomFilter);
			set => SetProperty(ref _hasCustomFilter, value);
		}

		[Ordinal(15)] 
		[RED("isFastTravelEnabled")] 
		public CBool IsFastTravelEnabled
		{
			get => GetProperty(ref _isFastTravelEnabled);
			set => SetProperty(ref _isFastTravelEnabled, value);
		}

		[Ordinal(16)] 
		[RED("isVisibleInFilterAndZoom")] 
		public CBool IsVisibleInFilterAndZoom
		{
			get => GetProperty(ref _isVisibleInFilterAndZoom);
			set => SetProperty(ref _isVisibleInFilterAndZoom, value);
		}

		[Ordinal(17)] 
		[RED("groupState")] 
		public CEnum<gameuiMappinGroupState> GroupState
		{
			get => GetProperty(ref _groupState);
			set => SetProperty(ref _groupState, value);
		}

		[Ordinal(18)] 
		[RED("collectionCount")] 
		public CUInt8 CollectionCount
		{
			get => GetProperty(ref _collectionCount);
			set => SetProperty(ref _collectionCount, value);
		}

		[Ordinal(19)] 
		[RED("groupContainerWidget")] 
		public inkWidgetReference GroupContainerWidget
		{
			get => GetProperty(ref _groupContainerWidget);
			set => SetProperty(ref _groupContainerWidget, value);
		}

		[Ordinal(20)] 
		[RED("groupCountTextWidget")] 
		public inkTextWidgetReference GroupCountTextWidget
		{
			get => GetProperty(ref _groupCountTextWidget);
			set => SetProperty(ref _groupCountTextWidget, value);
		}

		[Ordinal(21)] 
		[RED("isNewContainer")] 
		public inkWidgetReference IsNewContainer
		{
			get => GetProperty(ref _isNewContainer);
			set => SetProperty(ref _isNewContainer, value);
		}

		[Ordinal(22)] 
		[RED("mappin")] 
		public wCHandle<gamemappinsIMappin> Mappin
		{
			get => GetProperty(ref _mappin);
			set => SetProperty(ref _mappin, value);
		}

		[Ordinal(23)] 
		[RED("isCompletedPhase")] 
		public CBool IsCompletedPhase
		{
			get => GetProperty(ref _isCompletedPhase);
			set => SetProperty(ref _isCompletedPhase, value);
		}

		[Ordinal(24)] 
		[RED("fadeAnim")] 
		public CHandle<inkanimProxy> FadeAnim
		{
			get => GetProperty(ref _fadeAnim);
			set => SetProperty(ref _fadeAnim, value);
		}

		[Ordinal(25)] 
		[RED("selectAnim")] 
		public CHandle<inkanimProxy> SelectAnim
		{
			get => GetProperty(ref _selectAnim);
			set => SetProperty(ref _selectAnim, value);
		}

		public gameuiBaseWorldMapMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
