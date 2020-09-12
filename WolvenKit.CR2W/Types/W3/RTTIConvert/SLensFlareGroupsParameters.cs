using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SLensFlareGroupsParameters : CVariable
	{
		[Ordinal(1)] [RED("default")] 		public SLensFlareParameters Default { get; set;}

		[Ordinal(2)] [RED("sun")] 		public SLensFlareParameters Sun { get; set;}

		[Ordinal(3)] [RED("moon")] 		public SLensFlareParameters Moon { get; set;}

		[Ordinal(4)] [RED("custom0")] 		public SLensFlareParameters Custom0 { get; set;}

		[Ordinal(5)] [RED("custom1")] 		public SLensFlareParameters Custom1 { get; set;}

		[Ordinal(6)] [RED("custom2")] 		public SLensFlareParameters Custom2 { get; set;}

		[Ordinal(7)] [RED("custom3")] 		public SLensFlareParameters Custom3 { get; set;}

		[Ordinal(8)] [RED("custom4")] 		public SLensFlareParameters Custom4 { get; set;}

		[Ordinal(9)] [RED("custom5")] 		public SLensFlareParameters Custom5 { get; set;}

		public SLensFlareGroupsParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SLensFlareGroupsParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}