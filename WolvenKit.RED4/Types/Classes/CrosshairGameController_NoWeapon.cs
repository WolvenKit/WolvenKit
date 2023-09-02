using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrosshairGameController_NoWeapon : gameuiCrosshairBaseGameController
	{
		[Ordinal(18)] 
		[RED("AimDownSightContainer")] 
		public inkCompoundWidgetReference AimDownSightContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("ZoomMovingContainer")] 
		public inkCompoundWidgetReference ZoomMovingContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("ZoomNumber")] 
		public inkTextWidgetReference ZoomNumber
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("ZoomNumberR")] 
		public inkTextWidgetReference ZoomNumberR
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("DistanceImageRuler")] 
		public inkImageWidgetReference DistanceImageRuler
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("ZoomMoveBracketL")] 
		public inkImageWidgetReference ZoomMoveBracketL
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("ZoomMoveBracketR")] 
		public inkImageWidgetReference ZoomMoveBracketR
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("ZoomLevelString")] 
		public CString ZoomLevelString
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(26)] 
		[RED("PlayerSMBB")] 
		public CWeakHandle<gameIBlackboard> PlayerSMBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(27)] 
		[RED("ZoomLevelBBID")] 
		public CHandle<redCallbackObject> ZoomLevelBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(28)] 
		[RED("sceneTierBlackboardId")] 
		public CHandle<redCallbackObject> SceneTierBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(29)] 
		[RED("sceneTier")] 
		public CEnum<gamePSMHighLevel> SceneTier
		{
			get => GetPropertyValue<CEnum<gamePSMHighLevel>>();
			set => SetPropertyValue<CEnum<gamePSMHighLevel>>(value);
		}

		[Ordinal(30)] 
		[RED("zoomUpAnim")] 
		public CHandle<inkanimProxy> ZoomUpAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(31)] 
		[RED("animLockOn")] 
		public CHandle<inkanimProxy> AnimLockOn
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(32)] 
		[RED("zoomDownAnim")] 
		public CHandle<inkanimProxy> ZoomDownAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(33)] 
		[RED("animLockOff")] 
		public CHandle<inkanimProxy> AnimLockOff
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(34)] 
		[RED("zoomShowAnim")] 
		public CHandle<inkanimProxy> ZoomShowAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(35)] 
		[RED("zoomHideAnim")] 
		public CHandle<inkanimProxy> ZoomHideAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(36)] 
		[RED("argZoomBuffered")] 
		public CFloat ArgZoomBuffered
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CrosshairGameController_NoWeapon()
		{
			AimDownSightContainer = new inkCompoundWidgetReference();
			ZoomMovingContainer = new inkCompoundWidgetReference();
			ZoomNumber = new inkTextWidgetReference();
			ZoomNumberR = new inkTextWidgetReference();
			DistanceImageRuler = new inkImageWidgetReference();
			ZoomMoveBracketL = new inkImageWidgetReference();
			ZoomMoveBracketR = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
