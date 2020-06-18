using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SE_PlayAnimationOnEntity : W3SwitchEvent
	{
		[RED("entityTag")] 		public CName EntityTag { get; set;}

		[RED("animationName")] 		public CName AnimationName { get; set;}

		[RED("operation")] 		public CEnum<EPropertyAnimationOperation> Operation { get; set;}

		[RED("playCount")] 		public CInt32 PlayCount { get; set;}

		[RED("playLengthScale")] 		public CFloat PlayLengthScale { get; set;}

		[RED("playMode")] 		public CEnum<EPropertyCurveMode> PlayMode { get; set;}

		[RED("rewindTime")] 		public CFloat RewindTime { get; set;}

		public W3SE_PlayAnimationOnEntity(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3SE_PlayAnimationOnEntity(cr2w);

	}
}