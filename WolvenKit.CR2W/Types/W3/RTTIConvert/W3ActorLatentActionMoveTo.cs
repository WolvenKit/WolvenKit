using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ActorLatentActionMoveTo : IPresetActorLatentAction
	{
		[RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[RED("moveType")] 		public EMoveType MoveType { get; set;}

		[RED("targetTag")] 		public CName TargetTag { get; set;}

		[RED("rotateAfterwards")] 		public CBool RotateAfterwards { get; set;}

		public W3ActorLatentActionMoveTo(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3ActorLatentActionMoveTo(cr2w);

	}
}