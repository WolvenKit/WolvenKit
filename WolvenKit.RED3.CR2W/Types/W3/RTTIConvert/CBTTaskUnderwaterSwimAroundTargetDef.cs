using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskUnderwaterSwimAroundTargetDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("distance")] 		public CBehTreeValFloat Distance { get; set;}

		[Ordinal(2)] [RED("frontalHeadingOffset")] 		public CBehTreeValInt FrontalHeadingOffset { get; set;}

		[Ordinal(3)] [RED("randomFactor")] 		public CBehTreeValInt RandomFactor { get; set;}

		[Ordinal(4)] [RED("randomHeightAmplitude")] 		public CBehTreeValFloat RandomHeightAmplitude { get; set;}

		[Ordinal(5)] [RED("minimumWaterDepth")] 		public CBehTreeValFloat MinimumWaterDepth { get; set;}

		[Ordinal(6)] [RED("useActionTarget")] 		public CBehTreeValBool UseActionTarget { get; set;}

		[Ordinal(7)] [RED("maxProximityToSurface")] 		public CFloat MaxProximityToSurface { get; set;}

		public CBTTaskUnderwaterSwimAroundTargetDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskUnderwaterSwimAroundTargetDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}