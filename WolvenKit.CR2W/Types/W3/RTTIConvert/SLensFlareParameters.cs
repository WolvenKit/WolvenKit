using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SLensFlareParameters : CVariable
	{
		[RED("nearDistance")] 		public CFloat NearDistance { get; set;}

		[RED("nearRange")] 		public CFloat NearRange { get; set;}

		[RED("farDistance")] 		public CFloat FarDistance { get; set;}

		[RED("farRange")] 		public CFloat FarRange { get; set;}

		[RED("elements", 2,0)] 		public CArray<SLensFlareElementParameters> Elements { get; set;}

		public SLensFlareParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SLensFlareParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}