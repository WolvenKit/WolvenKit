using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ActorLatentActionFollowPlayer : IPresetActorLatentAction
	{
		[Ordinal(1)] [RED("("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[Ordinal(2)] [RED("("keepDistance")] 		public CBool KeepDistance { get; set;}

		[Ordinal(3)] [RED("("followDistance")] 		public CFloat FollowDistance { get; set;}

		[Ordinal(4)] [RED("("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[Ordinal(5)] [RED("("teleportToCatchup")] 		public CBool TeleportToCatchup { get; set;}

		[Ordinal(6)] [RED("("cachupDistance")] 		public CFloat CachupDistance { get; set;}

		public W3ActorLatentActionFollowPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ActorLatentActionFollowPlayer(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}