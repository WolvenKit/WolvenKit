using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBokehDofParams : CVariable
	{
		[Ordinal(1)] [RED("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(2)] [RED("hexToCircleScale")] 		public CFloat HexToCircleScale { get; set;}

		[Ordinal(3)] [RED("usePhysicalSetup")] 		public CBool UsePhysicalSetup { get; set;}

		[Ordinal(4)] [RED("planeInFocus")] 		public CFloat PlaneInFocus { get; set;}

		[Ordinal(5)] [RED("fStops")] 		public CEnum<EApertureValue> FStops { get; set;}

		[Ordinal(6)] [RED("bokehSizeMuliplier")] 		public CFloat BokehSizeMuliplier { get; set;}

		public SBokehDofParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBokehDofParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}