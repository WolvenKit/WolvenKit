using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIFollowParams : IAIActionParameters
	{
		[RED("targetTag")] 		public CName TargetTag { get; set;}

		[RED("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[RED("keepDistance")] 		public CBool KeepDistance { get; set;}

		[RED("followDistance")] 		public CFloat FollowDistance { get; set;}

		[RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[RED("followTargetSelection")] 		public CBool FollowTargetSelection { get; set;}

		[RED("teleportToCatchup")] 		public CBool TeleportToCatchup { get; set;}

		[RED("cachupDistance")] 		public CFloat CachupDistance { get; set;}

		[RED("rotateToWhenAtTarget")] 		public CBool RotateToWhenAtTarget { get; set;}

		public CAIFollowParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIFollowParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}