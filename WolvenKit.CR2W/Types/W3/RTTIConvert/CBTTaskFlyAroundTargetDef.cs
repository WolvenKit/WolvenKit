using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskFlyAroundTargetDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("("distance")] 		public CBehTreeValFloat Distance { get; set;}

		[Ordinal(0)] [RED("("frontalHeadingOffset")] 		public CBehTreeValInt FrontalHeadingOffset { get; set;}

		[Ordinal(0)] [RED("("randomFactor")] 		public CBehTreeValInt RandomFactor { get; set;}

		[Ordinal(0)] [RED("("height")] 		public CBehTreeValFloat Height { get; set;}

		[Ordinal(0)] [RED("("randomHeightAmplitude")] 		public CBehTreeValFloat RandomHeightAmplitude { get; set;}

		public CBTTaskFlyAroundTargetDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskFlyAroundTargetDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}