using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBokehDofParams : CVariable
	{
		[RED("enabled")] 		public CBool Enabled { get; set;}

		[RED("hexToCircleScale")] 		public CFloat HexToCircleScale { get; set;}

		[RED("usePhysicalSetup")] 		public CBool UsePhysicalSetup { get; set;}

		[RED("planeInFocus")] 		public CFloat PlaneInFocus { get; set;}

		[RED("fStops")] 		public CEnum<EApertureValue> FStops { get; set;}

		[RED("bokehSizeMuliplier")] 		public CFloat BokehSizeMuliplier { get; set;}

		public SBokehDofParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBokehDofParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}