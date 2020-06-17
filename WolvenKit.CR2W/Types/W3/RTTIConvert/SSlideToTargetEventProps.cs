using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSlideToTargetEventProps : CVariable
	{
		[RED("minSlideDist")] 		public CFloat MinSlideDist { get; set;}

		[RED("maxSlideDist")] 		public CFloat MaxSlideDist { get; set;}

		[RED("slideToMaxDistIfTargetSeen")] 		public CBool SlideToMaxDistIfTargetSeen { get; set;}

		[RED("slideToMaxDistIfNoTarget")] 		public CBool SlideToMaxDistIfNoTarget { get; set;}

		public SSlideToTargetEventProps(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SSlideToTargetEventProps(cr2w);

	}
}