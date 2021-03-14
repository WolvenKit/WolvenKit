using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMultiRangeSpawnStrategy : ISpawnTreeSpawnStrategy
	{
		[Ordinal(1)] [RED("primaryMinSpawnRange")] 		public CFloat PrimaryMinSpawnRange { get; set;}

		[Ordinal(2)] [RED("primaryMaxSpawnRange")] 		public CFloat PrimaryMaxSpawnRange { get; set;}

		[Ordinal(3)] [RED("visibilityTestRange")] 		public CFloat VisibilityTestRange { get; set;}

		[Ordinal(4)] [RED("primaryMinPoolRange")] 		public CFloat PrimaryMinPoolRange { get; set;}

		[Ordinal(5)] [RED("orientedRanges", 2,0)] 		public CArray<SSpawnStrategyRange> OrientedRanges { get; set;}

		[Ordinal(6)] [RED("canPoolOnSight")] 		public CBool CanPoolOnSight { get; set;}

		[Ordinal(7)] [RED("forcePoolRange")] 		public CFloat ForcePoolRange { get; set;}

		[Ordinal(8)] [RED("poolDelay")] 		public CFloat PoolDelay { get; set;}

		public CMultiRangeSpawnStrategy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMultiRangeSpawnStrategy(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}