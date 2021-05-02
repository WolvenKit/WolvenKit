using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskProjectileAttackWithPrepareDef : CBTTaskProjectileAttackDef
	{
		[Ordinal(1)] [RED("boneName")] 		public CName BoneName { get; set;}

		[Ordinal(2)] [RED("shootInFront")] 		public CBool ShootInFront { get; set;}

		[Ordinal(3)] [RED("shootInFrontOffset")] 		public CFloat ShootInFrontOffset { get; set;}

		[Ordinal(4)] [RED("rawTarget")] 		public CBool RawTarget { get; set;}

		[Ordinal(5)] [RED("useLookAtBone")] 		public CBool UseLookAtBone { get; set;}

		[Ordinal(6)] [RED("lookAtBone")] 		public CName LookAtBone { get; set;}

		public CBTTaskProjectileAttackWithPrepareDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskProjectileAttackWithPrepareDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}