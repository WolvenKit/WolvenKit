using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskNPCNotInFrontOfPLayerDef : IBehTreeConditionalTaskDefinition
	{
		[Ordinal(1)] [RED("coneAngle")] 		public CFloat ConeAngle { get; set;}

		[Ordinal(2)] [RED("angleOffset")] 		public CFloat AngleOffset { get; set;}

		[Ordinal(3)] [RED("coneRange")] 		public CFloat ConeRange { get; set;}

		public CBTTaskNPCNotInFrontOfPLayerDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskNPCNotInFrontOfPLayerDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}