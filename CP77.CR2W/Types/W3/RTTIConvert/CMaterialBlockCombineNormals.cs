using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMaterialBlockCombineNormals : CMaterialBlock
	{
		[Ordinal(1)] [RED("firstWeight")] 		public CFloat FirstWeight { get; set;}

		[Ordinal(2)] [RED("secondWeight")] 		public CFloat SecondWeight { get; set;}

		[Ordinal(3)] [RED("tangentToWorld")] 		public CBool TangentToWorld { get; set;}

		public CMaterialBlockCombineNormals(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMaterialBlockCombineNormals(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}