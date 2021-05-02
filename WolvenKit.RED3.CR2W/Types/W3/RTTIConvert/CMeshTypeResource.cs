using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMeshTypeResource : CResource
	{
		[Ordinal(1)] [RED("materialNames", 2,0)] 		public CArray<CString> MaterialNames { get; set;}

		[Ordinal(2)] [RED("authorName")] 		public CString AuthorName { get; set;}

		[Ordinal(3)] [RED("materials", 2,0)] 		public CArray<CHandle<IMaterial>> Materials { get; set;}

		[Ordinal(4)] [RED("boundingBox")] 		public Box BoundingBox { get; set;}

		[Ordinal(5)] [RED("autoHideDistance")] 		public CFloat AutoHideDistance { get; set;}

		[Ordinal(6)] [RED("isTwoSided")] 		public CBool IsTwoSided { get; set;}

		public CMeshTypeResource(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}