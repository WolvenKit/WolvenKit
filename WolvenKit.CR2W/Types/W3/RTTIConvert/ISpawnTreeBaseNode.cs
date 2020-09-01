using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class ISpawnTreeBaseNode : CObject
	{
		[Ordinal(1)] [RED("("nodeName")] 		public CName NodeName { get; set;}

		[Ordinal(2)] [RED("("id")] 		public CUInt64 Id { get; set;}

		[Ordinal(3)] [RED("("graphPosX")] 		public CInt32 GraphPosX { get; set;}

		[Ordinal(4)] [RED("("graphPosY")] 		public CInt32 GraphPosY { get; set;}

		[Ordinal(5)] [RED("("comment")] 		public CString Comment { get; set;}

		public ISpawnTreeBaseNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new ISpawnTreeBaseNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}