using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskUnderwaterSwimAroundTarget : CBTTaskVolumetricMove
	{
		[RED("distance")] 		public CFloat Distance { get; set;}

		[RED("frontalHeadingOffset")] 		public CInt32 FrontalHeadingOffset { get; set;}

		[RED("randomFactor")] 		public CInt32 RandomFactor { get; set;}

		[RED("randomHeightAmplitude")] 		public CFloat RandomHeightAmplitude { get; set;}

		[RED("minimumWaterDepth")] 		public CFloat MinimumWaterDepth { get; set;}

		[RED("useActionTarget")] 		public CBool UseActionTarget { get; set;}

		[RED("maxProximityToSurface")] 		public CFloat MaxProximityToSurface { get; set;}

		public CBTTaskUnderwaterSwimAroundTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskUnderwaterSwimAroundTarget(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}