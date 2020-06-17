using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlyAroundTargetDef : IBehTreeTaskDefinition
	{
		[RED("distance")] 		public CBehTreeValFloat Distance { get; set;}

		[RED("frontalHeadingOffset")] 		public CBehTreeValInt FrontalHeadingOffset { get; set;}

		[RED("randomFactor")] 		public CBehTreeValInt RandomFactor { get; set;}

		[RED("height")] 		public CBehTreeValFloat Height { get; set;}

		[RED("randomHeightAmplitude")] 		public CBehTreeValFloat RandomHeightAmplitude { get; set;}

		public CBTTaskFlyAroundTargetDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskFlyAroundTargetDef(cr2w);

	}
}