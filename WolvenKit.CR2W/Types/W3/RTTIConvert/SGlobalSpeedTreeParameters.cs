using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SGlobalSpeedTreeParameters : CVariable
	{
		[RED("alphaScalar3d")] 		public CFloat AlphaScalar3d { get; set;}

		[RED("alphaScalarGrassNear")] 		public CFloat AlphaScalarGrassNear { get; set;}

		[RED("alphaScalarGrass")] 		public CFloat AlphaScalarGrass { get; set;}

		[RED("alphaScalarGrassDistNear")] 		public CFloat AlphaScalarGrassDistNear { get; set;}

		[RED("alphaScalarGrassDistFar")] 		public CFloat AlphaScalarGrassDistFar { get; set;}

		[RED("alphaScalarBillboards")] 		public CFloat AlphaScalarBillboards { get; set;}

		[RED("billboardsGrainBias")] 		public CFloat BillboardsGrainBias { get; set;}

		[RED("billboardsGrainAlbedoScale")] 		public CFloat BillboardsGrainAlbedoScale { get; set;}

		[RED("billboardsGrainNormalScale")] 		public CFloat BillboardsGrainNormalScale { get; set;}

		[RED("billboardsGrainClipScale")] 		public CFloat BillboardsGrainClipScale { get; set;}

		[RED("billboardsGrainClipBias")] 		public CFloat BillboardsGrainClipBias { get; set;}

		[RED("billboardsGrainClipDamping")] 		public CFloat BillboardsGrainClipDamping { get; set;}

		[RED("grassNormalsVariation")] 		public CFloat GrassNormalsVariation { get; set;}

		public SGlobalSpeedTreeParameters(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SGlobalSpeedTreeParameters(cr2w);

	}
}