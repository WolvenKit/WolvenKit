using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameLightComponent : entLightComponent
	{
		[Ordinal(0)]  [RED("emissiveOnly")] public CBool EmissiveOnly { get; set; }
		[Ordinal(1)]  [RED("turnOnByDefault")] public CBool TurnOnByDefault { get; set; }
		[Ordinal(2)]  [RED("materialZone")] public CEnum<gameEMaterialZone> MaterialZone { get; set; }
		[Ordinal(3)]  [RED("meshBrokenAppearance")] public CName MeshBrokenAppearance { get; set; }
		[Ordinal(4)]  [RED("onStrength")] public CFloat OnStrength { get; set; }
		[Ordinal(5)]  [RED("turnOnTime")] public CFloat TurnOnTime { get; set; }
		[Ordinal(6)]  [RED("turnOnCurve")] public CName TurnOnCurve { get; set; }
		[Ordinal(7)]  [RED("turnOffTime")] public CFloat TurnOffTime { get; set; }
		[Ordinal(8)]  [RED("turnOffCurve")] public CName TurnOffCurve { get; set; }
		[Ordinal(9)]  [RED("loopTime")] public CFloat LoopTime { get; set; }
		[Ordinal(10)]  [RED("loopCurve")] public CName LoopCurve { get; set; }
		[Ordinal(11)]  [RED("isDestructible")] public CBool IsDestructible { get; set; }
		[Ordinal(12)]  [RED("colliderName")] public CName ColliderName { get; set; }
		[Ordinal(13)]  [RED("colliderTag")] public CName ColliderTag { get; set; }
		[Ordinal(14)]  [RED("destructionEffect")] public raRef<worldEffect> DestructionEffect { get; set; }

		public gameLightComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
