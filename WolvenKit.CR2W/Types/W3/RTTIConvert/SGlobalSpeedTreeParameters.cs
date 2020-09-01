using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SGlobalSpeedTreeParameters : CVariable
	{
		[Ordinal(1)] [RED("("alphaScalar3d")] 		public CFloat AlphaScalar3d { get; set;}

		[Ordinal(2)] [RED("("alphaScalarGrassNear")] 		public CFloat AlphaScalarGrassNear { get; set;}

		[Ordinal(3)] [RED("("alphaScalarGrass")] 		public CFloat AlphaScalarGrass { get; set;}

		[Ordinal(4)] [RED("("alphaScalarGrassDistNear")] 		public CFloat AlphaScalarGrassDistNear { get; set;}

		[Ordinal(5)] [RED("("alphaScalarGrassDistFar")] 		public CFloat AlphaScalarGrassDistFar { get; set;}

		[Ordinal(6)] [RED("("alphaScalarBillboards")] 		public CFloat AlphaScalarBillboards { get; set;}

		[Ordinal(7)] [RED("("billboardsGrainBias")] 		public CFloat BillboardsGrainBias { get; set;}

		[Ordinal(8)] [RED("("billboardsGrainAlbedoScale")] 		public CFloat BillboardsGrainAlbedoScale { get; set;}

		[Ordinal(9)] [RED("("billboardsGrainNormalScale")] 		public CFloat BillboardsGrainNormalScale { get; set;}

		[Ordinal(10)] [RED("("billboardsGrainClipScale")] 		public CFloat BillboardsGrainClipScale { get; set;}

		[Ordinal(11)] [RED("("billboardsGrainClipBias")] 		public CFloat BillboardsGrainClipBias { get; set;}

		[Ordinal(12)] [RED("("billboardsGrainClipDamping")] 		public CFloat BillboardsGrainClipDamping { get; set;}

		[Ordinal(13)] [RED("("grassNormalsVariation")] 		public CFloat GrassNormalsVariation { get; set;}

		public SGlobalSpeedTreeParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SGlobalSpeedTreeParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}