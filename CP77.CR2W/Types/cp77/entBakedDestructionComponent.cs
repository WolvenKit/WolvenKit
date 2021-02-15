using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entBakedDestructionComponent : entPhysicalMeshComponent
	{
		[Ordinal(28)] [RED("meshFractured")] public raRef<CMesh> MeshFractured { get; set; }
		[Ordinal(29)] [RED("meshFracturedAppearance")] public CName MeshFracturedAppearance { get; set; }
		[Ordinal(30)] [RED("numFrames")] public CFloat NumFrames { get; set; }
		[Ordinal(31)] [RED("frameRate")] public CFloat FrameRate { get; set; }
		[Ordinal(32)] [RED("playOnlyOnce")] public CBool PlayOnlyOnce { get; set; }
		[Ordinal(33)] [RED("restartOnTrigger")] public CBool RestartOnTrigger { get; set; }
		[Ordinal(34)] [RED("disableCollidersOnTrigger")] public CBool DisableCollidersOnTrigger { get; set; }
		[Ordinal(35)] [RED("damageThreshold")] public CFloat DamageThreshold { get; set; }
		[Ordinal(36)] [RED("damageEndurance")] public CFloat DamageEndurance { get; set; }
		[Ordinal(37)] [RED("impulseToDamage")] public CFloat ImpulseToDamage { get; set; }
		[Ordinal(38)] [RED("contactToDamage")] public CFloat ContactToDamage { get; set; }
		[Ordinal(39)] [RED("accumulateDamage")] public CBool AccumulateDamage { get; set; }
		[Ordinal(40)] [RED("destructionEffect")] public raRef<worldEffect> DestructionEffect { get; set; }
		[Ordinal(41)] [RED("audioMetadata")] public CName AudioMetadata { get; set; }
		[Ordinal(42)] [RED("compiledBufferFractured")] public DataBuffer CompiledBufferFractured { get; set; }

		public entBakedDestructionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
