using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionDamageRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("isInternal")] 
		public CBool IsInternal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("damageDealtPercentValue")] 
		public CFloat DamageDealtPercentValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(3)] 
		[RED("targetPosition")] 
		public Vector4 TargetPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(4)] 
		[RED("isTargetKilled")] 
		public CBool IsTargetKilled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isTargetPrevention")] 
		public CBool IsTargetPrevention
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("isTargetVehicle")] 
		public CBool IsTargetVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("requestedHeat")] 
		public CEnum<EPreventionHeatStage> RequestedHeat
		{
			get => GetPropertyValue<CEnum<EPreventionHeatStage>>();
			set => SetPropertyValue<CEnum<EPreventionHeatStage>>(value);
		}

		[Ordinal(8)] 
		[RED("attackType")] 
		public CEnum<gamedataAttackType> AttackType
		{
			get => GetPropertyValue<CEnum<gamedataAttackType>>();
			set => SetPropertyValue<CEnum<gamedataAttackType>>(value);
		}

		[Ordinal(9)] 
		[RED("telemetryInfo")] 
		public CString TelemetryInfo
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public PreventionDamageRequest()
		{
			TargetID = new entEntityID();
			TargetPosition = new Vector4();
			RequestedHeat = Enums.EPreventionHeatStage.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
