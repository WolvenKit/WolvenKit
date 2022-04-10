using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiBaseWorldMapMappinController : gameuiInteractionMappinController
	{
		[Ordinal(11)] 
		[RED("selected")] 
		public CBool Selected
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("inZoomLevel")] 
		public CBool InZoomLevel
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("inCustomFilter")] 
		public CBool InCustomFilter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("hasCustomFilter")] 
		public CBool HasCustomFilter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("isFastTravelEnabled")] 
		public CBool IsFastTravelEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("isVisibleInFilterAndZoom")] 
		public CBool IsVisibleInFilterAndZoom
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("groupState")] 
		public CEnum<gameuiMappinGroupState> GroupState
		{
			get => GetPropertyValue<CEnum<gameuiMappinGroupState>>();
			set => SetPropertyValue<CEnum<gameuiMappinGroupState>>(value);
		}

		[Ordinal(18)] 
		[RED("collectionCount")] 
		public CUInt8 CollectionCount
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(19)] 
		[RED("groupContainerWidget")] 
		public inkWidgetReference GroupContainerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("groupCountTextWidget")] 
		public inkTextWidgetReference GroupCountTextWidget
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("mappin")] 
		public CWeakHandle<gamemappinsIMappin> Mappin
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsIMappin>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsIMappin>>(value);
		}

		[Ordinal(22)] 
		[RED("isCompletedPhase")] 
		public CBool IsCompletedPhase
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("resetStateWhenUntracked")] 
		public CBool ResetStateWhenUntracked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("isNewAnim")] 
		public CHandle<inkanimProxy> IsNewAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(25)] 
		[RED("fadeAnim")] 
		public CHandle<inkanimProxy> FadeAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(26)] 
		[RED("selectAnim")] 
		public CHandle<inkanimProxy> SelectAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(27)] 
		[RED("fadeInOutDelay")] 
		public CFloat FadeInOutDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiBaseWorldMapMappinController()
		{
			CollectionCount = 1;
			GroupContainerWidget = new();
			GroupCountTextWidget = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
