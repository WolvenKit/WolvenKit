using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvSharpenParameters : CVariable
	{
		[Ordinal(1)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(2)] [RED("sharpenNear")] 		public SSimpleCurve SharpenNear { get; set;}

		[Ordinal(3)] [RED("sharpenFar")] 		public SSimpleCurve SharpenFar { get; set;}

		[Ordinal(4)] [RED("distanceNear")] 		public SSimpleCurve DistanceNear { get; set;}

		[Ordinal(5)] [RED("distanceFar")] 		public SSimpleCurve DistanceFar { get; set;}

		[Ordinal(6)] [RED("lumFilterOffset")] 		public SSimpleCurve LumFilterOffset { get; set;}

		[Ordinal(7)] [RED("lumFilterRange")] 		public SSimpleCurve LumFilterRange { get; set;}

		public CEnvSharpenParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvSharpenParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}