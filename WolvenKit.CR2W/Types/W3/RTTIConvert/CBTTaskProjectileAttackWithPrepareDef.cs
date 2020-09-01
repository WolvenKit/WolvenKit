using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskProjectileAttackWithPrepareDef : CBTTaskProjectileAttackDef
	{
		[Ordinal(0)] [RED("boneName")] 		public CName BoneName { get; set;}

		[Ordinal(0)] [RED("shootInFront")] 		public CBool ShootInFront { get; set;}

		[Ordinal(0)] [RED("shootInFrontOffset")] 		public CFloat ShootInFrontOffset { get; set;}

		[Ordinal(0)] [RED("rawTarget")] 		public CBool RawTarget { get; set;}

		[Ordinal(0)] [RED("useLookAtBone")] 		public CBool UseLookAtBone { get; set;}

		[Ordinal(0)] [RED("lookAtBone")] 		public CName LookAtBone { get; set;}

		public CBTTaskProjectileAttackWithPrepareDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskProjectileAttackWithPrepareDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}