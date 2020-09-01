using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class STargetSelectionWeights : CVariable
	{
		[Ordinal(0)] [RED("("angleWeight")] 		public CFloat AngleWeight { get; set;}

		[Ordinal(0)] [RED("("distanceWeight")] 		public CFloat DistanceWeight { get; set;}

		[Ordinal(0)] [RED("("distanceRingWeight")] 		public CFloat DistanceRingWeight { get; set;}

		public STargetSelectionWeights(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new STargetSelectionWeights(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}