using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurDiffuse : CVariable
	{
		[RED("diffuseBlend")] 		public CFloat DiffuseBlend { get; set;}

		[RED("diffuseScale")] 		public CFloat DiffuseScale { get; set;}

		[RED("diffuseHairNormalWeight")] 		public CFloat DiffuseHairNormalWeight { get; set;}

		[RED("diffuseBoneIndex")] 		public CUInt32 DiffuseBoneIndex { get; set;}

		[RED("diffuseBoneLocalPos")] 		public Vector DiffuseBoneLocalPos { get; set;}

		[RED("diffuseNoiseScale")] 		public CFloat DiffuseNoiseScale { get; set;}

		[RED("diffuseNoiseFreqU")] 		public CFloat DiffuseNoiseFreqU { get; set;}

		[RED("diffuseNoiseFreqV")] 		public CFloat DiffuseNoiseFreqV { get; set;}

		[RED("diffuseNoiseGain")] 		public CFloat DiffuseNoiseGain { get; set;}

		public SFurDiffuse(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurDiffuse(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}