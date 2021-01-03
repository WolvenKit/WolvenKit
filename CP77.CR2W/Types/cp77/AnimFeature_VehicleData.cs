using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_VehicleData : animAnimFeature
	{
		[Ordinal(0)]  [RED("enteringCombatDuration")] public CFloat EnteringCombatDuration { get; set; }
		[Ordinal(1)]  [RED("exitingCombatDuration")] public CFloat ExitingCombatDuration { get; set; }
		[Ordinal(2)]  [RED("isDriver")] public CBool IsDriver { get; set; }
		[Ordinal(3)]  [RED("isEnteringCombat")] public CBool IsEnteringCombat { get; set; }
		[Ordinal(4)]  [RED("isEnteringVehicle")] public CBool IsEnteringVehicle { get; set; }
		[Ordinal(5)]  [RED("isExitingCombat")] public CBool IsExitingCombat { get; set; }
		[Ordinal(6)]  [RED("isExitingVehicle")] public CBool IsExitingVehicle { get; set; }
		[Ordinal(7)]  [RED("isInCombat")] public CBool IsInCombat { get; set; }
		[Ordinal(8)]  [RED("isInDriverCombat")] public CBool IsInDriverCombat { get; set; }
		[Ordinal(9)]  [RED("isInVehicle")] public CBool IsInVehicle { get; set; }
		[Ordinal(10)]  [RED("isInWindowCombat")] public CBool IsInWindowCombat { get; set; }
		[Ordinal(11)]  [RED("isWorldRenderPlane")] public CBool IsWorldRenderPlane { get; set; }
		[Ordinal(12)]  [RED("vehClass")] public CInt32 VehClass { get; set; }
		[Ordinal(13)]  [RED("vehSlot")] public CInt32 VehSlot { get; set; }
		[Ordinal(14)]  [RED("vehType")] public CInt32 VehType { get; set; }

		public AnimFeature_VehicleData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
