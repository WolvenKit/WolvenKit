using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMultiRangeSpawnStrategy : ISpawnTreeSpawnStrategy
	{
		[RED("primaryMinSpawnRange")] 		public CFloat PrimaryMinSpawnRange { get; set;}

		[RED("primaryMaxSpawnRange")] 		public CFloat PrimaryMaxSpawnRange { get; set;}

		[RED("visibilityTestRange")] 		public CFloat VisibilityTestRange { get; set;}

		[RED("primaryMinPoolRange")] 		public CFloat PrimaryMinPoolRange { get; set;}

		[RED("orientedRanges", 2,0)] 		public CArray<SSpawnStrategyRange> OrientedRanges { get; set;}

		[RED("canPoolOnSight")] 		public CBool CanPoolOnSight { get; set;}

		[RED("forcePoolRange")] 		public CFloat ForcePoolRange { get; set;}

		[RED("poolDelay")] 		public CFloat PoolDelay { get; set;}

		public CMultiRangeSpawnStrategy(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMultiRangeSpawnStrategy(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}