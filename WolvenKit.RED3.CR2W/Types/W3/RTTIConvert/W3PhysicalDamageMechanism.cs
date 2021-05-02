using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3PhysicalDamageMechanism : CGameplayEntity
	{
		[Ordinal(1)] [RED("dmgValue")] 		public CFloat DmgValue { get; set;}

		[Ordinal(2)] [RED("hitReactionType")] 		public CEnum<EHitReactionType> HitReactionType { get; set;}

		[Ordinal(3)] [RED("reactivationTimer")] 		public CFloat ReactivationTimer { get; set;}

		[Ordinal(4)] [RED("animName")] 		public CName AnimName { get; set;}

		[Ordinal(5)] [RED("shouldRewind")] 		public CBool ShouldRewind { get; set;}

		[Ordinal(6)] [RED("isActive")] 		public CBool IsActive { get; set;}

		[Ordinal(7)] [RED("isMoving")] 		public CBool IsMoving { get; set;}

		public W3PhysicalDamageMechanism(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}