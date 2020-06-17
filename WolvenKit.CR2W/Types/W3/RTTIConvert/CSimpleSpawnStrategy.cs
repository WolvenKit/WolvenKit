using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSimpleSpawnStrategy : ISpawnTreeSpawnStrategy
	{
		[RED("minSpawnRange")] 		public CFloat MinSpawnRange { get; set;}

		[RED("visibilityTestRange")] 		public CFloat VisibilityTestRange { get; set;}

		[RED("maxSpawnRange")] 		public CFloat MaxSpawnRange { get; set;}

		[RED("canPoolOnSight")] 		public CBool CanPoolOnSight { get; set;}

		[RED("minPoolRange")] 		public CFloat MinPoolRange { get; set;}

		[RED("forcePoolRange")] 		public CFloat ForcePoolRange { get; set;}

		public CSimpleSpawnStrategy(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CSimpleSpawnStrategy(cr2w);

	}
}