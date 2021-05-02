using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3SE_PlayAnimationOnEntity : W3SwitchEvent
	{
		[Ordinal(1)] [RED("entityTag")] 		public CName EntityTag { get; set;}

		[Ordinal(2)] [RED("animationName")] 		public CName AnimationName { get; set;}

		[Ordinal(3)] [RED("operation")] 		public CEnum<EPropertyAnimationOperation> Operation { get; set;}

		[Ordinal(4)] [RED("playCount")] 		public CInt32 PlayCount { get; set;}

		[Ordinal(5)] [RED("playLengthScale")] 		public CFloat PlayLengthScale { get; set;}

		[Ordinal(6)] [RED("playMode")] 		public CEnum<EPropertyCurveMode> PlayMode { get; set;}

		[Ordinal(7)] [RED("rewindTime")] 		public CFloat RewindTime { get; set;}

		public W3SE_PlayAnimationOnEntity(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}