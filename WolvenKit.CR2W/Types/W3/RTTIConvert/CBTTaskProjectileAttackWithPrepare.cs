using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskProjectileAttackWithPrepare : CBTTaskProjectileAttack
	{
		[Ordinal(0)] [RED("boneName")] 		public CName BoneName { get; set;}

		[Ordinal(0)] [RED("rawTarget")] 		public CBool RawTarget { get; set;}

		[Ordinal(0)] [RED("shootInFront")] 		public CBool ShootInFront { get; set;}

		[Ordinal(0)] [RED("shootInFrontOffset")] 		public CFloat ShootInFrontOffset { get; set;}

		public CBTTaskProjectileAttackWithPrepare(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskProjectileAttackWithPrepare(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}