using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAISyannaCompanionBehaviorParams : IAIActionParameters
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

		[RED("idleTimeToPlaySlotAnim")] 		public CFloat IdleTimeToPlaySlotAnim { get; set;}

		[RED("slotAnimCooldown")] 		public CFloat SlotAnimCooldown { get; set;}

		[RED("slotName")] 		public CName SlotName { get; set;}

		[RED("animName_1_start")] 		public CName AnimName_1_start { get; set;}

		[RED("animName_1_loop")] 		public CName AnimName_1_loop { get; set;}

		[RED("animName_1_stop")] 		public CName AnimName_1_stop { get; set;}

		[RED("animName_2_start")] 		public CName AnimName_2_start { get; set;}

		[RED("animName_2_loop")] 		public CName AnimName_2_loop { get; set;}

		[RED("animName_2_stop")] 		public CName AnimName_2_stop { get; set;}

		[RED("animName_3_start")] 		public CName AnimName_3_start { get; set;}

		[RED("animName_3_loop")] 		public CName AnimName_3_loop { get; set;}

		[RED("animName_3_stop")] 		public CName AnimName_3_stop { get; set;}

		[RED("animName_4_start")] 		public CName AnimName_4_start { get; set;}

		[RED("animName_4_loop")] 		public CName AnimName_4_loop { get; set;}

		[RED("animName_4_stop")] 		public CName AnimName_4_stop { get; set;}

		public CAISyannaCompanionBehaviorParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAISyannaCompanionBehaviorParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}