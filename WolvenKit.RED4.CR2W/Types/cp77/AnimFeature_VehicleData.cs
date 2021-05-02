using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_VehicleData : animAnimFeature
	{
		private CBool _isInVehicle;
		private CBool _isDriver;
		private CInt32 _vehType;
		private CInt32 _vehSlot;
		private CBool _isInCombat;
		private CBool _isInWindowCombat;
		private CBool _isInDriverCombat;
		private CInt32 _vehClass;
		private CBool _isEnteringCombat;
		private CFloat _enteringCombatDuration;
		private CBool _isExitingCombat;
		private CFloat _exitingCombatDuration;
		private CBool _isEnteringVehicle;
		private CBool _isExitingVehicle;
		private CBool _isWorldRenderPlane;

		[Ordinal(0)] 
		[RED("isInVehicle")] 
		public CBool IsInVehicle
		{
			get => GetProperty(ref _isInVehicle);
			set => SetProperty(ref _isInVehicle, value);
		}

		[Ordinal(1)] 
		[RED("isDriver")] 
		public CBool IsDriver
		{
			get => GetProperty(ref _isDriver);
			set => SetProperty(ref _isDriver, value);
		}

		[Ordinal(2)] 
		[RED("vehType")] 
		public CInt32 VehType
		{
			get => GetProperty(ref _vehType);
			set => SetProperty(ref _vehType, value);
		}

		[Ordinal(3)] 
		[RED("vehSlot")] 
		public CInt32 VehSlot
		{
			get => GetProperty(ref _vehSlot);
			set => SetProperty(ref _vehSlot, value);
		}

		[Ordinal(4)] 
		[RED("isInCombat")] 
		public CBool IsInCombat
		{
			get => GetProperty(ref _isInCombat);
			set => SetProperty(ref _isInCombat, value);
		}

		[Ordinal(5)] 
		[RED("isInWindowCombat")] 
		public CBool IsInWindowCombat
		{
			get => GetProperty(ref _isInWindowCombat);
			set => SetProperty(ref _isInWindowCombat, value);
		}

		[Ordinal(6)] 
		[RED("isInDriverCombat")] 
		public CBool IsInDriverCombat
		{
			get => GetProperty(ref _isInDriverCombat);
			set => SetProperty(ref _isInDriverCombat, value);
		}

		[Ordinal(7)] 
		[RED("vehClass")] 
		public CInt32 VehClass
		{
			get => GetProperty(ref _vehClass);
			set => SetProperty(ref _vehClass, value);
		}

		[Ordinal(8)] 
		[RED("isEnteringCombat")] 
		public CBool IsEnteringCombat
		{
			get => GetProperty(ref _isEnteringCombat);
			set => SetProperty(ref _isEnteringCombat, value);
		}

		[Ordinal(9)] 
		[RED("enteringCombatDuration")] 
		public CFloat EnteringCombatDuration
		{
			get => GetProperty(ref _enteringCombatDuration);
			set => SetProperty(ref _enteringCombatDuration, value);
		}

		[Ordinal(10)] 
		[RED("isExitingCombat")] 
		public CBool IsExitingCombat
		{
			get => GetProperty(ref _isExitingCombat);
			set => SetProperty(ref _isExitingCombat, value);
		}

		[Ordinal(11)] 
		[RED("exitingCombatDuration")] 
		public CFloat ExitingCombatDuration
		{
			get => GetProperty(ref _exitingCombatDuration);
			set => SetProperty(ref _exitingCombatDuration, value);
		}

		[Ordinal(12)] 
		[RED("isEnteringVehicle")] 
		public CBool IsEnteringVehicle
		{
			get => GetProperty(ref _isEnteringVehicle);
			set => SetProperty(ref _isEnteringVehicle, value);
		}

		[Ordinal(13)] 
		[RED("isExitingVehicle")] 
		public CBool IsExitingVehicle
		{
			get => GetProperty(ref _isExitingVehicle);
			set => SetProperty(ref _isExitingVehicle, value);
		}

		[Ordinal(14)] 
		[RED("isWorldRenderPlane")] 
		public CBool IsWorldRenderPlane
		{
			get => GetProperty(ref _isWorldRenderPlane);
			set => SetProperty(ref _isWorldRenderPlane, value);
		}

		public AnimFeature_VehicleData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
