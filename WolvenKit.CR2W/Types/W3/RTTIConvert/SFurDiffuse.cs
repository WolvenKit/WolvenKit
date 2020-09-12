using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurDiffuse : CVariable
	{
		[Ordinal(1)] [RED("diffuseBlend")] 		public CFloat DiffuseBlend { get; set;}

		[Ordinal(2)] [RED("diffuseScale")] 		public CFloat DiffuseScale { get; set;}

		[Ordinal(3)] [RED("diffuseHairNormalWeight")] 		public CFloat DiffuseHairNormalWeight { get; set;}

		[Ordinal(4)] [RED("diffuseBoneIndex")] 		public CUInt32 DiffuseBoneIndex { get; set;}

		[Ordinal(5)] [RED("diffuseBoneLocalPos")] 		public Vector DiffuseBoneLocalPos { get; set;}

		[Ordinal(6)] [RED("diffuseNoiseScale")] 		public CFloat DiffuseNoiseScale { get; set;}

		[Ordinal(7)] [RED("diffuseNoiseFreqU")] 		public CFloat DiffuseNoiseFreqU { get; set;}

		[Ordinal(8)] [RED("diffuseNoiseFreqV")] 		public CFloat DiffuseNoiseFreqV { get; set;}

		[Ordinal(9)] [RED("diffuseNoiseGain")] 		public CFloat DiffuseNoiseGain { get; set;}

		public SFurDiffuse(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFurDiffuse(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}