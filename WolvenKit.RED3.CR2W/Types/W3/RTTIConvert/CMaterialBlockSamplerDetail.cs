using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMaterialBlockSamplerDetail : CMaterialBlockSampler
	{
		[Ordinal(1)] [RED("scale")] 		public Vector Scale { get; set;}

		[Ordinal(2)] [RED("BlendStartDistance")] 		public CFloat BlendStartDistance { get; set;}

		[Ordinal(3)] [RED("BlendEndDistance")] 		public CFloat BlendEndDistance { get; set;}

		public CMaterialBlockSamplerDetail(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMaterialBlockSamplerDetail(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}