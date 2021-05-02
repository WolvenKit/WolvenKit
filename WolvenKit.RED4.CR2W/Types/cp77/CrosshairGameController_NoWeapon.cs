using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_NoWeapon : gameuiCrosshairBaseGameController
	{
		private inkCompoundWidgetReference _aimDownSightContainer;
		private inkCompoundWidgetReference _zoomMovingContainer;
		private inkTextWidgetReference _zoomNumber;
		private inkTextWidgetReference _zoomNumberR;
		private inkImageWidgetReference _distanceImageRuler;
		private inkImageWidgetReference _zoomMoveBracketL;
		private inkImageWidgetReference _zoomMoveBracketR;
		private CString _zoomLevelString;
		private CHandle<gameIBlackboard> _playerSMBB;
		private CUInt32 _zoomLevelBBID;
		private CUInt32 _sceneTierBlackboardId;
		private CEnum<gamePSMHighLevel> _sceneTier;
		private CHandle<inkanimProxy> _zoomUpAnim;
		private CHandle<inkanimProxy> _animLockOn;
		private CHandle<inkanimProxy> _zoomDownAnim;
		private CHandle<inkanimProxy> _animLockOff;
		private CHandle<inkanimProxy> _zoomShowAnim;
		private CHandle<inkanimProxy> _zoomHideAnim;
		private CFloat _argZoomBuffered;

		[Ordinal(18)] 
		[RED("AimDownSightContainer")] 
		public inkCompoundWidgetReference AimDownSightContainer
		{
			get => GetProperty(ref _aimDownSightContainer);
			set => SetProperty(ref _aimDownSightContainer, value);
		}

		[Ordinal(19)] 
		[RED("ZoomMovingContainer")] 
		public inkCompoundWidgetReference ZoomMovingContainer
		{
			get => GetProperty(ref _zoomMovingContainer);
			set => SetProperty(ref _zoomMovingContainer, value);
		}

		[Ordinal(20)] 
		[RED("ZoomNumber")] 
		public inkTextWidgetReference ZoomNumber
		{
			get => GetProperty(ref _zoomNumber);
			set => SetProperty(ref _zoomNumber, value);
		}

		[Ordinal(21)] 
		[RED("ZoomNumberR")] 
		public inkTextWidgetReference ZoomNumberR
		{
			get => GetProperty(ref _zoomNumberR);
			set => SetProperty(ref _zoomNumberR, value);
		}

		[Ordinal(22)] 
		[RED("DistanceImageRuler")] 
		public inkImageWidgetReference DistanceImageRuler
		{
			get => GetProperty(ref _distanceImageRuler);
			set => SetProperty(ref _distanceImageRuler, value);
		}

		[Ordinal(23)] 
		[RED("ZoomMoveBracketL")] 
		public inkImageWidgetReference ZoomMoveBracketL
		{
			get => GetProperty(ref _zoomMoveBracketL);
			set => SetProperty(ref _zoomMoveBracketL, value);
		}

		[Ordinal(24)] 
		[RED("ZoomMoveBracketR")] 
		public inkImageWidgetReference ZoomMoveBracketR
		{
			get => GetProperty(ref _zoomMoveBracketR);
			set => SetProperty(ref _zoomMoveBracketR, value);
		}

		[Ordinal(25)] 
		[RED("ZoomLevelString")] 
		public CString ZoomLevelString
		{
			get => GetProperty(ref _zoomLevelString);
			set => SetProperty(ref _zoomLevelString, value);
		}

		[Ordinal(26)] 
		[RED("PlayerSMBB")] 
		public CHandle<gameIBlackboard> PlayerSMBB
		{
			get => GetProperty(ref _playerSMBB);
			set => SetProperty(ref _playerSMBB, value);
		}

		[Ordinal(27)] 
		[RED("ZoomLevelBBID")] 
		public CUInt32 ZoomLevelBBID
		{
			get => GetProperty(ref _zoomLevelBBID);
			set => SetProperty(ref _zoomLevelBBID, value);
		}

		[Ordinal(28)] 
		[RED("sceneTierBlackboardId")] 
		public CUInt32 SceneTierBlackboardId
		{
			get => GetProperty(ref _sceneTierBlackboardId);
			set => SetProperty(ref _sceneTierBlackboardId, value);
		}

		[Ordinal(29)] 
		[RED("sceneTier")] 
		public CEnum<gamePSMHighLevel> SceneTier
		{
			get => GetProperty(ref _sceneTier);
			set => SetProperty(ref _sceneTier, value);
		}

		[Ordinal(30)] 
		[RED("zoomUpAnim")] 
		public CHandle<inkanimProxy> ZoomUpAnim
		{
			get => GetProperty(ref _zoomUpAnim);
			set => SetProperty(ref _zoomUpAnim, value);
		}

		[Ordinal(31)] 
		[RED("animLockOn")] 
		public CHandle<inkanimProxy> AnimLockOn
		{
			get => GetProperty(ref _animLockOn);
			set => SetProperty(ref _animLockOn, value);
		}

		[Ordinal(32)] 
		[RED("zoomDownAnim")] 
		public CHandle<inkanimProxy> ZoomDownAnim
		{
			get => GetProperty(ref _zoomDownAnim);
			set => SetProperty(ref _zoomDownAnim, value);
		}

		[Ordinal(33)] 
		[RED("animLockOff")] 
		public CHandle<inkanimProxy> AnimLockOff
		{
			get => GetProperty(ref _animLockOff);
			set => SetProperty(ref _animLockOff, value);
		}

		[Ordinal(34)] 
		[RED("zoomShowAnim")] 
		public CHandle<inkanimProxy> ZoomShowAnim
		{
			get => GetProperty(ref _zoomShowAnim);
			set => SetProperty(ref _zoomShowAnim, value);
		}

		[Ordinal(35)] 
		[RED("zoomHideAnim")] 
		public CHandle<inkanimProxy> ZoomHideAnim
		{
			get => GetProperty(ref _zoomHideAnim);
			set => SetProperty(ref _zoomHideAnim, value);
		}

		[Ordinal(36)] 
		[RED("argZoomBuffered")] 
		public CFloat ArgZoomBuffered
		{
			get => GetProperty(ref _argZoomBuffered);
			set => SetProperty(ref _argZoomBuffered, value);
		}

		public CrosshairGameController_NoWeapon(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
