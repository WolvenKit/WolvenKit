using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSbDescEventLookAt : CVariable
	{
		[Ordinal(0)] [RED("("prodActorId")] 		public CString ProdActorId { get; set;}

		[Ordinal(0)] [RED("("lookAtProdActorId")] 		public CString LookAtProdActorId { get; set;}

		[Ordinal(0)] [RED("("pos")] 		public Vector Pos { get; set;}

		public SSbDescEventLookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSbDescEventLookAt(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}