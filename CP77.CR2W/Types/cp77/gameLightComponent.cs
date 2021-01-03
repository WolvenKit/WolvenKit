using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameLightComponent : entLightComponent
	{
		[Ordinal(0)]  [RED("colliderName")] public CName ColliderName { get; set; }
		[Ordinal(1)]  [RED("colliderTag")] public CName ColliderTag { get; set; }
		[Ordinal(2)]  [RED("destructionEffect")] public raRef<worldEffect> DestructionEffect { get; set; }
		[Ordinal(3)]  [RED("emissiveOnly")] public CBool EmissiveOnly { get; set; }
		[Ordinal(4)]  [RED("isDestructible")] public CBool IsDestructible { get; set; }
		[Ordinal(5)]  [RED("loopCurve")] public CName LoopCurve { get; set; }
		[Ordinal(6)]  [RED("loopTime")] public CFloat LoopTime { get; set; }
		[Ordinal(7)]  [RED("materialZone")] public CEnum<gameEMaterialZone> MaterialZone { get; set; }
		[Ordinal(8)]  [RED("meshBrokenAppearance")] public CName MeshBrokenAppearance { get; set; }
		[Ordinal(9)]  [RED("onStrength")] public CFloat OnStrength { get; set; }
		[Ordinal(10)]  [RED("turnOffCurve")] public CName TurnOffCurve { get; set; }
		[Ordinal(11)]  [RED("turnOffTime")] public CFloat TurnOffTime { get; set; }
		[Ordinal(12)]  [RED("turnOnByDefault")] public CBool TurnOnByDefault { get; set; }
		[Ordinal(13)]  [RED("turnOnCurve")] public CName TurnOnCurve { get; set; }
		[Ordinal(14)]  [RED("turnOnTime")] public CFloat TurnOnTime { get; set; }

		public gameLightComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
