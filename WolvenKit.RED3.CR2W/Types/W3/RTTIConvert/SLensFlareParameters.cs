using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SLensFlareParameters : CVariable
	{
		[Ordinal(1)] [RED("nearDistance")] 		public CFloat NearDistance { get; set;}

		[Ordinal(2)] [RED("nearRange")] 		public CFloat NearRange { get; set;}

		[Ordinal(3)] [RED("farDistance")] 		public CFloat FarDistance { get; set;}

		[Ordinal(4)] [RED("farRange")] 		public CFloat FarRange { get; set;}

		[Ordinal(5)] [RED("elements", 2,0)] 		public CArray<SLensFlareElementParameters> Elements { get; set;}

		public SLensFlareParameters(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SLensFlareParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}