using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class ISpawnTreeInitializer : CObject
	{
		[Ordinal(1)] [RED("graphPosX")] 		public CInt32 GraphPosX { get; set;}

		[Ordinal(2)] [RED("graphPosY")] 		public CInt32 GraphPosY { get; set;}

		[Ordinal(3)] [RED("comment")] 		public CString Comment { get; set;}

		[Ordinal(4)] [RED("id")] 		public CUInt64 Id { get; set;}

		[Ordinal(5)] [RED("overrideDeepInitializers")] 		public CBool OverrideDeepInitializers { get; set;}

		public ISpawnTreeInitializer(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}