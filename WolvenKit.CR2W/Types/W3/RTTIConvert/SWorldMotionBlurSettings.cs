using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SWorldMotionBlurSettings : CVariable
	{
		[RED("isPostTonemapping")] 		public CBool IsPostTonemapping { get; set;}

		[RED("distanceNear")] 		public CFloat DistanceNear { get; set;}

		[RED("distanceRange")] 		public CFloat DistanceRange { get; set;}

		[RED("strengthNear")] 		public CFloat StrengthNear { get; set;}

		[RED("strengthFar")] 		public CFloat StrengthFar { get; set;}

		[RED("fullBlendOverPixels")] 		public CFloat FullBlendOverPixels { get; set;}

		[RED("standoutDistanceNear")] 		public CFloat StandoutDistanceNear { get; set;}

		[RED("standoutDistanceRange")] 		public CFloat StandoutDistanceRange { get; set;}

		[RED("standoutAmountNear")] 		public CFloat StandoutAmountNear { get; set;}

		[RED("standoutAmountFar")] 		public CFloat StandoutAmountFar { get; set;}

		[RED("sharpenAmount")] 		public CFloat SharpenAmount { get; set;}

		public SWorldMotionBlurSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SWorldMotionBlurSettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}