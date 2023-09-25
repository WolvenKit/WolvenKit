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
		[RED("individualControllerArray")] 
		public CArray<CWeakHandle<DamageDigitLogicController>> IndividualControllerArray
		{
			get => GetPropertyValue<CArray<CWeakHandle<DamageDigitLogicController>>>();
			set => SetPropertyValue<CArray<CWeakHandle<DamageDigitLogicController>>>(value);
		}

		[Ordinal(14)] 
		[RED("accumulatedControllerArray")] 
		public CArray<AccumulatedDamageDigitsNode> AccumulatedControllerArray
		{
			get => GetPropertyValue<CArray<AccumulatedDamageDigitsNode>>();
			set => SetPropertyValue<CArray<AccumulatedDamageDigitsNode>>(value);
		}

		[Ordinal(15)] 
		[RED("showDigitsIndividual")] 
		public CBool ShowDigitsIndividual
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(16)] 
		[RED("showDigitsAccumulated")] 
		public CBool ShowDigitsAccumulated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("damageDigitsStickingMode")] 
		public CEnum<gameuiDamageDigitsStickingMode> DamageDigitsStickingMode
		{
			get => GetPropertyValue<CEnum<gameuiDamageDigitsStickingMode>>();
			set => SetPropertyValue<CEnum<gameuiDamageDigitsStickingMode>>(value);
		}

		[Ordinal(18)] 
		[RED("spawnedDigits")] 
		public CInt32 SpawnedDigits
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(19)] 
		[RED("damageListBlackboardId")] 
		public CHandle<redCallbackObject> DamageListBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(20)] 
		[RED("damageDigitsModeBlackboardId")] 
		public CHandle<redCallbackObject> DamageDigitsModeBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(21)] 
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
			IndividualControllerArray = new();
			AccumulatedControllerArray = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
