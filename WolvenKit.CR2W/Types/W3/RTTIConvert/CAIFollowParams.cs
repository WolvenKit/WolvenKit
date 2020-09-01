using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIFollowParams : IAIActionParameters
	{
		[Ordinal(0)] [RED("targetTag")] 		public CName TargetTag { get; set;}

		[Ordinal(0)] [RED("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[Ordinal(0)] [RED("keepDistance")] 		public CBool KeepDistance { get; set;}

		[Ordinal(0)] [RED("followDistance")] 		public CFloat FollowDistance { get; set;}

		[Ordinal(0)] [RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[Ordinal(0)] [RED("followTargetSelection")] 		public CBool FollowTargetSelection { get; set;}

		[Ordinal(0)] [RED("teleportToCatchup")] 		public CBool TeleportToCatchup { get; set;}

		[Ordinal(0)] [RED("cachupDistance")] 		public CFloat CachupDistance { get; set;}

		[Ordinal(0)] [RED("rotateToWhenAtTarget")] 		public CBool RotateToWhenAtTarget { get; set;}

		public CAIFollowParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIFollowParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}