using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DamageDigitsGameController : gameuiProjectedHUDGameController
	{
		private CInt32 _maxVisible;
		private CInt32 _maxAccumulatedVisible;
		private wCHandle<gameObject> _realOwner;
		private CHandle<inkScriptFIFOQueue> _digitsQueue;
		private CBool _isBeingUsed;
		private gameSlotWeaponData _activeWeapon;
		private CHandle<gameSlotDataHolder> _bufferedRosterData;
		private CArray<wCHandle<DamageDigitLogicController>> _individualControllerArray;
		private CArray<AccumulatedDamageDigitsNode> _accumulatedControllerArray;
		private CEnum<gameuiDamageDigitsMode> _damageDigitsMode;
		private CBool _showDigitsIndividual;
		private CBool _showDigitsAccumulated;
		private CEnum<gameuiDamageDigitsStickingMode> _damageDigitsStickingMode;
		private CInt32 _spawnedDigits;
		private CInt32 _spawnedAccumulatedDigitsDigits;
		private wCHandle<gameIBlackboard> _damageInfoBB;
		private wCHandle<gameIBlackboard> _uIBlackboard;
		private CHandle<redCallbackObject> _damageListBlackboardId;
		private CHandle<redCallbackObject> _bBWeaponListBlackboardId;
		private CHandle<redCallbackObject> _damageDigitsModeBlackboardId;
		private CHandle<redCallbackObject> _damageDigitsStickingModeBlackboardId;

		[Ordinal(9)] 
		[RED("maxVisible")] 
		public CInt32 MaxVisible
		{
			get => GetProperty(ref _maxVisible);
			set => SetProperty(ref _maxVisible, value);
		}

		[Ordinal(10)] 
		[RED("maxAccumulatedVisible")] 
		public CInt32 MaxAccumulatedVisible
		{
			get => GetProperty(ref _maxAccumulatedVisible);
			set => SetProperty(ref _maxAccumulatedVisible, value);
		}

		[Ordinal(11)] 
		[RED("realOwner")] 
		public wCHandle<gameObject> RealOwner
		{
			get => GetProperty(ref _realOwner);
			set => SetProperty(ref _realOwner, value);
		}

		[Ordinal(12)] 
		[RED("digitsQueue")] 
		public CHandle<inkScriptFIFOQueue> DigitsQueue
		{
			get => GetProperty(ref _digitsQueue);
			set => SetProperty(ref _digitsQueue, value);
		}

		[Ordinal(13)] 
		[RED("isBeingUsed")] 
		public CBool IsBeingUsed
		{
			get => GetProperty(ref _isBeingUsed);
			set => SetProperty(ref _isBeingUsed, value);
		}

		[Ordinal(14)] 
		[RED("ActiveWeapon")] 
		public gameSlotWeaponData ActiveWeapon
		{
			get => GetProperty(ref _activeWeapon);
			set => SetProperty(ref _activeWeapon, value);
		}

		[Ordinal(15)] 
		[RED("BufferedRosterData")] 
		public CHandle<gameSlotDataHolder> BufferedRosterData
		{
			get => GetProperty(ref _bufferedRosterData);
			set => SetProperty(ref _bufferedRosterData, value);
		}

		[Ordinal(16)] 
		[RED("individualControllerArray")] 
		public CArray<wCHandle<DamageDigitLogicController>> IndividualControllerArray
		{
			get => GetProperty(ref _individualControllerArray);
			set => SetProperty(ref _individualControllerArray, value);
		}

		[Ordinal(17)] 
		[RED("accumulatedControllerArray")] 
		public CArray<AccumulatedDamageDigitsNode> AccumulatedControllerArray
		{
			get => GetProperty(ref _accumulatedControllerArray);
			set => SetProperty(ref _accumulatedControllerArray, value);
		}

		[Ordinal(18)] 
		[RED("damageDigitsMode")] 
		public CEnum<gameuiDamageDigitsMode> DamageDigitsMode
		{
			get => GetProperty(ref _damageDigitsMode);
			set => SetProperty(ref _damageDigitsMode, value);
		}

		[Ordinal(19)] 
		[RED("showDigitsIndividual")] 
		public CBool ShowDigitsIndividual
		{
			get => GetProperty(ref _showDigitsIndividual);
			set => SetProperty(ref _showDigitsIndividual, value);
		}

		[Ordinal(20)] 
		[RED("showDigitsAccumulated")] 
		public CBool ShowDigitsAccumulated
		{
			get => GetProperty(ref _showDigitsAccumulated);
			set => SetProperty(ref _showDigitsAccumulated, value);
		}

		[Ordinal(21)] 
		[RED("damageDigitsStickingMode")] 
		public CEnum<gameuiDamageDigitsStickingMode> DamageDigitsStickingMode
		{
			get => GetProperty(ref _damageDigitsStickingMode);
			set => SetProperty(ref _damageDigitsStickingMode, value);
		}

		[Ordinal(22)] 
		[RED("spawnedDigits")] 
		public CInt32 SpawnedDigits
		{
			get => GetProperty(ref _spawnedDigits);
			set => SetProperty(ref _spawnedDigits, value);
		}

		[Ordinal(23)] 
		[RED("spawnedAccumulatedDigitsDigits")] 
		public CInt32 SpawnedAccumulatedDigitsDigits
		{
			get => GetProperty(ref _spawnedAccumulatedDigitsDigits);
			set => SetProperty(ref _spawnedAccumulatedDigitsDigits, value);
		}

		[Ordinal(24)] 
		[RED("damageInfoBB")] 
		public wCHandle<gameIBlackboard> DamageInfoBB
		{
			get => GetProperty(ref _damageInfoBB);
			set => SetProperty(ref _damageInfoBB, value);
		}

		[Ordinal(25)] 
		[RED("UIBlackboard")] 
		public wCHandle<gameIBlackboard> UIBlackboard
		{
			get => GetProperty(ref _uIBlackboard);
			set => SetProperty(ref _uIBlackboard, value);
		}

		[Ordinal(26)] 
		[RED("damageListBlackboardId")] 
		public CHandle<redCallbackObject> DamageListBlackboardId
		{
			get => GetProperty(ref _damageListBlackboardId);
			set => SetProperty(ref _damageListBlackboardId, value);
		}

		[Ordinal(27)] 
		[RED("BBWeaponListBlackboardId")] 
		public CHandle<redCallbackObject> BBWeaponListBlackboardId
		{
			get => GetProperty(ref _bBWeaponListBlackboardId);
			set => SetProperty(ref _bBWeaponListBlackboardId, value);
		}

		[Ordinal(28)] 
		[RED("damageDigitsModeBlackboardId")] 
		public CHandle<redCallbackObject> DamageDigitsModeBlackboardId
		{
			get => GetProperty(ref _damageDigitsModeBlackboardId);
			set => SetProperty(ref _damageDigitsModeBlackboardId, value);
		}

		[Ordinal(29)] 
		[RED("damageDigitsStickingModeBlackboardId")] 
		public CHandle<redCallbackObject> DamageDigitsStickingModeBlackboardId
		{
			get => GetProperty(ref _damageDigitsStickingModeBlackboardId);
			set => SetProperty(ref _damageDigitsStickingModeBlackboardId, value);
		}

		public DamageDigitsGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
