using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSbDescProdIdlePose : CVariable
	{
		[Ordinal(1)] [RED("("prodPoseId")] 		public CString ProdPoseId { get; set;}

		[Ordinal(2)] [RED("("prodActorId")] 		public CString ProdActorId { get; set;}

		[Ordinal(3)] [RED("("repoPoseId")] 		public CString RepoPoseId { get; set;}

		public SSbDescProdIdlePose(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSbDescProdIdlePose(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}