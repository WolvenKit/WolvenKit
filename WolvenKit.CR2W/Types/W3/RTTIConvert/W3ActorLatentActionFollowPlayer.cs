using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ActorLatentActionFollowPlayer : IPresetActorLatentAction
	{
		[RED("moveType")] 		public EMoveType MoveType { get; set;}

		[RED("keepDistance")] 		public CBool KeepDistance { get; set;}

		[RED("followDistance")] 		public CFloat FollowDistance { get; set;}

		[RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[RED("teleportToCatchup")] 		public CBool TeleportToCatchup { get; set;}

		[RED("cachupDistance")] 		public CFloat CachupDistance { get; set;}

		public W3ActorLatentActionFollowPlayer(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3ActorLatentActionFollowPlayer(cr2w);

	}
}