using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrosshairGameController_Smart_Rifl : gameuiCrosshairBaseGameController
	{
		[Ordinal(29)] 
		[RED("txtAccuracy")] 
		public inkTextWidgetReference TxtAccuracy
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("txtTargetsCount")] 
		public inkTextWidgetReference TxtTargetsCount
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("txtFluffStatus")] 
		public inkTextWidgetReference TxtFluffStatus
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("leftPart")] 
		public inkImageWidgetReference LeftPart
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("rightPart")] 
		public inkImageWidgetReference RightPart
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("leftPartExtra")] 
		public inkImageWidgetReference LeftPartExtra
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("rightPartExtra")] 
		public inkImageWidgetReference RightPartExtra
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("offsetLeftRight")] 
		public CFloat OffsetLeftRight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(37)] 
		[RED("offsetLeftRightExtra")] 
		public CFloat OffsetLeftRightExtra
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(38)] 
		[RED("latchVertical")] 
		public CFloat LatchVertical
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(39)] 
		[RED("topPart")] 
		public inkImageWidgetReference TopPart
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(40)] 
		[RED("bottomPart")] 
		public inkImageWidgetReference BottomPart
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("horiPart")] 
		public inkWidgetReference HoriPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(42)] 
		[RED("vertPart")] 
		public inkWidgetReference VertPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(43)] 
		[RED("targetWidgetLibraryName")] 
		public CName TargetWidgetLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(44)] 
		[RED("targetsPullSize")] 
		public CInt32 TargetsPullSize
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(45)] 
		[RED("targetColorChange")] 
		public inkWidgetReference TargetColorChange
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(46)] 
		[RED("targetingFrame")] 
		public inkWidgetReference TargetingFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(47)] 
		[RED("reticleFrame")] 
		public inkWidgetReference ReticleFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(48)] 
		[RED("bufferFrame")] 
		public inkWidgetReference BufferFrame
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(49)] 
		[RED("targetHolder")] 
		public inkCompoundWidgetReference TargetHolder
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(50)] 
		[RED("lockHolder")] 
		public inkCompoundWidgetReference LockHolder
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(51)] 
		[RED("reloadIndicator")] 
		public inkCompoundWidgetReference ReloadIndicator
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(52)] 
		[RED("reloadIndicatorInv")] 
		public inkCompoundWidgetReference ReloadIndicatorInv
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(53)] 
		[RED("smartLinkDot")] 
		public inkCompoundWidgetReference SmartLinkDot
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(54)] 
		[RED("smartLinkFrame")] 
		public inkCompoundWidgetReference SmartLinkFrame
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(55)] 
		[RED("smartLinkFluff")] 
		public inkCompoundWidgetReference SmartLinkFluff
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(56)] 
		[RED("smartLinkFirmwareOnline")] 
		public inkCompoundWidgetReference SmartLinkFirmwareOnline
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(57)] 
		[RED("smartLinkFirmwareOffline")] 
		public inkCompoundWidgetReference SmartLinkFirmwareOffline
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(58)] 
		[RED("hasSmartLink")] 
		public CBool HasSmartLink
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(59)] 
		[RED("weaponBlackboard")] 
		public CWeakHandle<gameIBlackboard> WeaponBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(60)] 
		[RED("weaponParamsListenerId")] 
		public CHandle<redCallbackObject> WeaponParamsListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(61)] 
		[RED("smartData")] 
		public CHandle<gamesmartGunUIParameters> SmartData
		{
			get => GetPropertyValue<CHandle<gamesmartGunUIParameters>>();
			set => SetPropertyValue<CHandle<gamesmartGunUIParameters>>(value);
		}

		[Ordinal(62)] 
		[RED("targetsPool")] 
		public CArray<CWeakHandle<inkWidget>> TargetsPool
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(63)] 
		[RED("targets")] 
		public CArray<CWeakHandle<inkWidget>> Targets
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(64)] 
		[RED("isBlocked")] 
		public CBool IsBlocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(65)] 
		[RED("isAimDownSights")] 
		public CBool IsAimDownSights
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(66)] 
		[RED("bufferedSpread")] 
		public Vector2 BufferedSpread
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(67)] 
		[RED("reloadAnimationProxy")] 
		public CHandle<inkanimProxy> ReloadAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(68)] 
		[RED("prevTargetedEntityIDs")] 
		public CArray<entEntityID> PrevTargetedEntityIDs
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		[Ordinal(69)] 
		[RED("currTargetedEntityIDs")] 
		public CArray<entEntityID> CurrTargetedEntityIDs
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		[Ordinal(70)] 
		[RED("numLockedTargets")] 
		public CInt32 NumLockedTargets
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(71)] 
		[RED("playerDevelopmentData")] 
		public CWeakHandle<PlayerDevelopmentData> PlayerDevelopmentData
		{
			get => GetPropertyValue<CWeakHandle<PlayerDevelopmentData>>();
			set => SetPropertyValue<CWeakHandle<PlayerDevelopmentData>>(value);
		}

		public CrosshairGameController_Smart_Rifl()
		{
			TxtAccuracy = new inkTextWidgetReference();
			TxtTargetsCount = new inkTextWidgetReference();
			TxtFluffStatus = new inkTextWidgetReference();
			LeftPart = new inkImageWidgetReference();
			RightPart = new inkImageWidgetReference();
			LeftPartExtra = new inkImageWidgetReference();
			RightPartExtra = new inkImageWidgetReference();
			OffsetLeftRight = 0.800000F;
			OffsetLeftRightExtra = 1.200000F;
			LatchVertical = 40.000000F;
			TopPart = new inkImageWidgetReference();
			BottomPart = new inkImageWidgetReference();
			HoriPart = new inkWidgetReference();
			VertPart = new inkWidgetReference();
			TargetWidgetLibraryName = "bucket";
			TargetsPullSize = 10;
			TargetColorChange = new inkWidgetReference();
			TargetingFrame = new inkWidgetReference();
			ReticleFrame = new inkWidgetReference();
			BufferFrame = new inkWidgetReference();
			TargetHolder = new inkCompoundWidgetReference();
			LockHolder = new inkCompoundWidgetReference();
			ReloadIndicator = new inkCompoundWidgetReference();
			ReloadIndicatorInv = new inkCompoundWidgetReference();
			SmartLinkDot = new inkCompoundWidgetReference();
			SmartLinkFrame = new inkCompoundWidgetReference();
			SmartLinkFluff = new inkCompoundWidgetReference();
			SmartLinkFirmwareOnline = new inkCompoundWidgetReference();
			SmartLinkFirmwareOffline = new inkCompoundWidgetReference();
			TargetsPool = new();
			Targets = new();
			BufferedSpread = new Vector2();
			PrevTargetedEntityIDs = new();
			CurrTargetedEntityIDs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
