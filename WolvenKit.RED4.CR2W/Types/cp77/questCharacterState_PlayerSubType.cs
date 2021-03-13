using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterState_PlayerSubType : questICharacterConditionSubType
	{
		[Ordinal(0)] [RED("locomotionComparisonType")] public CEnum<questEComparisonTypeEquality> LocomotionComparisonType { get; set; }
		[Ordinal(1)] [RED("locomotionState")] public CEnum<gamePSMLocomotionStates> LocomotionState { get; set; }
		[Ordinal(2)] [RED("upperBodyComparisonType")] public CEnum<questEComparisonTypeEquality> UpperBodyComparisonType { get; set; }
		[Ordinal(3)] [RED("upperBodyState")] public CEnum<gamePSMUpperBodyStates> UpperBodyState { get; set; }
		[Ordinal(4)] [RED("weaponComparisonType")] public CEnum<questEComparisonTypeEquality> WeaponComparisonType { get; set; }
		[Ordinal(5)] [RED("weaponState")] public CEnum<gamePSMWeaponStates> WeaponState { get; set; }
		[Ordinal(6)] [RED("timeDilationComparisonType")] public CEnum<questEComparisonTypeEquality> TimeDilationComparisonType { get; set; }
		[Ordinal(7)] [RED("timeDilationState")] public CEnum<gamePSMTimeDilation> TimeDilationState { get; set; }
		[Ordinal(8)] [RED("vehicleComparisonType")] public CEnum<questEComparisonTypeEquality> VehicleComparisonType { get; set; }
		[Ordinal(9)] [RED("vehicleState")] public CEnum<gamePSMVehicle> VehicleState { get; set; }
		[Ordinal(10)] [RED("takedownStateComparisonType")] public CEnum<questEComparisonTypeEquality> TakedownStateComparisonType { get; set; }
		[Ordinal(11)] [RED("takedownState")] public CEnum<gamePSMTakedown> TakedownState { get; set; }

		public questCharacterState_PlayerSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
