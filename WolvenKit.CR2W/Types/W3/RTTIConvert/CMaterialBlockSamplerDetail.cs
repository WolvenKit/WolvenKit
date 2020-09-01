using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMaterialBlockSamplerDetail : CMaterialBlockSampler
	{
		[Ordinal(0)] [RED("scale")] 		public Vector Scale { get; set;}

		[Ordinal(0)] [RED("BlendStartDistance")] 		public CFloat BlendStartDistance { get; set;}

		[Ordinal(0)] [RED("BlendEndDistance")] 		public CFloat BlendEndDistance { get; set;}

		public CMaterialBlockSamplerDetail(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMaterialBlockSamplerDetail(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}