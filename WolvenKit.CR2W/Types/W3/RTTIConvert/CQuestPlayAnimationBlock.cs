using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CQuestPlayAnimationBlock : CQuestGraphBlock
	{
		[RED("entityTag")] 		public CName EntityTag { get; set;}

		[RED("animationName")] 		public CName AnimationName { get; set;}

		[RED("operation")] 		public EPropertyAnimationOperation Operation { get; set;}

		[RED("playCount")] 		public CUInt32 PlayCount { get; set;}

		[RED("playLengthScale")] 		public CFloat PlayLengthScale { get; set;}

		[RED("playPropertyCurveMode")] 		public EPropertyCurveMode PlayPropertyCurveMode { get; set;}

		[RED("rewindTime")] 		public CFloat RewindTime { get; set;}

		public CQuestPlayAnimationBlock(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CQuestPlayAnimationBlock(cr2w);

	}
}