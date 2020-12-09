using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSkyTransformEntity : CEntity
	{
		[Ordinal(1)] [RED("transformType")] 		public CEnum<ESkyTransformType> TransformType { get; set;}

		[Ordinal(2)] [RED("alignToPlayer")] 		public CBool AlignToPlayer { get; set;}

		[Ordinal(3)] [RED("onlyYaw")] 		public CBool OnlyYaw { get; set;}

		public CSkyTransformEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSkyTransformEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}