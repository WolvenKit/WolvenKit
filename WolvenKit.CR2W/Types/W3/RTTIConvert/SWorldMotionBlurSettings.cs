using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SWorldMotionBlurSettings : CVariable
	{
		[Ordinal(1)] [RED("isPostTonemapping")] 		public CBool IsPostTonemapping { get; set;}

		[Ordinal(2)] [RED("distanceNear")] 		public CFloat DistanceNear { get; set;}

		[Ordinal(3)] [RED("distanceRange")] 		public CFloat DistanceRange { get; set;}

		[Ordinal(4)] [RED("strengthNear")] 		public CFloat StrengthNear { get; set;}

		[Ordinal(5)] [RED("strengthFar")] 		public CFloat StrengthFar { get; set;}

		[Ordinal(6)] [RED("fullBlendOverPixels")] 		public CFloat FullBlendOverPixels { get; set;}

		[Ordinal(7)] [RED("standoutDistanceNear")] 		public CFloat StandoutDistanceNear { get; set;}

		[Ordinal(8)] [RED("standoutDistanceRange")] 		public CFloat StandoutDistanceRange { get; set;}

		[Ordinal(9)] [RED("standoutAmountNear")] 		public CFloat StandoutAmountNear { get; set;}

		[Ordinal(10)] [RED("standoutAmountFar")] 		public CFloat StandoutAmountFar { get; set;}

		[Ordinal(11)] [RED("sharpenAmount")] 		public CFloat SharpenAmount { get; set;}

		public SWorldMotionBlurSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SWorldMotionBlurSettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}