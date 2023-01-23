using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DamageDigitsGameController : gameuiProjectedHUDGameController
	{
		[Ordinal(9)] 
		[RED("maxVisible")] 
		public CInt32 MaxVisible
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("maxAccumulatedVisible")] 
		public CInt32 MaxAccumulatedVisible
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("realOwner")] 
		public CWeakHandle<gameObject> RealOwner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(12)] 
		[RED("digitsQueue")] 
		public CHandle<inkScriptFIFOQueue> DigitsQueue
		{
			get => GetPropertyValue<CHandle<inkScriptFIFOQueue>>();
			set => SetPropertyValue<CHandle<inkScriptFIFOQueue>>(value);
		}

		[Ordinal(13)] 
		[RED("isBeingUsed")] 
		public CBool IsBeingUsed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("ActiveWeapon")] 
		public gameSlotWeaponData ActiveWeapon
		{
			get => GetPropertyValue<gameSlotWeaponData>();
			set => SetPropertyValue<gameSlotWeaponData>(value);
		}

		[Ordinal(15)] 
		[RED("BufferedRosterData")] 
		public CHandle<gameSlotDataHolder> BufferedRosterData
		{
			get => GetPropertyValue<CHandle<gameSlotDataHolder>>();
			set => SetPropertyValue<CHandle<gameSlotDataHolder>>(value);
		}

		[Ordinal(16)] 
		[RED("individualControllerArray")] 
		public CArray<CWeakHandle<DamageDigitLogicController>> IndividualControllerArray
		{
			get => GetPropertyValue<CArray<CWeakHandle<DamageDigitLogicController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<DamageDigitLogicController>>>(value);
		}

		[Ordinal(17)] 
		[RED("accumulatedControllerArray")] 
		public CArray<AccumulatedDamageDigitsNode> AccumulatedControllerArray
		{
			get => GetPropertyValue<CArray<AccumulatedDamageDigitsNode>>();
			set => SetPropertyValue<CArray<AccumulatedDamageDigitsNode>>(value);
		}

		[Ordinal(18)] 
		[RED("damageDigitsMode")] 
		public CEnum<gameuiDamageDigitsMode> DamageDigitsMode
		{
			get => GetPropertyValue<CEnum<gameuiDamageDigitsMode>>();
			set => SetPropertyValue<CEnum<gameuiDamageDigitsMode>>(value);
		}

		[Ordinal(19)] 
		[RED("showDigitsIndividual")] 
		public CBool ShowDigitsIndividual
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("showDigitsAccumulated")] 
		public CBool ShowDigitsAccumulated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("damageDigitsStickingMode")] 
		public CEnum<gameuiDamageDigitsStickingMode> DamageDigitsStickingMode
		{
			get => GetPropertyValue<CEnum<gameuiDamageDigitsStickingMode>>();
			set => SetPropertyValue<CEnum<gameuiDamageDigitsStickingMode>>(value);
		}

		[Ordinal(22)] 
		[RED("spawnedDigits")] 
		public CInt32 SpawnedDigits
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(23)] 
		[RED("spawnedAccumulatedDigitsDigits")] 
		public CInt32 SpawnedAccumulatedDigitsDigits
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(24)] 
		[RED("damageInfoBB")] 
		public CWeakHandle<gameIBlackboard> DamageInfoBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(25)] 
		[RED("UIBlackboard")] 
		public CWeakHandle<gameIBlackboard> UIBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(26)] 
		[RED("damageListBlackboardId")] 
		public CHandle<redCallbackObject> DamageListBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(27)] 
		[RED("BBWeaponListBlackboardId")] 
		public CHandle<redCallbackObject> BBWeaponListBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(28)] 
		[RED("damageDigitsModeBlackboardId")] 
		public CHandle<redCallbackObject> DamageDigitsModeBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(29)] 
		[RED("damageDigitsStickingModeBlackboardId")] 
		public CHandle<redCallbackObject> DamageDigitsStickingModeBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public DamageDigitsGameController()
		{
			MaxVisible = 50;
			MaxAccumulatedVisible = 10;
			ActiveWeapon = new() { WeaponID = new(), AmmoCurrent = -1, MagazineCap = -1, AmmoId = new(), TriggerModeCurrent = Enums.gamedataTriggerMode.Invalid, TriggerModeList = new(), Evolution = Enums.gamedataWeaponEvolution.Invalid, IsFirstEquip = true };
			IndividualControllerArray = new();
			AccumulatedControllerArray = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
