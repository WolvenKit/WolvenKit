using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Launcher : gameuiCrosshairBaseGameController
	{
		private CHandle<gameIBlackboard> _weaponLocalBB;
		private CUInt32 _weaponBBID;
		private CHandle<inkanimProxy> _animationProxy;
		private inkCanvasWidgetReference _cori_S;
		private inkCanvasWidgetReference _cori_M;
		private CFloat _rightStickX;
		private CFloat _rightStickY;

		[Ordinal(18)] 
		[RED("weaponLocalBB")] 
		public CHandle<gameIBlackboard> WeaponLocalBB
		{
			get => GetProperty(ref _weaponLocalBB);
			set => SetProperty(ref _weaponLocalBB, value);
		}

		[Ordinal(19)] 
		[RED("weaponBBID")] 
		public CUInt32 WeaponBBID
		{
			get => GetProperty(ref _weaponBBID);
			set => SetProperty(ref _weaponBBID, value);
		}

		[Ordinal(20)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(21)] 
		[RED("Cori_S")] 
		public inkCanvasWidgetReference Cori_S
		{
			get => GetProperty(ref _cori_S);
			set => SetProperty(ref _cori_S, value);
		}

		[Ordinal(22)] 
		[RED("Cori_M")] 
		public inkCanvasWidgetReference Cori_M
		{
			get => GetProperty(ref _cori_M);
			set => SetProperty(ref _cori_M, value);
		}

		[Ordinal(23)] 
		[RED("rightStickX")] 
		public CFloat RightStickX
		{
			get => GetProperty(ref _rightStickX);
			set => SetProperty(ref _rightStickX, value);
		}

		[Ordinal(24)] 
		[RED("rightStickY")] 
		public CFloat RightStickY
		{
			get => GetProperty(ref _rightStickY);
			set => SetProperty(ref _rightStickY, value);
		}

		public CrosshairGameController_Launcher(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
