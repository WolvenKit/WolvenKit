using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entBakedDestructionComponent : entPhysicalMeshComponent
	{
		[Ordinal(0)]  [RED("accumulateDamage")] public CBool AccumulateDamage { get; set; }
		[Ordinal(1)]  [RED("audioMetadata")] public CName AudioMetadata { get; set; }
		[Ordinal(2)]  [RED("compiledBufferFractured")] public DataBuffer CompiledBufferFractured { get; set; }
		[Ordinal(3)]  [RED("contactToDamage")] public CFloat ContactToDamage { get; set; }
		[Ordinal(4)]  [RED("damageEndurance")] public CFloat DamageEndurance { get; set; }
		[Ordinal(5)]  [RED("damageThreshold")] public CFloat DamageThreshold { get; set; }
		[Ordinal(6)]  [RED("destructionEffect")] public raRef<worldEffect> DestructionEffect { get; set; }
		[Ordinal(7)]  [RED("disableCollidersOnTrigger")] public CBool DisableCollidersOnTrigger { get; set; }
		[Ordinal(8)]  [RED("frameRate")] public CFloat FrameRate { get; set; }
		[Ordinal(9)]  [RED("impulseToDamage")] public CFloat ImpulseToDamage { get; set; }
		[Ordinal(10)]  [RED("meshFractured")] public raRef<CMesh> MeshFractured { get; set; }
		[Ordinal(11)]  [RED("meshFracturedAppearance")] public CName MeshFracturedAppearance { get; set; }
		[Ordinal(12)]  [RED("numFrames")] public CFloat NumFrames { get; set; }
		[Ordinal(13)]  [RED("playOnlyOnce")] public CBool PlayOnlyOnce { get; set; }
		[Ordinal(14)]  [RED("restartOnTrigger")] public CBool RestartOnTrigger { get; set; }

		public entBakedDestructionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
