using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSimpleSpawnStrategy : ISpawnTreeSpawnStrategy
	{
		[Ordinal(1)] [RED("minSpawnRange")] 		public CFloat MinSpawnRange { get; set;}

		[Ordinal(2)] [RED("visibilityTestRange")] 		public CFloat VisibilityTestRange { get; set;}

		[Ordinal(3)] [RED("maxSpawnRange")] 		public CFloat MaxSpawnRange { get; set;}

		[Ordinal(4)] [RED("canPoolOnSight")] 		public CBool CanPoolOnSight { get; set;}

		[Ordinal(5)] [RED("minPoolRange")] 		public CFloat MinPoolRange { get; set;}

		[Ordinal(6)] [RED("forcePoolRange")] 		public CFloat ForcePoolRange { get; set;}

		public CSimpleSpawnStrategy(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSimpleSpawnStrategy(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}