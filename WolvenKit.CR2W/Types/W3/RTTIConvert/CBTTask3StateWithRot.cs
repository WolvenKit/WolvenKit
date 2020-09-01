using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTask3StateWithRot : CBTTask3StateAttack
	{
		[Ordinal(0)] [RED("("endLeft")] 		public CEnum<EAttackType> EndLeft { get; set;}

		[Ordinal(0)] [RED("("endRight")] 		public CEnum<EAttackType> EndRight { get; set;}

		public CBTTask3StateWithRot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTask3StateWithRot(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}