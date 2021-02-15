using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_VehicleData : animAnimFeature
	{
		[Ordinal(0)] [RED("isInVehicle")] public CBool IsInVehicle { get; set; }
		[Ordinal(1)] [RED("isDriver")] public CBool IsDriver { get; set; }
		[Ordinal(2)] [RED("vehType")] public CInt32 VehType { get; set; }
		[Ordinal(3)] [RED("vehSlot")] public CInt32 VehSlot { get; set; }
		[Ordinal(4)] [RED("isInCombat")] public CBool IsInCombat { get; set; }
		[Ordinal(5)] [RED("isInWindowCombat")] public CBool IsInWindowCombat { get; set; }
		[Ordinal(6)] [RED("isInDriverCombat")] public CBool IsInDriverCombat { get; set; }
		[Ordinal(7)] [RED("vehClass")] public CInt32 VehClass { get; set; }
		[Ordinal(8)] [RED("isEnteringCombat")] public CBool IsEnteringCombat { get; set; }
		[Ordinal(9)] [RED("enteringCombatDuration")] public CFloat EnteringCombatDuration { get; set; }
		[Ordinal(10)] [RED("isExitingCombat")] public CBool IsExitingCombat { get; set; }
		[Ordinal(11)] [RED("exitingCombatDuration")] public CFloat ExitingCombatDuration { get; set; }
		[Ordinal(12)] [RED("isEnteringVehicle")] public CBool IsEnteringVehicle { get; set; }
		[Ordinal(13)] [RED("isExitingVehicle")] public CBool IsExitingVehicle { get; set; }
		[Ordinal(14)] [RED("isWorldRenderPlane")] public CBool IsWorldRenderPlane { get; set; }

		public AnimFeature_VehicleData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
