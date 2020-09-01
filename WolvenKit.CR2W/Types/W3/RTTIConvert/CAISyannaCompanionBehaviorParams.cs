using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAISyannaCompanionBehaviorParams : IAIActionParameters
	{
		[Ordinal(1)] [RED("targetTag")] 		public CName TargetTag { get; set;}

		[Ordinal(2)] [RED("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[Ordinal(3)] [RED("keepDistance")] 		public CBool KeepDistance { get; set;}

		[Ordinal(4)] [RED("followDistance")] 		public CFloat FollowDistance { get; set;}

		[Ordinal(5)] [RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		[Ordinal(6)] [RED("followTargetSelection")] 		public CBool FollowTargetSelection { get; set;}

		[Ordinal(7)] [RED("teleportToCatchup")] 		public CBool TeleportToCatchup { get; set;}

		[Ordinal(8)] [RED("cachupDistance")] 		public CFloat CachupDistance { get; set;}

		[Ordinal(9)] [RED("rotateToWhenAtTarget")] 		public CBool RotateToWhenAtTarget { get; set;}

		[Ordinal(10)] [RED("idleTimeToPlaySlotAnim")] 		public CFloat IdleTimeToPlaySlotAnim { get; set;}

		[Ordinal(11)] [RED("slotAnimCooldown")] 		public CFloat SlotAnimCooldown { get; set;}

		[Ordinal(12)] [RED("slotName")] 		public CName SlotName { get; set;}

		[Ordinal(13)] [RED("animName_1_start")] 		public CName AnimName_1_start { get; set;}

		[Ordinal(14)] [RED("animName_1_loop")] 		public CName AnimName_1_loop { get; set;}

		[Ordinal(15)] [RED("animName_1_stop")] 		public CName AnimName_1_stop { get; set;}

		[Ordinal(16)] [RED("animName_2_start")] 		public CName AnimName_2_start { get; set;}

		[Ordinal(17)] [RED("animName_2_loop")] 		public CName AnimName_2_loop { get; set;}

		[Ordinal(18)] [RED("animName_2_stop")] 		public CName AnimName_2_stop { get; set;}

		[Ordinal(19)] [RED("animName_3_start")] 		public CName AnimName_3_start { get; set;}

		[Ordinal(20)] [RED("animName_3_loop")] 		public CName AnimName_3_loop { get; set;}

		[Ordinal(21)] [RED("animName_3_stop")] 		public CName AnimName_3_stop { get; set;}

		[Ordinal(22)] [RED("animName_4_start")] 		public CName AnimName_4_start { get; set;}

		[Ordinal(23)] [RED("animName_4_loop")] 		public CName AnimName_4_loop { get; set;}

		[Ordinal(24)] [RED("animName_4_stop")] 		public CName AnimName_4_stop { get; set;}

		public CAISyannaCompanionBehaviorParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAISyannaCompanionBehaviorParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}