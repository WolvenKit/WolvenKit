using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSimpleSpawnStrategy : ISpawnTreeSpawnStrategy
	{
		[Ordinal(0)] [RED("minSpawnRange")] 		public CFloat MinSpawnRange { get; set;}

		[Ordinal(0)] [RED("visibilityTestRange")] 		public CFloat VisibilityTestRange { get; set;}

		[Ordinal(0)] [RED("maxSpawnRange")] 		public CFloat MaxSpawnRange { get; set;}

		[Ordinal(0)] [RED("canPoolOnSight")] 		public CBool CanPoolOnSight { get; set;}

		[Ordinal(0)] [RED("minPoolRange")] 		public CFloat MinPoolRange { get; set;}

		[Ordinal(0)] [RED("forcePoolRange")] 		public CFloat ForcePoolRange { get; set;}

		public CSimpleSpawnStrategy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSimpleSpawnStrategy(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}