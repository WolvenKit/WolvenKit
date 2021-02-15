using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameLightComponent : entLightComponent
	{
		[Ordinal(54)] [RED("emissiveOnly")] public CBool EmissiveOnly { get; set; }
		[Ordinal(55)] [RED("materialZone")] public CEnum<gameEMaterialZone> MaterialZone { get; set; }
		[Ordinal(56)] [RED("meshBrokenAppearance")] public CName MeshBrokenAppearance { get; set; }
		[Ordinal(57)] [RED("onStrength")] public CFloat OnStrength { get; set; }
		[Ordinal(58)] [RED("turnOnByDefault")] public CBool TurnOnByDefault { get; set; }
		[Ordinal(59)] [RED("turnOnTime")] public CFloat TurnOnTime { get; set; }
		[Ordinal(60)] [RED("turnOnCurve")] public CName TurnOnCurve { get; set; }
		[Ordinal(61)] [RED("turnOffTime")] public CFloat TurnOffTime { get; set; }
		[Ordinal(62)] [RED("turnOffCurve")] public CName TurnOffCurve { get; set; }
		[Ordinal(63)] [RED("loopTime")] public CFloat LoopTime { get; set; }
		[Ordinal(64)] [RED("loopCurve")] public CName LoopCurve { get; set; }
		[Ordinal(65)] [RED("isDestructible")] public CBool IsDestructible { get; set; }
		[Ordinal(66)] [RED("colliderName")] public CName ColliderName { get; set; }
		[Ordinal(67)] [RED("colliderTag")] public CName ColliderTag { get; set; }
		[Ordinal(68)] [RED("destructionEffect")] public raRef<worldEffect> DestructionEffect { get; set; }

		public gameLightComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
