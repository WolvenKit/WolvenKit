using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskProjectileAttackWithPrepareDef : CBTTaskProjectileAttackDef
	{
		[RED("boneName")] 		public CName BoneName { get; set;}

		[RED("shootInFront")] 		public CBool ShootInFront { get; set;}

		[RED("shootInFrontOffset")] 		public CFloat ShootInFrontOffset { get; set;}

		[RED("rawTarget")] 		public CBool RawTarget { get; set;}

		[RED("useLookAtBone")] 		public CBool UseLookAtBone { get; set;}

		[RED("lookAtBone")] 		public CName LookAtBone { get; set;}

		public CBTTaskProjectileAttackWithPrepareDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskProjectileAttackWithPrepareDef(cr2w);

	}
}